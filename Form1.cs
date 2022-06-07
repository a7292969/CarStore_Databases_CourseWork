using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace Football
{
    public partial class Form1 : Form
    {
        NpgsqlConnection conn;
        List<Stadium> stadiums;
        List<Match> matches;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: set localhost

            var connString = "Host=192.168.1.104;Username=postgres;Password=admin;Database=football";
            conn = new NpgsqlConnection(connString);
            conn.Open();

            updatePlayersUI();
            updateMatchesUI();
            updateStadiumsUI();
            proceduresCB.SelectedIndex = 0;
        }

        private void playersLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (playersLB.SelectedIndex != -1)
            {
                var player = (Player)playersLB.SelectedItem;
                editPlayerNameTB.Text = player.name;
                updatePlayerPositionsUI();
            }
            deletePlayerB.Enabled = playersLB.SelectedIndex != -1;
            savePlayerB.Enabled = playersLB.SelectedIndex != -1;
            addPlayerPositionB.Enabled = playersLB.SelectedIndex != -1;
        }

        private void addPlayerB_Click(object sender, EventArgs e)
        {
            var name = addPlayerNameTB.Text;
            var cmd = new NpgsqlCommand($"INSERT INTO player (name) VALUES('{name}')", conn);
            cmd.ExecuteNonQuery();
            updatePlayersUI();
        }

        private void savePlayerB_Click(object sender, EventArgs e)
        {
            var player = (Player)playersLB.SelectedItem;
            var name = editPlayerNameTB.Text;
            var cmd = new NpgsqlCommand($"UPDATE player SET name='{name}' WHERE id = {player.id}", conn);
            cmd.ExecuteNonQuery();
            updatePlayersUI();
        }

        private void deletePlayerB_Click(object sender, EventArgs e)
        {
            if (playersLB.SelectedIndex != -1)
            {
                var user = (Player)playersLB.SelectedItem;
                var cmd = new NpgsqlCommand($"DELETE FROM users WHERE id = {user.id}", conn);
                cmd.ExecuteNonQuery();
                updatePlayersUI();
            }
        }

        private void playerPositionsLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            deletePlayerPositionB.Enabled = playerPositionsLB.SelectedIndex != -1;
        }

        private void addPlayerPositionB_Click(object sender, EventArgs e)
        {
            var player = (Player)playersLB.SelectedItem;
            var match = (Match)addPlayerPositionMatchCB.SelectedItem;
            var position = addPlayerPositionNameTB.Text;
            var cmd = new NpgsqlCommand($"INSERT INTO positions (player_id, match_id, position) VALUES({player.id}, {match.id}, '{position}')", conn);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (PostgresException)
            {
                MessageBox.Show("Ця позиція вже існує.", "Помилка");
            }

            updatePlayerPositionsUI();
        }
        
        private void deletePlayerPositionB_Click(object sender, EventArgs e)
        {
            var position = (Position)playerPositionsLB.SelectedItem;
            var cmd = new NpgsqlCommand($"DELETE FROM positions WHERE player_id = {position.playerId} AND match_id={position.match.id}", conn);
            cmd.ExecuteNonQuery();
            updatePlayerPositionsUI();
        }

        private void stadiumsLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (statiumsLB.SelectedIndex != -1)
            {
                var author = (Stadium)statiumsLB.SelectedItem;
                editStadiumNameTB.Text = author.name;
            }
            deleteStadiumB.Enabled = statiumsLB.SelectedIndex != -1;
            saveStadiumB.Enabled = statiumsLB.SelectedIndex != -1;
        }

        private void addStadiumB_Click(object sender, EventArgs e)
        {
            var name = addStadiumNameTB.Text;
            var cmd = new NpgsqlCommand($"INSERT INTO stadium (name) VALUES('{name}')", conn);
            cmd.ExecuteNonQuery();
            updateStadiumsUI();
        }

        private void saveStadiumB_Click(object sender, EventArgs e)
        {
            var stadium = (Stadium)statiumsLB.SelectedItem;
            var name = editStadiumNameTB.Text;
            var cmd = new NpgsqlCommand($"UPDATE stadium SET name='{name}' WHERE id = {stadium.id}", conn);
            cmd.ExecuteNonQuery();
            updateStadiumsUI();
        }

        private void deleteStadiumB_Click(object sender, EventArgs e)
        {
            if (statiumsLB.SelectedIndex != -1)
            {
                var stadium = (Stadium)statiumsLB.SelectedItem;
                var cmd = new NpgsqlCommand($"DELETE FROM stadium WHERE id = {stadium.id}", conn);
                cmd.ExecuteNonQuery();
                updateStadiumsUI();
                updateMatchesUI();
            }
        }

        private void matchesLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (matchesLB.SelectedIndex != -1)
            {
                var match = (Match)matchesLB.SelectedItem;
                editMatchTeam1TB.Text = match.team1;
                editMatchTeam2TB.Text = match.team2;
                editMatchStadiumCB.SelectedIndex = stadiums.FindIndex((v) => v.id == match.stadium_id);
            }
            deleteMatchB.Enabled = matchesLB.SelectedIndex != -1;
            saveMatchB.Enabled = matchesLB.SelectedIndex != -1;
        }

        private void addMatchB_Click(object sender, EventArgs e)
        {
            var team1 = addMatchTeam1TB.Text;
            var team2 = addMatchTeam2TB.Text;
            var stadium = (Stadium)addMatchStadiumCB.SelectedItem;
            var cmd = new NpgsqlCommand($"INSERT INTO match (team1, team2, stadium_id) VALUES('{team1}', '{team2}', {stadium.id})", conn);
            cmd.ExecuteNonQuery();
            updateMatchesUI();
        }

        private void deleteMatchB_Click(object sender, EventArgs e)
        {
            if (matchesLB.SelectedIndex != -1)
            {
                var match = (Match)matchesLB.SelectedItem;
                var cmd = new NpgsqlCommand($"DELETE FROM match WHERE id = {match.id}", conn);
                cmd.ExecuteNonQuery();
                updateMatchesUI();
                updatePlayerPositionsUI();
            }
        }

        private void saveMatchB_Click(object sender, EventArgs e)
        {
            var match = (Match)matchesLB.SelectedItem;
            var team1 = editMatchTeam1TB.Text;
            var team2 = editMatchTeam2TB.Text;
            var stadium = (Stadium)editMatchStadiumCB.SelectedItem;
            var cmd = new NpgsqlCommand($"UPDATE match SET team1='{team1}', team2='{team2}', stadium_id={stadium.id} WHERE id = {match.id}", conn);
            cmd.ExecuteNonQuery();
            updateMatchesUI();
        }

        private void callProcedureB_Click(object sender, EventArgs e)
        {
            var procName = proceduresCB.SelectedItem.ToString();
            var cmd = new NpgsqlCommand($"CALL {procName}()", conn);
            cmd.ExecuteNonQuery();
            updatePlayersUI();
            updatePlayerPositionsUI();
            updateMatchesUI();
            updateStadiumsUI();
        }

        void updateMatchesUI()
        {
            matches = loadMatches();

            var selectedMatchId = ((Match)matchesLB.SelectedItem)?.id ?? -1;
            matchesLB.Items.Clear();
            matchesLB.Items.AddRange(matches.ToArray());
            matchesLB.SelectedIndex = matches.FindIndex((v) => v.id == selectedMatchId);
            deleteMatchB.Enabled = matchesLB.SelectedIndex != -1;
            saveMatchB.Enabled = matchesLB.SelectedIndex != -1;

            addPlayerPositionMatchCB.Items.Clear();
            addPlayerPositionMatchCB.Items.AddRange(matches.ToArray());
            addPlayerPositionMatchCB.SelectedIndex = addPlayerPositionMatchCB.Items.Count > 0 ? 0 : -1;
        }

        void updateStadiumsUI()
        {
            stadiums = loadStadiums();

            var selectedStadiumId = ((Stadium)statiumsLB.SelectedItem)?.id ?? -1;
            statiumsLB.Items.Clear();
            statiumsLB.Items.AddRange(stadiums.ToArray());
            statiumsLB.SelectedIndex = stadiums.FindIndex((v) => v.id == selectedStadiumId);
            deleteStadiumB.Enabled = statiumsLB.SelectedIndex != -1;
            saveStadiumB.Enabled = statiumsLB.SelectedIndex != -1;

            editMatchStadiumCB.Items.Clear();
            editMatchStadiumCB.Items.AddRange(stadiums.ToArray());
            editMatchStadiumCB.SelectedIndex = editMatchStadiumCB.Items.Count > 0 ? 0 : -1;

            addMatchStadiumCB.Items.Clear();
            addMatchStadiumCB.Items.AddRange(stadiums.ToArray());
            addMatchStadiumCB.SelectedIndex = addMatchStadiumCB.Items.Count > 0 ? 0 : -1;
        }

        void updatePlayersUI()
        {
            var selected = (Player)playersLB.SelectedItem;
            int selectedIndex = -1;
            int i = 0;

            var cmd = new NpgsqlCommand("SELECT * FROM player", conn);
            var reader = cmd.ExecuteReader();
            playersLB.Items.Clear();

            while (reader.Read())
            {
                var id = reader.GetInt32(0);
                playersLB.Items.Add(new Player(id, reader.GetString(1)));

                if (selected != null && selected.id == id)
                {
                    selectedIndex = i;
                }
                i++;
            }
            reader.Close();

            playersLB.SelectedIndex = selectedIndex;
            deletePlayerB.Enabled = playersLB.SelectedIndex != -1;
            savePlayerB.Enabled = playersLB.SelectedIndex != -1;
            addPlayerPositionB.Enabled = playersLB.SelectedIndex != -1;
        }

        List<Stadium> loadStadiums()
        {
            var stadiums = new List<Stadium>();
            var cmd = new NpgsqlCommand($"SELECT * FROM stadium", conn);
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                stadiums.Add(new Stadium(reader.GetInt32(0), reader.GetString(1)));
            }
            reader.Close();
            return stadiums;
        }

        List<Match> loadMatches()
        {
            var matches = new List<Match>();
            var cmd = new NpgsqlCommand($"SELECT * FROM match", conn);
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                matches.Add(new Match(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetInt32(3)));
            }
            reader.Close();
            return matches;
        }

        void updatePlayerPositionsUI()
        {
            playerPositionsLB.Items.Clear();
            Player player = (Player)playersLB.SelectedItem;

            if (player != null)
            {
                var cmd = new NpgsqlCommand($"SELECT * FROM positions WHERE player_id = {player.id}", conn);
                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    var match_id = reader.GetInt32(1);
                    var match = matches.Find((v) => v.id == match_id);
                    playerPositionsLB.Items.Add(new Position(reader.GetInt32(0), match, reader.GetString(2)));
                }
                reader.Close();
            }
        }
    }
}
