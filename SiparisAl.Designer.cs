namespace PB_Cafe
{
    partial class SiparisAl
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_masaAd = new System.Windows.Forms.ComboBox();
            this.cb_kampanya = new System.Windows.Forms.ComboBox();
            this.cb_kategori = new System.Windows.Forms.ComboBox();
            this.cb_yemek = new System.Windows.Forms.ComboBox();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.btn_iptal = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nud_kampanyaAdet = new System.Windows.Forms.NumericUpDown();
            this.nud_yemekAdet = new System.Windows.Forms.NumericUpDown();
            this.lb_yemekFiyat = new System.Windows.Forms.Label();
            this.lb_yemekMaliyet = new System.Windows.Forms.Label();
            this.lb_kampanyaFiyat = new System.Windows.Forms.Label();
            this.lb_kampanyaMaliyet = new System.Windows.Forms.Label();
            this.lb_toplamFiyat = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_kampanyaAdet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_yemekAdet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Masa Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kampanyalar:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kampanya Adet:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Kategoriler:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Yemekler:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Yemek Adet:";
            // 
            // cb_masaAd
            // 
            this.cb_masaAd.FormattingEnabled = true;
            this.cb_masaAd.Location = new System.Drawing.Point(109, 18);
            this.cb_masaAd.Name = "cb_masaAd";
            this.cb_masaAd.Size = new System.Drawing.Size(121, 21);
            this.cb_masaAd.TabIndex = 6;
            // 
            // cb_kampanya
            // 
            this.cb_kampanya.FormattingEnabled = true;
            this.cb_kampanya.Location = new System.Drawing.Point(109, 45);
            this.cb_kampanya.Name = "cb_kampanya";
            this.cb_kampanya.Size = new System.Drawing.Size(121, 21);
            this.cb_kampanya.TabIndex = 7;
            // 
            // cb_kategori
            // 
            this.cb_kategori.FormattingEnabled = true;
            this.cb_kategori.Location = new System.Drawing.Point(109, 107);
            this.cb_kategori.Name = "cb_kategori";
            this.cb_kategori.Size = new System.Drawing.Size(121, 21);
            this.cb_kategori.TabIndex = 9;
            this.cb_kategori.SelectedIndexChanged += new System.EventHandler(this.cb_kategori_SelectedIndexChanged);
            // 
            // cb_yemek
            // 
            this.cb_yemek.FormattingEnabled = true;
            this.cb_yemek.Location = new System.Drawing.Point(109, 134);
            this.cb_yemek.Name = "cb_yemek";
            this.cb_yemek.Size = new System.Drawing.Size(121, 21);
            this.cb_yemek.TabIndex = 10;
            // 
            // btn_ekle
            // 
            this.btn_ekle.Location = new System.Drawing.Point(84, 205);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(75, 23);
            this.btn_ekle.TabIndex = 12;
            this.btn_ekle.Text = "Ekle";
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // btn_iptal
            // 
            this.btn_iptal.Location = new System.Drawing.Point(165, 205);
            this.btn_iptal.Name = "btn_iptal";
            this.btn_iptal.Size = new System.Drawing.Size(75, 23);
            this.btn_iptal.TabIndex = 13;
            this.btn_iptal.Text = "İptal";
            this.btn_iptal.UseVisualStyleBackColor = true;
            this.btn_iptal.Click += new System.EventHandler(this.btn_iptal_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(246, 18);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(548, 210);
            this.dataGridView1.TabIndex = 14;
            // 
            // nud_kampanyaAdet
            // 
            this.nud_kampanyaAdet.Location = new System.Drawing.Point(110, 81);
            this.nud_kampanyaAdet.Name = "nud_kampanyaAdet";
            this.nud_kampanyaAdet.Size = new System.Drawing.Size(49, 20);
            this.nud_kampanyaAdet.TabIndex = 15;
            // 
            // nud_yemekAdet
            // 
            this.nud_yemekAdet.Location = new System.Drawing.Point(110, 161);
            this.nud_yemekAdet.Name = "nud_yemekAdet";
            this.nud_yemekAdet.Size = new System.Drawing.Size(49, 20);
            this.nud_yemekAdet.TabIndex = 16;
            // 
            // lb_yemekFiyat
            // 
            this.lb_yemekFiyat.AutoSize = true;
            this.lb_yemekFiyat.Location = new System.Drawing.Point(11, 233);
            this.lb_yemekFiyat.Name = "lb_yemekFiyat";
            this.lb_yemekFiyat.Size = new System.Drawing.Size(35, 13);
            this.lb_yemekFiyat.TabIndex = 17;
            this.lb_yemekFiyat.Text = "label7";
            this.lb_yemekFiyat.Visible = false;
            // 
            // lb_yemekMaliyet
            // 
            this.lb_yemekMaliyet.AutoSize = true;
            this.lb_yemekMaliyet.Location = new System.Drawing.Point(11, 250);
            this.lb_yemekMaliyet.Name = "lb_yemekMaliyet";
            this.lb_yemekMaliyet.Size = new System.Drawing.Size(35, 13);
            this.lb_yemekMaliyet.TabIndex = 18;
            this.lb_yemekMaliyet.Text = "label8";
            this.lb_yemekMaliyet.Visible = false;
            // 
            // lb_kampanyaFiyat
            // 
            this.lb_kampanyaFiyat.AutoSize = true;
            this.lb_kampanyaFiyat.Location = new System.Drawing.Point(61, 233);
            this.lb_kampanyaFiyat.Name = "lb_kampanyaFiyat";
            this.lb_kampanyaFiyat.Size = new System.Drawing.Size(35, 13);
            this.lb_kampanyaFiyat.TabIndex = 19;
            this.lb_kampanyaFiyat.Text = "label8";
            this.lb_kampanyaFiyat.Visible = false;
            // 
            // lb_kampanyaMaliyet
            // 
            this.lb_kampanyaMaliyet.AutoSize = true;
            this.lb_kampanyaMaliyet.Location = new System.Drawing.Point(61, 250);
            this.lb_kampanyaMaliyet.Name = "lb_kampanyaMaliyet";
            this.lb_kampanyaMaliyet.Size = new System.Drawing.Size(35, 13);
            this.lb_kampanyaMaliyet.TabIndex = 20;
            this.lb_kampanyaMaliyet.Text = "label8";
            this.lb_kampanyaMaliyet.Visible = false;
            // 
            // lb_toplamFiyat
            // 
            this.lb_toplamFiyat.AutoSize = true;
            this.lb_toplamFiyat.Location = new System.Drawing.Point(103, 249);
            this.lb_toplamFiyat.Name = "lb_toplamFiyat";
            this.lb_toplamFiyat.Size = new System.Drawing.Size(35, 13);
            this.lb_toplamFiyat.TabIndex = 21;
            this.lb_toplamFiyat.Text = "label7";
            this.lb_toplamFiyat.Visible = false;
            // 
            // SiparisAl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 240);
            this.Controls.Add(this.lb_toplamFiyat);
            this.Controls.Add(this.lb_kampanyaMaliyet);
            this.Controls.Add(this.lb_kampanyaFiyat);
            this.Controls.Add(this.lb_yemekMaliyet);
            this.Controls.Add(this.lb_yemekFiyat);
            this.Controls.Add(this.nud_yemekAdet);
            this.Controls.Add(this.nud_kampanyaAdet);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_iptal);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.cb_yemek);
            this.Controls.Add(this.cb_kategori);
            this.Controls.Add(this.cb_kampanya);
            this.Controls.Add(this.cb_masaAd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SiparisAl";
            this.Text = "SiparisAl";
            this.Load += new System.EventHandler(this.SiparisAl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_kampanyaAdet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_yemekAdet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cb_masaAd;
        private System.Windows.Forms.ComboBox cb_kampanya;
        private System.Windows.Forms.ComboBox cb_kategori;
        private System.Windows.Forms.ComboBox cb_yemek;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.Button btn_iptal;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.NumericUpDown nud_kampanyaAdet;
        private System.Windows.Forms.NumericUpDown nud_yemekAdet;
        private System.Windows.Forms.Label lb_yemekFiyat;
        private System.Windows.Forms.Label lb_yemekMaliyet;
        private System.Windows.Forms.Label lb_kampanyaFiyat;
        private System.Windows.Forms.Label lb_kampanyaMaliyet;
        private System.Windows.Forms.Label lb_toplamFiyat;
    }
}