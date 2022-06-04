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

namespace BookStore
{
    public partial class Form1 : Form
    {
        NpgsqlConnection conn;
        List<Author> authors;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: set localhost

            var connString = "Host=192.168.1.104;Username=postgres;Password=admin;Database=book-store";
            conn = new NpgsqlConnection(connString);
            conn.Open();

            updateUsersUI();
            updateBooksUI();
            updateAuthorsUI();
            proceduresCB.SelectedIndex = 0;
        }

        private void usersLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (usersLB.SelectedIndex != -1)
            {
                var user = (User)usersLB.SelectedItem;
                editUserNameTB.Text = user.name;
                editUserPhoneTB.Text = user.phone;
                editUserAddressTB.Text = user.address;
                updateUserBooksUI();
            }
            deleteUserB.Enabled = usersLB.SelectedIndex != -1;
            saveUserB.Enabled = usersLB.SelectedIndex != -1;
            addBoughtBookB.Enabled = usersLB.SelectedIndex != -1;
        }

        private void addUserB_Click(object sender, EventArgs e)
        {
            var name = addUserNameTB.Text;
            var phone = addUserPhoneTB.Text;
            var address = addUserAddressTB.Text;
            var cmd = new NpgsqlCommand($"INSERT INTO users (name,phone,address) VALUES('{name}','{phone}','{address}')", conn);
            cmd.ExecuteNonQuery();
            updateUsersUI();
        }

        private void saveUserB_Click(object sender, EventArgs e)
        {
            var user = (User)usersLB.SelectedItem;
            var name = editUserNameTB.Text;
            var phone = editUserPhoneTB.Text;
            var address = editUserAddressTB.Text;
            var cmd = new NpgsqlCommand($"UPDATE users SET name='{name}',phone='{phone}',address='{address}' WHERE id = {user.id}", conn);
            cmd.ExecuteNonQuery();
            updateUsersUI();
        }

        private void deleteUserB_Click(object sender, EventArgs e)
        {
            if (usersLB.SelectedIndex != -1)
            {
                var user = (User)usersLB.SelectedItem;
                var cmd = new NpgsqlCommand($"DELETE FROM users WHERE id = {user.id}", conn);
                cmd.ExecuteNonQuery();
                updateUsersUI();
            }
        }

        private void addBoughtBookB_Click(object sender, EventArgs e)
        {
            var user = (User)usersLB.SelectedItem;
            var book = (Book)addBoughtBookCB.SelectedItem;
            var cmd = new NpgsqlCommand($"INSERT INTO bought_books (user_id, book_id) VALUES({user.id}, {book.id})", conn);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (PostgresException)
            {
                MessageBox.Show("Ця книга вже куплена.", "Помилка");
            }

            updateUserBooksUI();
        }

        private void authorsLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (authorsLB.SelectedIndex != -1)
            {
                var author = (Author)authorsLB.SelectedItem;
                editAuthorNameTB.Text = author.name;
            }
            deleteAuthorB.Enabled = authorsLB.SelectedIndex != -1;
            saveAuthorB.Enabled = authorsLB.SelectedIndex != -1;
        }

        private void addAuthorB_Click(object sender, EventArgs e)
        {
            var name = addAuthorNameTB.Text;
            var cmd = new NpgsqlCommand($"INSERT INTO author (name) VALUES('{name}')", conn);
            cmd.ExecuteNonQuery();
            updateAuthorsUI();
        }

        private void saveAuthorB_Click(object sender, EventArgs e)
        {
            var author = (Author)authorsLB.SelectedItem;
            var name = editAuthorNameTB.Text;
            var cmd = new NpgsqlCommand($"UPDATE author SET name='{name}' WHERE id = {author.id}", conn);
            cmd.ExecuteNonQuery();
            updateAuthorsUI();
        }

        private void deleteAuthorB_Click(object sender, EventArgs e)
        {
            if (authorsLB.SelectedIndex != -1)
            {
                var author = (Author)authorsLB.SelectedItem;
                var cmd = new NpgsqlCommand($"DELETE FROM author WHERE id = {author.id}", conn);
                cmd.ExecuteNonQuery();
                updateAuthorsUI();
                updateBooksUI();
            }
        }

        private void booksLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (booksLB.SelectedIndex != -1)
            {
                var book = (Book)booksLB.SelectedItem;
                editBookNameTB.Text = book.name;
                editBookAuthorCB.SelectedIndex = authors.FindIndex((v) => v.id == book.author_id);
            }
            deleteBookB.Enabled = booksLB.SelectedIndex != -1;
            saveBookB.Enabled = booksLB.SelectedIndex != -1;
        }

        private void addBookB_Click(object sender, EventArgs e)
        {
            var name = addBookNameTB.Text;
            var author = (Author)addBook_AuthorCB.SelectedItem;
            var cmd = new NpgsqlCommand($"INSERT INTO book (name, author_id) VALUES('{name}', {author.id})", conn);
            cmd.ExecuteNonQuery();
            updateBooksUI();
        }

        private void deleteBookB_Click(object sender, EventArgs e)
        {
            if (booksLB.SelectedIndex != -1)
            {
                var book = (Book)booksLB.SelectedItem;
                var cmd = new NpgsqlCommand($"DELETE FROM book WHERE id = {book.id}", conn);
                cmd.ExecuteNonQuery();
                updateBooksUI();
                updateUserBooksUI();
            }
        }

        private void saveBookB_Click(object sender, EventArgs e)
        {
            var book = (Book)booksLB.SelectedItem;
            var name = editBookNameTB.Text;
            var author = (Author)editBookAuthorCB.SelectedItem;
            var cmd = new NpgsqlCommand($"UPDATE book SET name='{name}', author_id={author.id} WHERE id = {book.id}", conn);
            cmd.ExecuteNonQuery();
            updateBooksUI();
        }
        private void callProcedureB_Click(object sender, EventArgs e)
        {
            var procName = proceduresCB.SelectedItem.ToString();
            var cmd = new NpgsqlCommand($"CALL {procName}()", conn);
            cmd.ExecuteNonQuery();
            updateUsersUI();
            updateUserBooksUI();
            updateBooksUI();
            updateAuthorsUI();
        }


        void updateBooksUI()
        {
            var books = loadBooks();

            var selectedBookId = ((Book)booksLB.SelectedItem)?.id ?? -1;
            booksLB.Items.Clear();
            booksLB.Items.AddRange(books.ToArray());
            booksLB.SelectedIndex = books.FindIndex((v) => v.id == selectedBookId);
            deleteBookB.Enabled = booksLB.SelectedIndex != -1;
            saveBookB.Enabled = booksLB.SelectedIndex != -1;

            addBoughtBookCB.Items.Clear();
            addBoughtBookCB.Items.AddRange(books.ToArray());
            addBoughtBookCB.SelectedIndex = addBoughtBookCB.Items.Count > 0 ? 0 : -1;
        }

        void updateAuthorsUI()
        {
            authors = loadAuthors();

            var selectedAuthorId = ((Author)authorsLB.SelectedItem)?.id ?? -1;
            authorsLB.Items.Clear();
            authorsLB.Items.AddRange(authors.ToArray());
            authorsLB.SelectedIndex = authors.FindIndex((v) => v.id == selectedAuthorId);
            deleteAuthorB.Enabled = authorsLB.SelectedIndex != -1;
            saveAuthorB.Enabled = authorsLB.SelectedIndex != -1;

            editBookAuthorCB.Items.Clear();
            editBookAuthorCB.Items.AddRange(authors.ToArray());
            editBookAuthorCB.SelectedIndex = editBookAuthorCB.Items.Count > 0 ? 0 : -1;

            addBook_AuthorCB.Items.Clear();
            addBook_AuthorCB.Items.AddRange(authors.ToArray());
            addBook_AuthorCB.SelectedIndex = addBook_AuthorCB.Items.Count > 0 ? 0 : -1;
        }

        void updateUsersUI()
        {
            var selected = (User)usersLB.SelectedItem;
            int selectedIndex = -1;
            int i = 0;

            var cmd = new NpgsqlCommand("SELECT * FROM users", conn);
            var reader = cmd.ExecuteReader();
            usersLB.Items.Clear();

            while (reader.Read())
            {
                var id = reader.GetInt32(0);
                usersLB.Items.Add(new User(id, reader.GetString(1), reader.GetString(2), reader.GetString(3)));

                if (selected != null && selected.id == id)
                {
                    selectedIndex = i;
                }
                i++;
            }
            reader.Close();

            usersLB.SelectedIndex = selectedIndex;
            deleteUserB.Enabled = usersLB.SelectedIndex != -1;
            saveUserB.Enabled = usersLB.SelectedIndex != -1;
            addBoughtBookB.Enabled = usersLB.SelectedIndex != -1;
        }

        List<Author> loadAuthors()
        {
            var authors = new List<Author>();
            var cmd = new NpgsqlCommand($"SELECT * FROM author", conn);
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                authors.Add(new Author(reader.GetInt32(0), reader.GetString(1)));
            }
            reader.Close();
            return authors;
        }

        List<Book> loadBooks()
        {
            var books = new List<Book>();
            var cmd = new NpgsqlCommand($"SELECT * FROM book", conn);
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                books.Add(new Book(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2)));
            }
            reader.Close();
            return books;
        }

        void updateUserBooksUI()
        {
            userBooksLB.Items.Clear();
            User user = (User)usersLB.SelectedItem;

            if (user != null)
            {
                var cmd = new NpgsqlCommand($"SELECT * FROM book b JOIN bought_books bb ON bb.book_id = b.id AND bb.user_id = {user.id}", conn);
                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    userBooksLB.Items.Add(new Book(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2)));
                }
                reader.Close();
            }
        }
    }
}
