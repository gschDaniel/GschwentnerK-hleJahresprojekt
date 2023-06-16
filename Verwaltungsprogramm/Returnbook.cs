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
    public partial class Returnbook : Form
    {
        public Returnbook()
        {
            InitializeComponent();
        }

        private void Returnbook_Load(object sender, EventArgs e)
        {
            DataTable dtBooks = SQLClass.RentedBooksAndUser();
            dgv_return.DataSource = dtBooks;
        }

        private void btn_return_Click(object sender, EventArgs e)
        {
            bool returnBook = SQLClass.ReturnBook(3);

            int selectedRowCount = dgv_return.Rows.GetRowCount(DataGridViewElementStates.Selected);

            if (selectedRowCount > 0)
            {
                int rentalId = Int32.Parse(dgv_return.Rows[selectedRowCount - 1].Cells["Id"].Value.ToString());

                if (SQLClass.ReturnBook(rentalId))
                {
                    string bookTitle = dgv_return.Rows[selectedRowCount - 1].Cells["BuchTitel"].Value.ToString();
                    string username = dgv_return.Rows[selectedRowCount - 1].Cells["BuchTitel"].Value.ToString();
                    MessageBox.Show("Das Buch '" + bookTitle + "' wurde von '" + username + "' zurückgegeben!", "Zurückgegeben!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                Returnbook_Load(sender, e);
            }
        }
    }
}
