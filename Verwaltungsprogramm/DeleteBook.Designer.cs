
namespace Verwaltungsprogramm
{
    partial class DeleteBook
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
            this.dgv_deletebook = new System.Windows.Forms.DataGridView();
            this.btn_delete = new System.Windows.Forms.Button();
            this.lbl_5Main = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_deletebook)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_deletebook
            // 
            this.dgv_deletebook.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_deletebook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_deletebook.Location = new System.Drawing.Point(62, 86);
            this.dgv_deletebook.Name = "dgv_deletebook";
            this.dgv_deletebook.Size = new System.Drawing.Size(479, 268);
            this.dgv_deletebook.TabIndex = 0;
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(235, 375);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(154, 46);
            this.btn_delete.TabIndex = 1;
            this.btn_delete.Text = "löschen";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // lbl_5Main
            // 
            this.lbl_5Main.AutoSize = true;
            this.lbl_5Main.BackColor = System.Drawing.Color.Transparent;
            this.lbl_5Main.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_5Main.ForeColor = System.Drawing.Color.Black;
            this.lbl_5Main.Location = new System.Drawing.Point(58, 32);
            this.lbl_5Main.Name = "lbl_5Main";
            this.lbl_5Main.Size = new System.Drawing.Size(251, 37);
            this.lbl_5Main.TabIndex = 2;
            this.lbl_5Main.Text = "Bücher löschen";
            // 
            // DeleteBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 442);
            this.Controls.Add(this.lbl_5Main);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.dgv_deletebook);
            this.Name = "DeleteBook";
            this.Text = "DeleteBook";
            this.Load += new System.EventHandler(this.DeleteBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_deletebook)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_deletebook;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Label lbl_5Main;
    }
}