using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Verwaltungsprogramm.Classes;
using BC = BCrypt.Net.BCrypt;

namespace Verwaltungsprogramm
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            SQLClass.Initialize();
            //MessageBox.Show("Erfolgreich Erstellt");
            //Menu menu = new Menu();
            //this.Hide();
            //menu.ShowDialog();
            //this.Show();
            //Book b = new Book();
            //b.Barcode = "3A325BC96";
            //b.Author = "Daniel";
            //b.Title = "Unser erstes Buch";
            //b.Description = "Das ist ein wunderbares buch Beschr.";
            //b.ReleaseDate = DateTime.Now;
            //b.Genre = "Roman";
            //b.BooksLeft = 10;

            //string log1 = SQLClass.AddBook(b) ? "Added Book" : "NOT ADDED";
            //MessageBox.Show(log1);

            //Book b = SQLClass.GetBookByBarcode("3A325BC96");

            //MessageBox.Show(b.Title);
            //string s = SQLClass.Register("danny", "Test1!", "daniel", "gschwen") ? "registriert" : "benutzer existiert bereits";
            //MessageBox.Show(s);

            //int before = SQLClass.AddBookAmount(8, 10);
            //bool rented = SQLClass.RentBook(1, 8, DateTime.Now, DateTime.Now.AddDays(2));
            //bool returnBook = SQLClass.ReturnBook(3);

            //MessageBox.Show("bef: " + before + ";rentOne: " + rentOne + ";returnBook: " + returnBook);
            //SQLClass.Register(tb_username.Text, tb_password.Text);
        }

        private void tb_username_Enter(object sender, EventArgs e)
        {
            tb_username.BackColor = Color.WhiteSmoke;
        }

        private void tb_username_Leave(object sender, EventArgs e)
        {
            tb_username.BackColor = Color.White;
        }

        private void tb_password_Enter(object sender, EventArgs e)
        {
            tb_password.BackColor = Color.WhiteSmoke;
        }

        private void tb_password_Leave(object sender, EventArgs e)
        {
            tb_password.BackColor = Color.White;
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (SQLClass.Login(tb_username.Text, tb_password.Text))
            {
                DataTable dt = SQL.GetData("Select * from Users where username='" + tb_username.Text + "';");
                DataRow dataRow = dt.Rows[0];
                User.UserName = tb_username.Text;
                string roleName = dataRow["Role"].ToString();
                Role r = Role.DefaultUser;

                Enum.TryParse(roleName, out r);
                User.UserRole = r;
                
                Menu menu = new Menu();
                this.Hide();
                menu.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Anmeldefehler", "Benutzername oder Password falsch!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Registration registration = new Registration();
            this.Hide();
            registration.ShowDialog();
            this.Close();
        }
    }
}
