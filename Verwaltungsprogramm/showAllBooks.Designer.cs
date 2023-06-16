namespace Verwaltungsprogramm
{
    partial class showAllBooks
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.test = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_markBook = new System.Windows.Forms.Button();
            this.btn_createExcel = new System.Windows.Forms.Button();
            this.btn_downloadBook = new System.Windows.Forms.Button();
            this.p1main = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.p2main = new System.Windows.Forms.Panel();
            this.label_1Main = new System.Windows.Forms.Label();
            this.lbl_3Main = new System.Windows.Forms.Label();
            this.lbl_2Main = new System.Windows.Forms.Label();
            this.pb_main = new System.Windows.Forms.PictureBox();
            this.txt_searchMain = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.p1main.SuspendLayout();
            this.p2main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_main)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.test});
            this.dataGridView1.Location = new System.Drawing.Point(316, 125);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(486, 399);
            this.dataGridView1.TabIndex = 10;
            // 
            // test
            // 
            this.test.HeaderText = "Column1";
            this.test.Name = "test";
            // 
            // btn_markBook
            // 
            this.btn_markBook.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_markBook.Location = new System.Drawing.Point(0, 352);
            this.btn_markBook.Name = "btn_markBook";
            this.btn_markBook.Size = new System.Drawing.Size(231, 70);
            this.btn_markBook.TabIndex = 5;
            this.btn_markBook.Text = "Buch markieren";
            this.btn_markBook.UseVisualStyleBackColor = true;
            // 
            // btn_createExcel
            // 
            this.btn_createExcel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_createExcel.Location = new System.Drawing.Point(0, 253);
            this.btn_createExcel.Name = "btn_createExcel";
            this.btn_createExcel.Size = new System.Drawing.Size(231, 68);
            this.btn_createExcel.TabIndex = 4;
            this.btn_createExcel.Text = "Liste in Excel übertragen";
            this.btn_createExcel.UseVisualStyleBackColor = true;
            this.btn_createExcel.Click += new System.EventHandler(this.btn_createExcel_Click);
            // 
            // btn_downloadBook
            // 
            this.btn_downloadBook.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_downloadBook.Location = new System.Drawing.Point(0, 152);
            this.btn_downloadBook.Name = "btn_downloadBook";
            this.btn_downloadBook.Size = new System.Drawing.Size(231, 68);
            this.btn_downloadBook.TabIndex = 3;
            this.btn_downloadBook.Text = "Buch downloaden";
            this.btn_downloadBook.UseVisualStyleBackColor = true;
            // 
            // p1main
            // 
            this.p1main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(171)))), ((int)(((byte)(247)))));
            this.p1main.Controls.Add(this.button1);
            this.p1main.Controls.Add(this.btn_downloadBook);
            this.p1main.Controls.Add(this.btn_markBook);
            this.p1main.Controls.Add(this.btn_createExcel);
            this.p1main.Dock = System.Windows.Forms.DockStyle.Left;
            this.p1main.Location = new System.Drawing.Point(0, 0);
            this.p1main.Name = "p1main";
            this.p1main.Size = new System.Drawing.Size(231, 629);
            this.p1main.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(0, 602);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "Zurück";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // p2main
            // 
            this.p2main.BackColor = System.Drawing.Color.LightGray;
            this.p2main.Controls.Add(this.label_1Main);
            this.p2main.Controls.Add(this.lbl_3Main);
            this.p2main.Controls.Add(this.lbl_2Main);
            this.p2main.Controls.Add(this.pb_main);
            this.p2main.Controls.Add(this.txt_searchMain);
            this.p2main.Location = new System.Drawing.Point(-362, 0);
            this.p2main.Name = "p2main";
            this.p2main.Size = new System.Drawing.Size(1659, 100);
            this.p2main.TabIndex = 12;
            // 
            // label_1Main
            // 
            this.label_1Main.AutoSize = true;
            this.label_1Main.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_1Main.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(91)))), ((int)(((byte)(245)))));
            this.label_1Main.Location = new System.Drawing.Point(374, 20);
            this.label_1Main.Name = "label_1Main";
            this.label_1Main.Size = new System.Drawing.Size(260, 55);
            this.label_1Main.TabIndex = 5;
            this.label_1Main.Text = "Verwaltung";
            // 
            // lbl_3Main
            // 
            this.lbl_3Main.AutoSize = true;
            this.lbl_3Main.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_3Main.ForeColor = System.Drawing.Color.Black;
            this.lbl_3Main.Location = new System.Drawing.Point(1421, 50);
            this.lbl_3Main.Name = "lbl_3Main";
            this.lbl_3Main.Size = new System.Drawing.Size(138, 25);
            this.lbl_3Main.TabIndex = 4;
            this.lbl_3Main.Text = "Administrator";
            // 
            // lbl_2Main
            // 
            this.lbl_2Main.AutoSize = true;
            this.lbl_2Main.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_2Main.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(91)))), ((int)(((byte)(245)))));
            this.lbl_2Main.Location = new System.Drawing.Point(1364, 20);
            this.lbl_2Main.Name = "lbl_2Main";
            this.lbl_2Main.Size = new System.Drawing.Size(247, 29);
            this.lbl_2Main.TabIndex = 3;
            this.lbl_2Main.Text = "Daniel Gschwentner";
            // 
            // pb_main
            // 
            this.pb_main.BackColor = System.Drawing.Color.Black;
            this.pb_main.Location = new System.Drawing.Point(1266, 12);
            this.pb_main.Name = "pb_main";
            this.pb_main.Size = new System.Drawing.Size(70, 73);
            this.pb_main.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_main.TabIndex = 2;
            this.pb_main.TabStop = false;
            // 
            // txt_searchMain
            // 
            this.txt_searchMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_searchMain.Location = new System.Drawing.Point(640, 38);
            this.txt_searchMain.Name = "txt_searchMain";
            this.txt_searchMain.Size = new System.Drawing.Size(450, 35);
            this.txt_searchMain.TabIndex = 1;
            // 
            // showAllBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1289, 629);
            this.Controls.Add(this.p2main);
            this.Controls.Add(this.p1main);
            this.Controls.Add(this.dataGridView1);
            this.Name = "showAllBooks";
            this.Text = "showAllBooks";
            this.Load += new System.EventHandler(this.showAllBooks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.p1main.ResumeLayout(false);
            this.p2main.ResumeLayout(false);
            this.p2main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_main)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_markBook;
        private System.Windows.Forms.Button btn_createExcel;
        private System.Windows.Forms.Button btn_downloadBook;
        private System.Windows.Forms.Panel p1main;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel p2main;
        private System.Windows.Forms.Label label_1Main;
        private System.Windows.Forms.Label lbl_3Main;
        private System.Windows.Forms.Label lbl_2Main;
        private System.Windows.Forms.PictureBox pb_main;
        private System.Windows.Forms.TextBox txt_searchMain;
        private System.Windows.Forms.DataGridViewTextBoxColumn test;
    }
}