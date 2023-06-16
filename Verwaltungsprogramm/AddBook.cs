using Aspose.BarCode.BarCodeRecognition;
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
    //old form
    public partial class AddBook : Form
    {
        public AddBook(string author, string title, string desc)
        {
            InitializeComponent();
            tb_Author.Text = author;
            tb_booktitle.Text = title;
            tb_beschreibung.Text = desc;
        }

        public AddBook()
        {
            InitializeComponent();
        }

        private void AddBook_Load(object sender, EventArgs e)
        {

        }

        public DataSet Import(string filename, bool headers = true)
        {
            var _xl = new Microsoft.Office.Interop.Excel.Application();
            var wb = _xl.Workbooks.Open(filename);
            var sheets = wb.Sheets;
            DataSet dataSet = null;
            if (sheets != null && sheets.Count != 0)
            {
                dataSet = new DataSet();
                foreach (var item in sheets)
                {
                    var sheet = (Microsoft.Office.Interop.Excel.Worksheet)item;
                    DataTable dt = null;
                    if (sheet != null)
                    {
                        dt = new DataTable();
                        var ColumnCount = ((Microsoft.Office.Interop.Excel.Range)sheet.UsedRange.Rows[1, Type.Missing]).Columns.Count;
                        var rowCount = ((Microsoft.Office.Interop.Excel.Range)sheet.UsedRange.Columns[1, Type.Missing]).Rows.Count;

                        for (int j = 0; j < ColumnCount; j++)
                        {
                            var cell = (Microsoft.Office.Interop.Excel.Range)sheet.Cells[1, j + 1];
                            var column = new DataColumn(headers ? cell.Value : string.Empty);
                            dt.Columns.Add(column);
                        }

                        for (int i = 0; i < rowCount; i++)
                        {
                            var r = dt.NewRow();
                            for (int j = 0; j < ColumnCount; j++)
                            {
                                var cell = (Microsoft.Office.Interop.Excel.Range)sheet.Cells[i + 1 + (headers ? 1 : 0), j + 1];
                                r[j] = cell.Value;
                            }
                            dt.Rows.Add(r);
                        }

                    }
                    dataSet.Tables.Add(dt);
                }
            }
            _xl.Quit();
            return dataSet;
        }
        private void lb_books_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_createExcel_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_upload_Click(object sender, EventArgs e)
        {
            //lbl_path.Visible = true;
            //OpenFileDialog open = new OpenFileDialog();
            //if (open.ShowDialog() == DialogResult.OK)
            //{
            //    lbl_path.Text = open.FileName;
            //    pb_preview.Image = new Bitmap(open.FileName);
            //}
            //lbl_path.Visible = false;
        }

        private void btn_importbarcode_Click(object sender, EventArgs e)
        {
            //lbl_path2.Visible = true;
            //OpenFileDialog open = new OpenFileDialog();
            //if (open.ShowDialog() == DialogResult.OK)
            //{
            //    lbl_path2.Text = open.FileName;
            //    pb_preview.Image = new Bitmap(open.FileName);
            //}
            //lbl_path.Visible = false;

            //using (BarCodeReader reader = new BarCodeReader(lbl_path2.Text))
                
            //{
            //    foreach (BarCodeResult result in reader.ReadBarCodes())
            //    {
            //        //tb_booktitle.Text = result.CodeText.AsSpan(17).ToString();
            //        //tb_booktitle.Text = result.CodeText.Length.ToString();
            //        //tb_booktitle.Text = result.CodeText;
            //        tb_booktitle.Text = "Type: " + result.CodeText;

            //        //tb_beschreibung.Text = result.CodeText;

                    
            //    }
            //}
        }

        private void btn_createbook_Click(object sender, EventArgs e)
        {
            Book b = new Book();
            b.Author = tb_Author.Text;
            b.Barcode = tb_barcode.Text;
            b.Title = tb_booktitle.Text;
            b.Description = tb_beschreibung.Text;
            b.ReleaseDate = monthCalendar1.SelectionRange.Start.Date;
            b.Genre = tb_Genre.Text;
            


            string msg = SQLClass.AddBook(b) ? "Buch wurde hinzugefügt!" : "Dieses Buch existiert bereits!";
            MessageBox.Show(msg, "Buchstatus", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //ToDo: USE THIS WHEN RENTING A BOOK! or adding AMOUNT
            //int before = SQLClass.AddBookAmount(b, 10);
            //int rentOne = SQLClass.RentBook(b);
            //int returnBook = SQLClass.ReturnBook(b);
        }

        private void btn_scan_Click(object sender, EventArgs e)
        {
            tb_barcode.Text = Barcode.OFDReadBarcode();
        }

        private void btn_googleAPI_Click(object sender, EventArgs e)
        {
        }
    }
}
