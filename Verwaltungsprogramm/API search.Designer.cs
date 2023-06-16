
namespace Verwaltungsprogramm
{
    partial class API_search
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
            this.txt_buchtitel = new System.Windows.Forms.TextBox();
            this.txt_autor = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbl_english = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_addselected = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_buchtitel
            // 
            this.txt_buchtitel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_buchtitel.Location = new System.Drawing.Point(174, 77);
            this.txt_buchtitel.Name = "txt_buchtitel";
            this.txt_buchtitel.Size = new System.Drawing.Size(170, 29);
            this.txt_buchtitel.TabIndex = 0;
            this.txt_buchtitel.TextChanged += new System.EventHandler(this.txt_buchtitel_TextChanged);
            // 
            // txt_autor
            // 
            this.txt_autor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_autor.Location = new System.Drawing.Point(350, 77);
            this.txt_autor.Name = "txt_autor";
            this.txt_autor.Size = new System.Drawing.Size(153, 29);
            this.txt_autor.TabIndex = 1;
            // 
            // btn_search
            // 
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Location = new System.Drawing.Point(22, 70);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(146, 45);
            this.btn_search.TabIndex = 2;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 156);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(481, 253);
            this.dataGridView1.TabIndex = 3;
            // 
            // lbl_english
            // 
            this.lbl_english.AutoSize = true;
            this.lbl_english.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_english.Location = new System.Drawing.Point(18, 32);
            this.lbl_english.Name = "lbl_english";
            this.lbl_english.Size = new System.Drawing.Size(326, 24);
            this.lbl_english.TabIndex = 4;
            this.lbl_english.Text = "Schreibe deine Suche bitte in English";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(214, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Buchtitel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(402, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Autor";
            // 
            // btn_addselected
            // 
            this.btn_addselected.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addselected.Location = new System.Drawing.Point(185, 415);
            this.btn_addselected.Name = "btn_addselected";
            this.btn_addselected.Size = new System.Drawing.Size(146, 45);
            this.btn_addselected.TabIndex = 7;
            this.btn_addselected.Text = "Bestätigen";
            this.btn_addselected.UseVisualStyleBackColor = true;
            this.btn_addselected.Click += new System.EventHandler(this.btn_addselected_Click);
            // 
            // API_search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 471);
            this.Controls.Add(this.btn_addselected);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_english);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.txt_autor);
            this.Controls.Add(this.txt_buchtitel);
            this.Name = "API_search";
            this.Text = "API_search";
            this.Load += new System.EventHandler(this.API_search_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_buchtitel;
        private System.Windows.Forms.TextBox txt_autor;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbl_english;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_addselected;
    }
}