using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Verwaltungsprogramm
{
    public partial class RentBook : Form
    {
        private string bookTitle = "";
        private string username = "";


        public RentBook()
        {
            InitializeComponent();
        }

        private void RentBook_Load(object sender, EventArgs e)
        {
            mc_rentedAM.MaxSelectionCount = 1;
            mc_ausgeliehenBis.MaxSelectionCount = 1;
            DataTable dtBooks = SQLClass.LoadBooks();
            dgv_books.DataSource = dtBooks;

            DataTable dtUsers = SQLClass.LoadUsersWOPW();
            dgv_user.DataSource = dtUsers;
        }

        private void dgv_user_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgv_books_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_rent_Click(object sender, EventArgs e)
        {
            //int before = SQLClass.AddBookAmount(8, 10);
            

            //use the id's of user and books
            bool rented = SQLClass.RentBook(Int32.Parse(tb_user.Text), Int32.Parse(tb_books.Text), mc_rentedAM.SelectionStart.Date, mc_ausgeliehenBis.SelectionStart.Date);

            if (rented)
            {
                MessageBox.Show("Das Buch '" + bookTitle + "' wurde an '" + username + "' verliehen!", "Gespeichert!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RentBook_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Fehler bei der Auswahl des Users oder des Buches (Id ungültig oder es sind keine Exemplare mehr vorhanden)",  "Fehler!",  MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //bool returnBook = SQLClass.ReturnBook(3);
        }

        private void btn_takedata_Click(object sender, EventArgs e)
        {
            int selectedRowCountBooks =
                        dgv_books.Rows.GetRowCount(DataGridViewElementStates.Selected);

            int selectedRowCountUser =
                 dgv_user.Rows.GetRowCount(DataGridViewElementStates.Selected);
            
            if (selectedRowCountBooks > 0)
            {
                tb_books.Text = dgv_books.Rows[selectedRowCountBooks-1].Cells["Id"].Value.ToString();
                bookTitle = dgv_books.Rows[selectedRowCountUser - 1].Cells["Titel"].Value.ToString();
                lbl_booktitle.Text = bookTitle;
            }

            if (selectedRowCountUser > 0)
            {
                tb_user.Text = dgv_user.Rows[selectedRowCountUser-1].Cells["Id"].Value.ToString();
                username = dgv_user.Rows[selectedRowCountUser - 1].Cells["Username"].Value.ToString();
                lbl_username.Text = username;
            }
        }
    }
}
