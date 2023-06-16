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
    public partial class createOwnBook : Form
    {
        public createOwnBook()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_upload_Click(object sender, EventArgs e)
        {
            lbl_path.Visible = true;
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                lbl_path.Text = open.FileName;
                pb_preview.Image = new Bitmap(open.FileName);
            }
            lbl_path.Visible = false;
        }

        private void btn_create_Click(object sender, EventArgs e)
        {

        }
    }
}
