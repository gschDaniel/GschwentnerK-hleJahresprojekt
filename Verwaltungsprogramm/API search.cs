using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Verwaltungsprogramm.Classes;

namespace Verwaltungsprogramm
{
    public partial class API_search : Form
    {
        public API_search()
        {
            InitializeComponent();
        }

        private void API_search_Load(object sender, EventArgs e)
        {

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            try
            {
                var request = (HttpWebRequest)WebRequest.Create(@"https://www.googleapis.com/books/v1/volumes?q=" + txt_buchtitel.Text + "+inauthor:"+ txt_autor.Text);
                
                var response = (HttpWebResponse)request.GetResponse();
                string responseString;
                using (var stream = response.GetResponseStream())
                {
                    using (var reader = new StreamReader(stream))
                    {
                        responseString = reader.ReadToEnd();
                    }
                }

                Root tmp = JsonConvert.DeserializeObject<Root>(responseString);

                if (tmp != null)
                {
                    DataTable dt = new DataTable();
                    dt.Columns.Add("Autor");
                    dt.Columns.Add("Titel");
                    dt.Columns.Add("Veröffentlichung");
                    dt.Columns.Add("Beschreibung");


                    foreach (Item i in tmp.items)
                    {
                        DataRow dr = dt.NewRow();
                        if (i.volumeInfo.authors != null) dr["Autor"] = i.volumeInfo.authors[0].ToString();
                        if (i.volumeInfo.title != null) dr["Titel"] = i.volumeInfo.title.ToString();
                        if (i.volumeInfo.publishedDate != null) dr["Veröffentlichung"] = i.volumeInfo.publishedDate.ToString();
                        if (i.volumeInfo.description != null) dr["Beschreibung"] = i.volumeInfo.description.ToString();
                        dt.Rows.Add(dr);
                    }
                    dataGridView1.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Buch konnte nicht gefunden werden!", "Buchn nicht gefunden!");
                }
               
            }
            catch
            {
                MessageBox.Show("Es ist ein Fehler Aufgetretten!", "Fehler!");
            }
        }

        private void txt_buchtitel_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_addselected_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.SelectedRows[0].Index;

            if (index != null || index != 1)
            {
                string author = dataGridView1["Autor", index].Value.ToString();
                string title = dataGridView1["Titel", index].Value.ToString();
                string desc = dataGridView1["Beschreibung", index].Value.ToString();
                AddBook addBook = new AddBook(author, title, desc);
                addBook.ShowDialog();
            }
            else
            {
                MessageBox.Show("Kein Buch ausgewählt!", "Auswahl!");
            }


        }
    }
}
