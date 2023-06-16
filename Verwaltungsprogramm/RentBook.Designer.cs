
namespace Verwaltungsprogramm
{
    partial class RentBook
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
            this.dgv_user = new System.Windows.Forms.DataGridView();
            this.dgv_books = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_user = new System.Windows.Forms.TextBox();
            this.tb_books = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mc_rentedAM = new System.Windows.Forms.MonthCalendar();
            this.label4 = new System.Windows.Forms.Label();
            this.mc_ausgeliehenBis = new System.Windows.Forms.MonthCalendar();
            this.btn_rent = new System.Windows.Forms.Button();
            this.btn_takedata = new System.Windows.Forms.Button();
            this.lbl_username = new System.Windows.Forms.Label();
            this.lbl_booktitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_user)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_books)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_user
            // 
            this.dgv_user.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_user.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_user.Location = new System.Drawing.Point(424, 12);
            this.dgv_user.Name = "dgv_user";
            this.dgv_user.Size = new System.Drawing.Size(308, 229);
            this.dgv_user.TabIndex = 0;
            this.dgv_user.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_user_CellContentClick);
            // 
            // dgv_books
            // 
            this.dgv_books.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_books.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_books.Location = new System.Drawing.Point(424, 258);
            this.dgv_books.Name = "dgv_books";
            this.dgv_books.Size = new System.Drawing.Size(308, 242);
            this.dgv_books.TabIndex = 2;
            this.dgv_books.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_books_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "buchtitel";
            // 
            // tb_user
            // 
            this.tb_user.Location = new System.Drawing.Point(38, 66);
            this.tb_user.Name = "tb_user";
            this.tb_user.ReadOnly = true;
            this.tb_user.Size = new System.Drawing.Size(100, 20);
            this.tb_user.TabIndex = 1;
            // 
            // tb_books
            // 
            this.tb_books.Location = new System.Drawing.Point(38, 120);
            this.tb_books.Name = "tb_books";
            this.tb_books.ReadOnly = true;
            this.tb_books.Size = new System.Drawing.Size(100, 20);
            this.tb_books.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "ausgeliehen am";
            // 
            // mc_rentedAM
            // 
            this.mc_rentedAM.Location = new System.Drawing.Point(38, 192);
            this.mc_rentedAM.Name = "mc_rentedAM";
            this.mc_rentedAM.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 377);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "ausgeliehen bis";
            // 
            // mc_ausgeliehenBis
            // 
            this.mc_ausgeliehenBis.Location = new System.Drawing.Point(38, 399);
            this.mc_ausgeliehenBis.Name = "mc_ausgeliehenBis";
            this.mc_ausgeliehenBis.TabIndex = 10;
            // 
            // btn_rent
            // 
            this.btn_rent.Location = new System.Drawing.Point(504, 506);
            this.btn_rent.Name = "btn_rent";
            this.btn_rent.Size = new System.Drawing.Size(166, 58);
            this.btn_rent.TabIndex = 4;
            this.btn_rent.Text = "Verleihen";
            this.btn_rent.UseVisualStyleBackColor = true;
            this.btn_rent.Click += new System.EventHandler(this.btn_rent_Click);
            // 
            // btn_takedata
            // 
            this.btn_takedata.Location = new System.Drawing.Point(272, 57);
            this.btn_takedata.Name = "btn_takedata";
            this.btn_takedata.Size = new System.Drawing.Size(141, 37);
            this.btn_takedata.TabIndex = 3;
            this.btn_takedata.Text = "Daten übernehmen";
            this.btn_takedata.UseVisualStyleBackColor = true;
            this.btn_takedata.Click += new System.EventHandler(this.btn_takedata_Click);
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Location = new System.Drawing.Point(159, 69);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(55, 13);
            this.lbl_username.TabIndex = 13;
            this.lbl_username.Text = "Username";
            // 
            // lbl_booktitle
            // 
            this.lbl_booktitle.AutoSize = true;
            this.lbl_booktitle.Location = new System.Drawing.Point(159, 123);
            this.lbl_booktitle.Name = "lbl_booktitle";
            this.lbl_booktitle.Size = new System.Drawing.Size(48, 13);
            this.lbl_booktitle.TabIndex = 14;
            this.lbl_booktitle.Text = "Buchtitel";
            // 
            // RentBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 576);
            this.Controls.Add(this.lbl_booktitle);
            this.Controls.Add(this.lbl_username);
            this.Controls.Add(this.btn_takedata);
            this.Controls.Add(this.btn_rent);
            this.Controls.Add(this.mc_ausgeliehenBis);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.mc_rentedAM);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_books);
            this.Controls.Add(this.tb_user);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_books);
            this.Controls.Add(this.dgv_user);
            this.Name = "RentBook";
            this.Text = "RentBook";
            this.Load += new System.EventHandler(this.RentBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_user)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_books)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_user;
        private System.Windows.Forms.DataGridView dgv_books;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_user;
        private System.Windows.Forms.TextBox tb_books;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MonthCalendar mc_rentedAM;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MonthCalendar mc_ausgeliehenBis;
        private System.Windows.Forms.Button btn_rent;
        private System.Windows.Forms.Button btn_takedata;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Label lbl_booktitle;
    }
}