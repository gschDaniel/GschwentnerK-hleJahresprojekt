namespace Verwaltungsprogramm
{
    partial class Login
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
            this.btn_login = new System.Windows.Forms.Button();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.lbl_password = new System.Windows.Forms.Label();
            this.lbl_username = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.White;
            this.btn_login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_login.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_login.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btn_login.FlatAppearance.BorderSize = 2;
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_login.Location = new System.Drawing.Point(503, 283);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(121, 41);
            this.btn_login.TabIndex = 4;
            this.btn_login.Text = "Anmelden";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // tb_password
            // 
            this.tb_password.AcceptsTab = true;
            this.tb_password.BackColor = System.Drawing.Color.White;
            this.tb_password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_password.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_password.ForeColor = System.Drawing.Color.Black;
            this.tb_password.Location = new System.Drawing.Point(303, 230);
            this.tb_password.Name = "tb_password";
            this.tb_password.PasswordChar = '*';
            this.tb_password.Size = new System.Drawing.Size(321, 27);
            this.tb_password.TabIndex = 2;
            this.tb_password.Enter += new System.EventHandler(this.tb_password_Enter);
            this.tb_password.Leave += new System.EventHandler(this.tb_password_Leave);
            // 
            // tb_username
            // 
            this.tb_username.AcceptsTab = true;
            this.tb_username.BackColor = System.Drawing.Color.White;
            this.tb_username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_username.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_username.ForeColor = System.Drawing.Color.Black;
            this.tb_username.Location = new System.Drawing.Point(303, 179);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(321, 27);
            this.tb_username.TabIndex = 1;
            this.tb_username.Enter += new System.EventHandler(this.tb_username_Enter);
            this.tb_username.Leave += new System.EventHandler(this.tb_username_Leave);
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_password.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_password.Location = new System.Drawing.Point(163, 226);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(122, 31);
            this.lbl_password.TabIndex = 7;
            this.lbl_password.Text = "Passwort:";
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_username.Location = new System.Drawing.Point(98, 175);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(187, 31);
            this.lbl_username.TabIndex = 6;
            this.lbl_username.Text = "Benutzername:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(331, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 39);
            this.label1.TabIndex = 12;
            this.label1.Text = "Verwaltung";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(303, 283);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 41);
            this.button1.TabIndex = 3;
            this.button1.Text = "Registrieren";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.tb_username);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.lbl_username);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}