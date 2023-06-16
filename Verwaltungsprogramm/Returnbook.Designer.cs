
namespace Verwaltungsprogramm
{
    partial class Returnbook
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
            this.dgv_return = new System.Windows.Forms.DataGridView();
            this.btn_return = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_return)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_return
            // 
            this.dgv_return.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_return.Location = new System.Drawing.Point(303, 12);
            this.dgv_return.MultiSelect = false;
            this.dgv_return.Name = "dgv_return";
            this.dgv_return.Size = new System.Drawing.Size(485, 379);
            this.dgv_return.TabIndex = 0;
            // 
            // btn_return
            // 
            this.btn_return.Location = new System.Drawing.Point(681, 407);
            this.btn_return.Name = "btn_return";
            this.btn_return.Size = new System.Drawing.Size(107, 31);
            this.btn_return.TabIndex = 1;
            this.btn_return.Text = "Return";
            this.btn_return.UseVisualStyleBackColor = true;
            this.btn_return.Click += new System.EventHandler(this.btn_return_Click);
            // 
            // Returnbook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_return);
            this.Controls.Add(this.dgv_return);
            this.Name = "Returnbook";
            this.Text = "Returnbook";
            this.Load += new System.EventHandler(this.Returnbook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_return)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_return;
        private System.Windows.Forms.Button btn_return;
    }
}