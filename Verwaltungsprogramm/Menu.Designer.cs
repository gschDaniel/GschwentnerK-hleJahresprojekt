namespace Verwaltungsprogramm
{
    partial class Menu
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel5 = new System.Windows.Forms.Panel();
            this.btn_addBook = new System.Windows.Forms.Button();
            this.lbl_4Main = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_barcode = new System.Windows.Forms.Button();
            this.btn_return = new System.Windows.Forms.Button();
            this.btn_makeOwnBook = new System.Windows.Forms.Button();
            this.lbl_managebooks = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_showBooks = new System.Windows.Forms.Button();
            this.lbl_5Main = new System.Windows.Forms.Label();
            this.p1main = new System.Windows.Forms.Panel();
            this.btn_lightmode = new System.Windows.Forms.Button();
            this.btn_darkmode = new System.Windows.Forms.Button();
            this.btn_changeName = new System.Windows.Forms.Button();
            this.btn_editpb = new System.Windows.Forms.Button();
            this.btn_logout = new System.Windows.Forms.Button();
            this.lbl_1Main = new System.Windows.Forms.Label();
            this.txt_searchMain = new System.Windows.Forms.TextBox();
            this.pb_main = new System.Windows.Forms.PictureBox();
            this.lbl_2Main = new System.Windows.Forms.Label();
            this.lbl_3Main = new System.Windows.Forms.Label();
            this.p2main = new System.Windows.Forms.Panel();
            this.btn_changeName1 = new System.Windows.Forms.Button();
            this.tb_changeName = new System.Windows.Forms.TextBox();
            this.label_1Main = new System.Windows.Forms.Label();
            this.txt_changepb = new System.Windows.Forms.TextBox();
            this.btn_deletebook = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_googleAPI = new System.Windows.Forms.Button();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.p1main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_main)).BeginInit();
            this.p2main.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(72)))), ((int)(((byte)(194)))));
            this.panel5.Controls.Add(this.btn_googleAPI);
            this.panel5.Controls.Add(this.btn_deletebook);
            this.panel5.Controls.Add(this.btn_addBook);
            this.panel5.Controls.Add(this.lbl_4Main);
            this.panel5.Location = new System.Drawing.Point(734, 363);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(433, 235);
            this.panel5.TabIndex = 12;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // btn_addBook
            // 
            this.btn_addBook.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addBook.ForeColor = System.Drawing.Color.Black;
            this.btn_addBook.Location = new System.Drawing.Point(47, 57);
            this.btn_addBook.Name = "btn_addBook";
            this.btn_addBook.Size = new System.Drawing.Size(174, 43);
            this.btn_addBook.TabIndex = 1;
            this.btn_addBook.Text = "Buch hinzufügen";
            this.btn_addBook.UseVisualStyleBackColor = true;
            this.btn_addBook.Click += new System.EventHandler(this.btn_addBook_Click);
            // 
            // lbl_4Main
            // 
            this.lbl_4Main.AutoSize = true;
            this.lbl_4Main.BackColor = System.Drawing.Color.Transparent;
            this.lbl_4Main.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_4Main.ForeColor = System.Drawing.Color.White;
            this.lbl_4Main.Location = new System.Drawing.Point(43, 25);
            this.lbl_4Main.Name = "lbl_4Main";
            this.lbl_4Main.Size = new System.Drawing.Size(146, 24);
            this.lbl_4Main.TabIndex = 0;
            this.lbl_4Main.Text = "Buch einfügen";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(79)))), ((int)(((byte)(117)))));
            this.panel4.Controls.Add(this.btn_barcode);
            this.panel4.Controls.Add(this.btn_return);
            this.panel4.Controls.Add(this.btn_makeOwnBook);
            this.panel4.Controls.Add(this.lbl_managebooks);
            this.panel4.Location = new System.Drawing.Point(734, 106);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(433, 251);
            this.panel4.TabIndex = 13;
            // 
            // btn_barcode
            // 
            this.btn_barcode.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_barcode.ForeColor = System.Drawing.Color.Black;
            this.btn_barcode.Location = new System.Drawing.Point(24, 199);
            this.btn_barcode.Name = "btn_barcode";
            this.btn_barcode.Size = new System.Drawing.Size(241, 34);
            this.btn_barcode.TabIndex = 4;
            this.btn_barcode.Text = "Mit Barcode scannen";
            this.btn_barcode.UseVisualStyleBackColor = true;
            this.btn_barcode.Click += new System.EventHandler(this.btn_barcode_Click);
            // 
            // btn_return
            // 
            this.btn_return.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_return.Location = new System.Drawing.Point(24, 135);
            this.btn_return.Name = "btn_return";
            this.btn_return.Size = new System.Drawing.Size(183, 38);
            this.btn_return.TabIndex = 3;
            this.btn_return.Text = "zurückgeben";
            this.btn_return.UseVisualStyleBackColor = true;
            this.btn_return.Click += new System.EventHandler(this.btn_return_Click);
            // 
            // btn_makeOwnBook
            // 
            this.btn_makeOwnBook.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_makeOwnBook.ForeColor = System.Drawing.Color.Black;
            this.btn_makeOwnBook.Location = new System.Drawing.Point(24, 78);
            this.btn_makeOwnBook.Name = "btn_makeOwnBook";
            this.btn_makeOwnBook.Size = new System.Drawing.Size(183, 34);
            this.btn_makeOwnBook.TabIndex = 2;
            this.btn_makeOwnBook.Text = "Buch verleihen";
            this.btn_makeOwnBook.UseVisualStyleBackColor = true;
            this.btn_makeOwnBook.Click += new System.EventHandler(this.btn_makeOwnBook_Click);
            // 
            // lbl_managebooks
            // 
            this.lbl_managebooks.AutoSize = true;
            this.lbl_managebooks.BackColor = System.Drawing.Color.Transparent;
            this.lbl_managebooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_managebooks.ForeColor = System.Drawing.Color.White;
            this.lbl_managebooks.Location = new System.Drawing.Point(20, 38);
            this.lbl_managebooks.Name = "lbl_managebooks";
            this.lbl_managebooks.Size = new System.Drawing.Size(172, 24);
            this.lbl_managebooks.TabIndex = 2;
            this.lbl_managebooks.Text = "Bücher verwalten";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(72)))), ((int)(((byte)(194)))));
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Controls.Add(this.btn_showBooks);
            this.panel3.Controls.Add(this.lbl_5Main);
            this.panel3.Location = new System.Drawing.Point(237, 106);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(491, 492);
            this.panel3.TabIndex = 11;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(20, 78);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(457, 384);
            this.dataGridView1.TabIndex = 4;
            // 
            // btn_showBooks
            // 
            this.btn_showBooks.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_showBooks.ForeColor = System.Drawing.Color.Black;
            this.btn_showBooks.Location = new System.Drawing.Point(264, 20);
            this.btn_showBooks.Name = "btn_showBooks";
            this.btn_showBooks.Size = new System.Drawing.Size(213, 42);
            this.btn_showBooks.TabIndex = 3;
            this.btn_showBooks.Text = "Bücher anzeigen";
            this.btn_showBooks.UseVisualStyleBackColor = true;
            this.btn_showBooks.Click += new System.EventHandler(this.btn_showBooks_Click);
            // 
            // lbl_5Main
            // 
            this.lbl_5Main.AutoSize = true;
            this.lbl_5Main.BackColor = System.Drawing.Color.Transparent;
            this.lbl_5Main.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_5Main.ForeColor = System.Drawing.Color.White;
            this.lbl_5Main.Location = new System.Drawing.Point(16, 25);
            this.lbl_5Main.Name = "lbl_5Main";
            this.lbl_5Main.Size = new System.Drawing.Size(211, 24);
            this.lbl_5Main.TabIndex = 1;
            this.lbl_5Main.Text = "Alle Bücher anzeigen";
            // 
            // p1main
            // 
            this.p1main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(171)))), ((int)(((byte)(247)))));
            this.p1main.Controls.Add(this.btn_lightmode);
            this.p1main.Controls.Add(this.btn_darkmode);
            this.p1main.Controls.Add(this.btn_changeName);
            this.p1main.Controls.Add(this.btn_editpb);
            this.p1main.Controls.Add(this.btn_logout);
            this.p1main.Dock = System.Windows.Forms.DockStyle.Left;
            this.p1main.Location = new System.Drawing.Point(0, 0);
            this.p1main.Name = "p1main";
            this.p1main.Size = new System.Drawing.Size(231, 607);
            this.p1main.TabIndex = 9;
            this.p1main.Paint += new System.Windows.Forms.PaintEventHandler(this.p1main_Paint);
            // 
            // btn_lightmode
            // 
            this.btn_lightmode.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_lightmode.ForeColor = System.Drawing.Color.Black;
            this.btn_lightmode.Location = new System.Drawing.Point(0, 401);
            this.btn_lightmode.Name = "btn_lightmode";
            this.btn_lightmode.Size = new System.Drawing.Size(125, 81);
            this.btn_lightmode.TabIndex = 6;
            this.btn_lightmode.Text = "Light Mode";
            this.btn_lightmode.UseVisualStyleBackColor = true;
            this.btn_lightmode.Visible = false;
            this.btn_lightmode.Click += new System.EventHandler(this.btn_lightmode_Click);
            // 
            // btn_darkmode
            // 
            this.btn_darkmode.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_darkmode.ForeColor = System.Drawing.Color.Black;
            this.btn_darkmode.Location = new System.Drawing.Point(0, 401);
            this.btn_darkmode.Name = "btn_darkmode";
            this.btn_darkmode.Size = new System.Drawing.Size(125, 81);
            this.btn_darkmode.TabIndex = 5;
            this.btn_darkmode.Text = "Dark Mode";
            this.btn_darkmode.UseVisualStyleBackColor = true;
            this.btn_darkmode.Click += new System.EventHandler(this.btn_darkmode_Click);
            // 
            // btn_changeName
            // 
            this.btn_changeName.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_changeName.ForeColor = System.Drawing.Color.Black;
            this.btn_changeName.Location = new System.Drawing.Point(0, 258);
            this.btn_changeName.Name = "btn_changeName";
            this.btn_changeName.Size = new System.Drawing.Size(125, 81);
            this.btn_changeName.TabIndex = 3;
            this.btn_changeName.Text = "Namen ändern";
            this.btn_changeName.UseVisualStyleBackColor = true;
            this.btn_changeName.Click += new System.EventHandler(this.btn_changeName_Click);
            // 
            // btn_editpb
            // 
            this.btn_editpb.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editpb.ForeColor = System.Drawing.Color.Black;
            this.btn_editpb.Location = new System.Drawing.Point(0, 120);
            this.btn_editpb.Name = "btn_editpb";
            this.btn_editpb.Size = new System.Drawing.Size(125, 81);
            this.btn_editpb.TabIndex = 2;
            this.btn_editpb.Text = "Profilbild ändern";
            this.btn_editpb.UseVisualStyleBackColor = true;
            this.btn_editpb.Click += new System.EventHandler(this.btn_editpb_Click);
            // 
            // btn_logout
            // 
            this.btn_logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logout.ForeColor = System.Drawing.Color.Black;
            this.btn_logout.Location = new System.Drawing.Point(0, 577);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(104, 30);
            this.btn_logout.TabIndex = 0;
            this.btn_logout.Text = "Logout";
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // lbl_1Main
            // 
            this.lbl_1Main.AutoSize = true;
            this.lbl_1Main.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_1Main.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbl_1Main.Location = new System.Drawing.Point(64, 20);
            this.lbl_1Main.Name = "lbl_1Main";
            this.lbl_1Main.Size = new System.Drawing.Size(260, 55);
            this.lbl_1Main.TabIndex = 0;
            this.lbl_1Main.Text = "Verwaltung";
            // 
            // txt_searchMain
            // 
            this.txt_searchMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_searchMain.Location = new System.Drawing.Point(640, 52);
            this.txt_searchMain.Name = "txt_searchMain";
            this.txt_searchMain.Size = new System.Drawing.Size(450, 35);
            this.txt_searchMain.TabIndex = 1;
            this.txt_searchMain.TextChanged += new System.EventHandler(this.txt_searchMain_TextChanged);
            // 
            // pb_main
            // 
            this.pb_main.BackColor = System.Drawing.Color.Black;
            this.pb_main.Location = new System.Drawing.Point(1190, 12);
            this.pb_main.Name = "pb_main";
            this.pb_main.Size = new System.Drawing.Size(70, 73);
            this.pb_main.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_main.TabIndex = 2;
            this.pb_main.TabStop = false;
            // 
            // lbl_2Main
            // 
            this.lbl_2Main.AutoSize = true;
            this.lbl_2Main.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_2Main.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(91)))), ((int)(((byte)(245)))));
            this.lbl_2Main.Location = new System.Drawing.Point(1288, 20);
            this.lbl_2Main.Name = "lbl_2Main";
            this.lbl_2Main.Size = new System.Drawing.Size(247, 29);
            this.lbl_2Main.TabIndex = 3;
            this.lbl_2Main.Text = "Daniel Gschwentner";
            // 
            // lbl_3Main
            // 
            this.lbl_3Main.AutoSize = true;
            this.lbl_3Main.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_3Main.ForeColor = System.Drawing.Color.Black;
            this.lbl_3Main.Location = new System.Drawing.Point(1345, 50);
            this.lbl_3Main.Name = "lbl_3Main";
            this.lbl_3Main.Size = new System.Drawing.Size(138, 25);
            this.lbl_3Main.TabIndex = 4;
            this.lbl_3Main.Text = "Administrator";
            // 
            // p2main
            // 
            this.p2main.BackColor = System.Drawing.Color.LightGray;
            this.p2main.Controls.Add(this.label1);
            this.p2main.Controls.Add(this.btn_changeName1);
            this.p2main.Controls.Add(this.tb_changeName);
            this.p2main.Controls.Add(this.label_1Main);
            this.p2main.Controls.Add(this.lbl_3Main);
            this.p2main.Controls.Add(this.lbl_2Main);
            this.p2main.Controls.Add(this.pb_main);
            this.p2main.Controls.Add(this.txt_searchMain);
            this.p2main.Controls.Add(this.lbl_1Main);
            this.p2main.Location = new System.Drawing.Point(-362, 0);
            this.p2main.Name = "p2main";
            this.p2main.Size = new System.Drawing.Size(1659, 100);
            this.p2main.TabIndex = 10;
            // 
            // btn_changeName1
            // 
            this.btn_changeName1.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_changeName1.Location = new System.Drawing.Point(1454, 20);
            this.btn_changeName1.Name = "btn_changeName1";
            this.btn_changeName1.Size = new System.Drawing.Size(75, 23);
            this.btn_changeName1.TabIndex = 15;
            this.btn_changeName1.Text = "Ändern";
            this.btn_changeName1.UseVisualStyleBackColor = true;
            this.btn_changeName1.Visible = false;
            this.btn_changeName1.Click += new System.EventHandler(this.btn_changeName1_Click);
            // 
            // tb_changeName
            // 
            this.tb_changeName.Location = new System.Drawing.Point(1269, 20);
            this.tb_changeName.Name = "tb_changeName";
            this.tb_changeName.Size = new System.Drawing.Size(179, 20);
            this.tb_changeName.TabIndex = 14;
            this.tb_changeName.Visible = false;
            // 
            // label_1Main
            // 
            this.label_1Main.AutoSize = true;
            this.label_1Main.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_1Main.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(91)))), ((int)(((byte)(245)))));
            this.label_1Main.Location = new System.Drawing.Point(415, 9);
            this.label_1Main.Name = "label_1Main";
            this.label_1Main.Size = new System.Drawing.Size(202, 42);
            this.label_1Main.TabIndex = 5;
            this.label_1Main.Text = "Verwaltung";
            this.label_1Main.Click += new System.EventHandler(this.label_1Main_Click);
            // 
            // txt_changepb
            // 
            this.txt_changepb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_changepb.Location = new System.Drawing.Point(845, 106);
            this.txt_changepb.Name = "txt_changepb";
            this.txt_changepb.Size = new System.Drawing.Size(182, 26);
            this.txt_changepb.TabIndex = 14;
            this.txt_changepb.Visible = false;
            // 
            // btn_deletebook
            // 
            this.btn_deletebook.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deletebook.ForeColor = System.Drawing.Color.Black;
            this.btn_deletebook.Location = new System.Drawing.Point(47, 106);
            this.btn_deletebook.Name = "btn_deletebook";
            this.btn_deletebook.Size = new System.Drawing.Size(174, 43);
            this.btn_deletebook.TabIndex = 2;
            this.btn_deletebook.Text = "Buch löschen";
            this.btn_deletebook.UseVisualStyleBackColor = true;
            this.btn_deletebook.Click += new System.EventHandler(this.btn_deletebook_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(91)))), ((int)(((byte)(245)))));
            this.label1.Location = new System.Drawing.Point(433, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 36);
            this.label1.TabIndex = 16;
            this.label1.Text = "Suche hier";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_googleAPI
            // 
            this.btn_googleAPI.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_googleAPI.Location = new System.Drawing.Point(227, 57);
            this.btn_googleAPI.Name = "btn_googleAPI";
            this.btn_googleAPI.Size = new System.Drawing.Size(182, 52);
            this.btn_googleAPI.TabIndex = 8;
            this.btn_googleAPI.Text = "Aus Google API hinzufügen";
            this.btn_googleAPI.UseVisualStyleBackColor = true;
            this.btn_googleAPI.Click += new System.EventHandler(this.btn_googleAPI_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1199, 607);
            this.Controls.Add(this.txt_changepb);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.p2main);
            this.Controls.Add(this.p1main);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.p1main.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_main)).EndInit();
            this.p2main.ResumeLayout(false);
            this.p2main.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btn_addBook;
        private System.Windows.Forms.Label lbl_4Main;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btn_makeOwnBook;
        private System.Windows.Forms.Label lbl_managebooks;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_showBooks;
        private System.Windows.Forms.Label lbl_5Main;
        private System.Windows.Forms.Panel p1main;
        private System.Windows.Forms.Button btn_changeName;
        private System.Windows.Forms.Button btn_editpb;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Label lbl_1Main;
        private System.Windows.Forms.TextBox txt_searchMain;
        private System.Windows.Forms.PictureBox pb_main;
        private System.Windows.Forms.Label lbl_2Main;
        private System.Windows.Forms.Label lbl_3Main;
        private System.Windows.Forms.Panel p2main;
        private System.Windows.Forms.Label label_1Main;
        private System.Windows.Forms.Button btn_changeName1;
        private System.Windows.Forms.TextBox tb_changeName;
        private System.Windows.Forms.Button btn_darkmode;
        private System.Windows.Forms.Button btn_lightmode;
        private System.Windows.Forms.TextBox txt_changepb;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_return;
        private System.Windows.Forms.Button btn_barcode;
        private System.Windows.Forms.Button btn_deletebook;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_googleAPI;
    }
}

