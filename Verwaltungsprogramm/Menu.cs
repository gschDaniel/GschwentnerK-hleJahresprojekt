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

namespace Verwaltungsprogramm
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btn_editpb_Click(object sender, EventArgs e)
        {
            txt_changepb.Visible = true;
            OpenFileDialog open = new OpenFileDialog();
            if(open.ShowDialog() == DialogResult.OK)
            {
                txt_changepb.Text = open.FileName;
                pb_main.Image = new Bitmap(open.FileName);
            }
            txt_changepb.Visible = false;
        }

        private void btn_changeColors_Click(object sender, EventArgs e)
        {
            label_1Main.ForeColor = Color.DarkOrange;
            lbl_2Main.ForeColor = Color.DarkOrange;
            lbl_4Main.BackColor = Color.OliveDrab;
            lbl_5Main.BackColor = Color.OliveDrab;
            lbl_managebooks.BackColor = Color.DarkOrange;
           
            btn_addBook.ForeColor = Color.Black;
            //btn_changeColors.ForeColor = Color.Black;
            btn_changeName.ForeColor = Color.Black;
            btn_editpb.ForeColor = Color.Black;
            btn_logout.ForeColor = Color.Black;
            btn_makeOwnBook.ForeColor = Color.Black;
            btn_showBooks.ForeColor = Color.Black;

            panel5.BackColor = Color.OliveDrab;
            panel3.BackColor = Color.OliveDrab;
            panel4.BackColor = Color.DarkOrange;
            p1main.BackColor = Color.Black;
           
        }

        private void btn_showBooks_Click(object sender, EventArgs e)
        {
            Menu_Load(sender, e);
        }

        private void btn_changeName_Click(object sender, EventArgs e)
        {
            lbl_2Main.Visible = false;
            tb_changeName.Visible = true;
            btn_changeName1.Visible = true;

        }

        private void btn_changeName1_Click(object sender, EventArgs e)
        {
            lbl_2Main.Visible = true;
            tb_changeName.Visible = false;
            btn_changeName1.Visible = false;
            lbl_2Main.Text = tb_changeName.Text;
        }

        private void btn_darkmode_Click(object sender, EventArgs e)
        {
            label_1Main.ForeColor = Color.WhiteSmoke;
            lbl_2Main.ForeColor = Color.White;
            lbl_3Main.ForeColor = Color.WhiteSmoke;

            btn_editpb.BackColor = Color.DimGray;
            btn_editpb.ForeColor = Color.White;
            btn_changeName.BackColor = Color.DimGray;
            btn_changeName.ForeColor = Color.White;
            //btn_changeColors.BackColor = Color.DimGray;
            //btn_changeColors.ForeColor = Color.White;
            btn_darkmode.BackColor = Color.DimGray;
            btn_darkmode.ForeColor = Color.White;
            btn_logout.BackColor = Color.DimGray;
            btn_logout.ForeColor = Color.White;
            btn_lightmode.BackColor = Color.DimGray;
            btn_lightmode.ForeColor = Color.White;

            btn_addBook.ForeColor = Color.Black;
            btn_makeOwnBook.ForeColor = Color.Black;
            btn_showBooks.ForeColor = Color.Black;


            panel5.BackColor = Color.OliveDrab;
            BackColor = Color.Gray;
            panel3.BackColor = Color.OliveDrab;
            panel4.BackColor = Color.DarkOrange;
            p1main.BackColor = Color.Black;
            p2main.BackColor = Color.DimGray;

            btn_lightmode.Visible = true;

            btn_darkmode.Visible = false;
        }

        private void btn_lightmode_Click(object sender, EventArgs e)
        {
            p1main.BackColor = Color.FromArgb(165, 171, 247);
            p2main.BackColor = Color.LightGray;
            BackColor = Color.WhiteSmoke;
            label_1Main.ForeColor = Color.FromArgb(99, 91, 245);
            lbl_2Main.ForeColor = Color.FromArgb(99, 91, 245); ;
            lbl_3Main.ForeColor = Color.Black;
            panel5.BackColor = Color.FromArgb(78, 72, 194);
            panel4.BackColor = Color.FromArgb(81, 79, 117);
            panel3.BackColor = Color.FromArgb(78, 72, 194);

            btn_editpb.BackColor = Color.WhiteSmoke;
            btn_editpb.ForeColor = Color.Black;
            btn_changeName.BackColor = Color.WhiteSmoke;
            btn_changeName.ForeColor = Color.Black;
            //btn_changeColors.BackColor = Color.WhiteSmoke;
            //btn_changeColors.ForeColor = Color.Black;
            btn_darkmode.BackColor = Color.WhiteSmoke;
            btn_darkmode.ForeColor = Color.Black;
            btn_logout.BackColor = Color.WhiteSmoke;
            btn_logout.ForeColor = Color.Black;
            
            

            btn_lightmode.Visible = false;
            btn_darkmode.Visible = true;
        }

        private void btn_makeOwnBook_Click(object sender, EventArgs e)
        {
            RentBook rentBook = new RentBook();
            rentBook.ShowDialog();
            Menu_Load(sender, e);
        }

        private void btn_addBook_Click(object sender, EventArgs e)
        {
            AddBook addBook = new AddBook();
            addBook.ShowDialog();
            Menu_Load(sender, e);
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            DataTable dt = SQLClass.LoadBooks();
            dataGridView1.DataSource = dt;
            dataGridView1.Columns["Id"].Visible = false;

            lbl_2Main.Text = User.UserName;
            lbl_3Main.Text = User.UserRole.ToString();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_return_Click(object sender, EventArgs e)
        {
            Returnbook returnbook = new Returnbook();
            returnbook.ShowDialog();
            Menu_Load(sender, e);
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_barcode_Click(object sender, EventArgs e)
        {
            Barcode barcodeScan = new Barcode();
            barcodeScan.ShowDialog();
        }

        private void btn_deletebook_Click(object sender, EventArgs e)
        {
            if(User.UserRole==Role.Admin)
            {
                DeleteBook deleteBook = new DeleteBook();
                deleteBook.ShowDialog();
                Menu_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Du bist kein Admin", "Keine Rechte", MessageBoxButtons.OK);
            }
            
        }

        private void p1main_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txt_searchMain_TextChanged(object sender, EventArgs e)
        {
            string rowFilter = string.Format("[Titel] Like '%{1}%'", "Titel", txt_searchMain.Text);
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
        }

        private void label_1Main_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_googleAPI_Click(object sender, EventArgs e)
        {
            API_search api = new API_search();
            api.ShowDialog();
            Menu_Load(sender, e);
        }
    }
}
