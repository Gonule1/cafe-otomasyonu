namespace PB_Cafe
{
    partial class Adisyon
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
            this.cb_masaAd = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_adisyon = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Masa Adı:";
            // 
            // cb_masaAd
            // 
            this.cb_masaAd.FormattingEnabled = true;
            this.cb_masaAd.Location = new System.Drawing.Point(78, 10);
            this.cb_masaAd.Name = "cb_masaAd";
            this.cb_masaAd.Size = new System.Drawing.Size(121, 21);
            this.cb_masaAd.TabIndex = 1;
            this.cb_masaAd.SelectedIndexChanged += new System.EventHandler(this.cb_masaAd_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(784, 152);
            this.dataGridView1.TabIndex = 2;
            // 
            // btn_adisyon
            // 
            this.btn_adisyon.Location = new System.Drawing.Point(379, 197);
            this.btn_adisyon.Name = "btn_adisyon";
            this.btn_adisyon.Size = new System.Drawing.Size(75, 41);
            this.btn_adisyon.TabIndex = 3;
            this.btn_adisyon.Text = "Adisyon";
            this.btn_adisyon.UseVisualStyleBackColor = true;
            this.btn_adisyon.Click += new System.EventHandler(this.btn_adisyon_Click);
            // 
            // Adisyon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 240);
            this.Controls.Add(this.btn_adisyon);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cb_masaAd);
            this.Controls.Add(this.label1);
            this.Name = "Adisyon";
            this.Text = "Adisyon";
            this.Load += new System.EventHandler(this.Adisyon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_masaAd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_adisyon;
    }
}