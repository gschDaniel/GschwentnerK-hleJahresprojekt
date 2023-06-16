
namespace Verwaltungsprogramm
{
    partial class Registration
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_login = new System.Windows.Forms.Button();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.lbl_password = new System.Windows.Forms.Label();
            this.lbl_username = new System.Windows.Forms.Label();
            this.tb_confirmpw = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_prename = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_lastname = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(496, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 39);
            this.label1.TabIndex = 19;
            this.label1.Text = "Verwaltung";
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
            this.btn_login.Location = new System.Drawing.Point(474, 348);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(121, 41);
            this.btn_login.TabIndex = 6;
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
            this.tb_password.Location = new System.Drawing.Point(274, 236);
            this.tb_password.Name = "tb_password";
            this.tb_password.PasswordChar = '*';
            this.tb_password.Size = new System.Drawing.Size(321, 27);
            this.tb_password.TabIndex = 4;
            // 
            // tb_username
            // 
            this.tb_username.AcceptsTab = true;
            this.tb_username.BackColor = System.Drawing.Color.White;
            this.tb_username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_username.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_username.ForeColor = System.Drawing.Color.Black;
            this.tb_username.Location = new System.Drawing.Point(274, 185);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(321, 27);
            this.tb_username.TabIndex = 3;
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_password.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_password.Location = new System.Drawing.Point(134, 232);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(122, 31);
            this.lbl_password.TabIndex = 15;
            this.lbl_password.Text = "Passwort:";
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_username.Location = new System.Drawing.Point(69, 181);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(187, 31);
            this.lbl_username.TabIndex = 14;
            this.lbl_username.Text = "Benutzername:";
            // 
            // tb_confirmpw
            // 
            this.tb_confirmpw.AcceptsTab = true;
            this.tb_confirmpw.BackColor = System.Drawing.Color.White;
            this.tb_confirmpw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_confirmpw.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_confirmpw.ForeColor = System.Drawing.Color.Black;
            this.tb_confirmpw.Location = new System.Drawing.Point(274, 288);
            this.tb_confirmpw.Name = "tb_confirmpw";
            this.tb_confirmpw.PasswordChar = '*';
            this.tb_confirmpw.Size = new System.Drawing.Size(321, 27);
            this.tb_confirmpw.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(6, 284);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 31);
            this.label2.TabIndex = 20;
            this.label2.Text = "Passwort bestätigen:";
            // 
            // tb_prename
            // 
            this.tb_prename.AcceptsTab = true;
            this.tb_prename.BackColor = System.Drawing.Color.White;
            this.tb_prename.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_prename.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_prename.ForeColor = System.Drawing.Color.Black;
            this.tb_prename.Location = new System.Drawing.Point(75, 93);
            this.tb_prename.Name = "tb_prename";
            this.tb_prename.Size = new System.Drawing.Size(165, 27);
            this.tb_prename.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(69, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 31);
            this.label3.TabIndex = 22;
            this.label3.Text = "Vorname:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(268, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 31);
            this.label4.TabIndex = 24;
            this.label4.Text = "Nachname:";
            // 
            // tb_lastname
            // 
            this.tb_lastname.AcceptsTab = true;
            this.tb_lastname.BackColor = System.Drawing.Color.White;
            this.tb_lastname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_lastname.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_lastname.ForeColor = System.Drawing.Color.Black;
            this.tb_lastname.Location = new System.Drawing.Point(274, 93);
            this.tb_lastname.Name = "tb_lastname";
            this.tb_lastname.Size = new System.Drawing.Size(321, 27);
            this.tb_lastname.TabIndex = 2;
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 421);
            this.Controls.Add(this.tb_lastname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_prename);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_confirmpw);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.tb_username);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.lbl_username);
            this.Name = "Registration";
            this.Text = "Registration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.TextBox tb_confirmpw;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_prename;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_lastname;
    }
}