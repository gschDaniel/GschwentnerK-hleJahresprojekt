
namespace Verwaltungsprogramm
{
    partial class Barcode
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_barcode = new System.Windows.Forms.Button();
            this.tb_scan = new System.Windows.Forms.TextBox();
            this.lbl_todo = new System.Windows.Forms.Label();
            this.lbl_title = new System.Windows.Forms.Label();
            this.lbl_realeasedate = new System.Windows.Forms.Label();
            this.lbl_resulttitle = new System.Windows.Forms.Label();
            this.lbl_resultrealeasedate = new System.Windows.Forms.Label();
            this.lbl_discreption = new System.Windows.Forms.Label();
            this.lbl_resultdesc = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_resultauthor = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.pb_barcode = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_barcode)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_barcode
            // 
            this.btn_barcode.Location = new System.Drawing.Point(12, 23);
            this.btn_barcode.Name = "btn_barcode";
            this.btn_barcode.Size = new System.Drawing.Size(97, 33);
            this.btn_barcode.TabIndex = 0;
            this.btn_barcode.Text = "Einscannen";
            this.btn_barcode.UseVisualStyleBackColor = true;
            this.btn_barcode.Click += new System.EventHandler(this.btn_barcode_Click);
            // 
            // tb_scan
            // 
            this.tb_scan.Location = new System.Drawing.Point(127, 30);
            this.tb_scan.Name = "tb_scan";
            this.tb_scan.Size = new System.Drawing.Size(233, 20);
            this.tb_scan.TabIndex = 1;
            // 
            // lbl_todo
            // 
            this.lbl_todo.AutoSize = true;
            this.lbl_todo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_todo.ForeColor = System.Drawing.Color.Red;
            this.lbl_todo.Location = new System.Drawing.Point(24, 185);
            this.lbl_todo.Name = "lbl_todo";
            this.lbl_todo.Size = new System.Drawing.Size(585, 25);
            this.lbl_todo.TabIndex = 2;
            this.lbl_todo.Text = "Zu erledigen bis ganzjahr Scanner noch zu 100% ausbauen";
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(14, 74);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(38, 20);
            this.lbl_title.TabIndex = 3;
            this.lbl_title.Text = "Titel";
            // 
            // lbl_realeasedate
            // 
            this.lbl_realeasedate.AutoSize = true;
            this.lbl_realeasedate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_realeasedate.Location = new System.Drawing.Point(219, 74);
            this.lbl_realeasedate.Name = "lbl_realeasedate";
            this.lbl_realeasedate.Size = new System.Drawing.Size(151, 20);
            this.lbl_realeasedate.TabIndex = 4;
            this.lbl_realeasedate.Text = "Erscheinungsdatum";
            // 
            // lbl_resulttitle
            // 
            this.lbl_resulttitle.AutoSize = true;
            this.lbl_resulttitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_resulttitle.Location = new System.Drawing.Point(18, 98);
            this.lbl_resulttitle.Name = "lbl_resulttitle";
            this.lbl_resulttitle.Size = new System.Drawing.Size(51, 20);
            this.lbl_resulttitle.TabIndex = 5;
            this.lbl_resulttitle.Text = "label1";
            // 
            // lbl_resultrealeasedate
            // 
            this.lbl_resultrealeasedate.AutoSize = true;
            this.lbl_resultrealeasedate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_resultrealeasedate.Location = new System.Drawing.Point(219, 98);
            this.lbl_resultrealeasedate.Name = "lbl_resultrealeasedate";
            this.lbl_resultrealeasedate.Size = new System.Drawing.Size(51, 20);
            this.lbl_resultrealeasedate.TabIndex = 6;
            this.lbl_resultrealeasedate.Text = "label1";
            // 
            // lbl_discreption
            // 
            this.lbl_discreption.AutoSize = true;
            this.lbl_discreption.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_discreption.Location = new System.Drawing.Point(387, 74);
            this.lbl_discreption.Name = "lbl_discreption";
            this.lbl_discreption.Size = new System.Drawing.Size(107, 20);
            this.lbl_discreption.TabIndex = 7;
            this.lbl_discreption.Text = "Beschreibung";
            // 
            // lbl_resultdesc
            // 
            this.lbl_resultdesc.AutoSize = true;
            this.lbl_resultdesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_resultdesc.Location = new System.Drawing.Point(387, 98);
            this.lbl_resultdesc.Name = "lbl_resultdesc";
            this.lbl_resultdesc.Size = new System.Drawing.Size(51, 20);
            this.lbl_resultdesc.TabIndex = 8;
            this.lbl_resultdesc.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(98, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Autor";
            // 
            // lbl_resultauthor
            // 
            this.lbl_resultauthor.AutoSize = true;
            this.lbl_resultauthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_resultauthor.Location = new System.Drawing.Point(98, 98);
            this.lbl_resultauthor.Name = "lbl_resultauthor";
            this.lbl_resultauthor.Size = new System.Drawing.Size(51, 20);
            this.lbl_resultauthor.TabIndex = 10;
            this.lbl_resultauthor.Text = "label1";
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(572, 33);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(127, 46);
            this.btn_search.TabIndex = 11;
            this.btn_search.Text = "Suchen";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // pb_barcode
            // 
            this.pb_barcode.Location = new System.Drawing.Point(572, 98);
            this.pb_barcode.Name = "pb_barcode";
            this.pb_barcode.Size = new System.Drawing.Size(127, 84);
            this.pb_barcode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pb_barcode.TabIndex = 12;
            this.pb_barcode.TabStop = false;
            this.pb_barcode.Click += new System.EventHandler(this.pb_barcode_Click);
            // 
            // Barcode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 282);
            this.Controls.Add(this.pb_barcode);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.lbl_resultauthor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_resultdesc);
            this.Controls.Add(this.lbl_discreption);
            this.Controls.Add(this.lbl_resultrealeasedate);
            this.Controls.Add(this.lbl_resulttitle);
            this.Controls.Add(this.lbl_realeasedate);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.lbl_todo);
            this.Controls.Add(this.tb_scan);
            this.Controls.Add(this.btn_barcode);
            this.Name = "Barcode";
            this.Text = "Barcode";
            ((System.ComponentModel.ISupportInitialize)(this.pb_barcode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_barcode;
        private System.Windows.Forms.TextBox tb_scan;
        private System.Windows.Forms.Label lbl_todo;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label lbl_realeasedate;
        private System.Windows.Forms.Label lbl_resultTitle;
        private System.Windows.Forms.Label lbl_resultrealeasedate;
        private System.Windows.Forms.Label lbl_discreption;
        private System.Windows.Forms.Label lbl_resultdesc;
        private System.Windows.Forms.Label lbl_resulttitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_resultauthor;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.PictureBox pb_barcode;
    }
}