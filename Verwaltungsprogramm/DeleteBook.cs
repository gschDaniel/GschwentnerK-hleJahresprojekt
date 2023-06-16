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
    public partial class DeleteBook : Form
    {
        public DeleteBook()
        {
            InitializeComponent();
        }

        private void DeleteBook_Load(object sender, EventArgs e)
        {
            DataTable dt = SQLClass.LoadBooks();
            dgv_deletebook.DataSource = dt;
            dgv_deletebook.MultiSelect = false;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            int index = dgv_deletebook.SelectedRows[0].Index;

            if(index != null || index != 1)
            {
                int id = (int)dgv_deletebook["Id", index].Value;
                SQLClass.RemoveBook(id);
                MessageBox.Show("Das Buch ' "+ dgv_deletebook["Titel", index].Value.ToString() + "'  wurde Gelöscht", "Buch gelöscht", MessageBoxButtons.OK);
                DeleteBook_Load(sender, e);
            }

        }
    }
}
