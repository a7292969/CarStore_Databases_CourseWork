using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football
{
    internal class Match
    {
        public int id;
        public String team1;
        public String team2;
        public int stadium_id;

        public Match(int id, String team1, String team2, int stadium_id)
        {
            this.id = id;
            this.team1 = team1;
            this.team2 = team2;
            this.stadium_id = stadium_id;
        }

        public override string ToString()
        {
            return team1 + " - " + team2;
        }
    }
}
