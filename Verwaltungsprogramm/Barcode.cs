using IronBarCode;
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
    public partial class Barcode : Form
    {

        public static string OFDReadBarcode()
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "JPG|*.jpg|PNG|*.png|Alle Dateitypen|*" })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {

                    BarcodeResult br = BarcodeReader.QuicklyReadOneBarcode(ofd.FileName);

                    if (br != null)
                    {
                        return br.Text;
                    }
                }
                return null;
            }
        }

        public Barcode()
        {
            InitializeComponent();
        }

        public void btn_barcode_Click(object sender, EventArgs e)
        {
            tb_scan.Text = OFDReadBarcode();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string barcode = tb_scan.Text;
            Book book = SQLClass.GetBookByBarcode(barcode);

            if (book is null)
            {
                MessageBox.Show("Buch mit folgendem Barcode konnte nicht gefunden werden: " + barcode, "Fehler!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                lbl_resultauthor.Text = book.Author;
                lbl_resulttitle.Text = book.Title;
                lbl_resultrealeasedate.Text = book.ReleaseDate.ToString();
                lbl_resultdesc.Text = book.Description;
            }
        }

        private void pb_barcode_Click(object sender, EventArgs e)
        {

        }
    }
}
