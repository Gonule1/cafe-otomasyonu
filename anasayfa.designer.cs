namespace PB_Cafe
{
    partial class Home
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelTop = new System.Windows.Forms.Panel();
            this.btn_FormClose = new System.Windows.Forms.Button();
            this.labelMenu = new System.Windows.Forms.Label();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.btn_Personel = new System.Windows.Forms.Button();
            this.btn_Ayarlar = new System.Windows.Forms.Button();
            this.btn_Menu = new System.Windows.Forms.Button();
            this.btn_Raporlar = new System.Windows.Forms.Button();
            this.btn_KasaIslemleri = new System.Windows.Forms.Button();
            this.btn_Mutfak = new System.Windows.Forms.Button();
            this.btn_Kampanyalar = new System.Windows.Forms.Button();
            this.btn_Masalar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Controls.Add(this.btn_Personel);
            this.panelMenu.Controls.Add(this.btn_Ayarlar);
            this.panelMenu.Controls.Add(this.btn_Menu);
            this.panelMenu.Controls.Add(this.btn_Raporlar);
            this.panelMenu.Controls.Add(this.btn_KasaIslemleri);
            this.panelMenu.Controls.Add(this.btn_Mutfak);
            this.panelMenu.Controls.Add(this.btn_Kampanyalar);
            this.panelMenu.Controls.Add(this.btn_Masalar);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(186, 559);
            this.panelMenu.TabIndex = 9;
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.LightBlue;
            this.panelLogo.Controls.Add(this.labelTitle);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(186, 62);
            this.panelLogo.TabIndex = 0;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.SkyBlue;
            this.panelTop.Controls.Add(this.btn_FormClose);
            this.panelTop.Controls.Add(this.labelMenu);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(186, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(859, 62);
            this.panelTop.TabIndex = 10;
            // 
            // btn_FormClose
            // 
            this.btn_FormClose.FlatAppearance.BorderSize = 0;
            this.btn_FormClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_FormClose.Font = new System.Drawing.Font("Trajan Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_FormClose.Location = new System.Drawing.Point(23, 20);
            this.btn_FormClose.Name = "btn_FormClose";
            this.btn_FormClose.Size = new System.Drawing.Size(25, 25);
            this.btn_FormClose.TabIndex = 1;
            this.btn_FormClose.Text = "X";
            this.btn_FormClose.UseVisualStyleBackColor = true;
            this.btn_FormClose.Click += new System.EventHandler(this.btn_FormClose_Click);
            // 
            // labelMenu
            // 
            this.labelMenu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelMenu.AutoSize = true;
            this.labelMenu.Font = new System.Drawing.Font("Trajan Pro", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMenu.Location = new System.Drawing.Point(329, 14);
            this.labelMenu.Name = "labelMenu";
            this.labelMenu.Size = new System.Drawing.Size(174, 34);
            this.labelMenu.TabIndex = 0;
            this.labelMenu.Text = "ANA SAYFA";
            // 
            // panelDesktop
            // 
            this.panelDesktop.Controls.Add(this.label1);
            this.panelDesktop.Controls.Add(this.pictureBox1);
            this.panelDesktop.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(186, 62);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(859, 497);
            this.panelDesktop.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::PB_Cafe.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(300, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(266, 271);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Trajan Pro", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labelTitle.Image = global::PB_Cafe.Properties.Resources.slack;
            this.labelTitle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelTitle.Location = new System.Drawing.Point(3, 14);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(179, 30);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "         PB Cafe";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_Personel
            // 
            this.btn_Personel.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btn_Personel.FlatAppearance.BorderSize = 0;
            this.btn_Personel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Personel.Font = new System.Drawing.Font("Trajan Pro", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Personel.ForeColor = System.Drawing.Color.Black;
            this.btn_Personel.Image = global::PB_Cafe.Properties.Resources.user;
            this.btn_Personel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Personel.Location = new System.Drawing.Point(0, 68);
            this.btn_Personel.Name = "btn_Personel";
            this.btn_Personel.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btn_Personel.Size = new System.Drawing.Size(183, 52);
            this.btn_Personel.TabIndex = 1;
            this.btn_Personel.Text = "  Personel";
            this.btn_Personel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Personel.UseVisualStyleBackColor = false;
            this.btn_Personel.Click += new System.EventHandler(this.btn_Personel_Click);
            // 
            // btn_Ayarlar
            // 
            this.btn_Ayarlar.FlatAppearance.BorderSize = 0;
            this.btn_Ayarlar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Ayarlar.Font = new System.Drawing.Font("Trajan Pro", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Ayarlar.ForeColor = System.Drawing.Color.Black;
            this.btn_Ayarlar.Image = global::PB_Cafe.Properties.Resources.settings;
            this.btn_Ayarlar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Ayarlar.Location = new System.Drawing.Point(0, 474);
            this.btn_Ayarlar.Name = "btn_Ayarlar";
            this.btn_Ayarlar.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btn_Ayarlar.Size = new System.Drawing.Size(183, 52);
            this.btn_Ayarlar.TabIndex = 6;
            this.btn_Ayarlar.Text = "  Ayarlar";
            this.btn_Ayarlar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Ayarlar.UseVisualStyleBackColor = true;
            // 
            // btn_Menu
            // 
            this.btn_Menu.FlatAppearance.BorderSize = 0;
            this.btn_Menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Menu.Font = new System.Drawing.Font("Trajan Pro", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Menu.ForeColor = System.Drawing.Color.Black;
            this.btn_Menu.Image = global::PB_Cafe.Properties.Resources.menu;
            this.btn_Menu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Menu.Location = new System.Drawing.Point(0, 184);
            this.btn_Menu.Name = "btn_Menu";
            this.btn_Menu.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btn_Menu.Size = new System.Drawing.Size(183, 52);
            this.btn_Menu.TabIndex = 7;
            this.btn_Menu.Text = "  Menü";
            this.btn_Menu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Menu.UseVisualStyleBackColor = true;
            this.btn_Menu.Click += new System.EventHandler(this.btn_Menu_Click);
            // 
            // btn_Raporlar
            // 
            this.btn_Raporlar.FlatAppearance.BorderSize = 0;
            this.btn_Raporlar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Raporlar.Font = new System.Drawing.Font("Trajan Pro", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Raporlar.ForeColor = System.Drawing.Color.Black;
            this.btn_Raporlar.Image = global::PB_Cafe.Properties.Resources.paper;
            this.btn_Raporlar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Raporlar.Location = new System.Drawing.Point(0, 416);
            this.btn_Raporlar.Name = "btn_Raporlar";
            this.btn_Raporlar.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btn_Raporlar.Size = new System.Drawing.Size(183, 52);
            this.btn_Raporlar.TabIndex = 5;
            this.btn_Raporlar.Text = "  Raporlar";
            this.btn_Raporlar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Raporlar.UseVisualStyleBackColor = true;
            this.btn_Raporlar.Click += new System.EventHandler(this.btn_Raporlar_Click);
            // 
            // btn_KasaIslemleri
            // 
            this.btn_KasaIslemleri.FlatAppearance.BorderSize = 0;
            this.btn_KasaIslemleri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_KasaIslemleri.Font = new System.Drawing.Font("Trajan Pro", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_KasaIslemleri.ForeColor = System.Drawing.Color.Black;
            this.btn_KasaIslemleri.Image = global::PB_Cafe.Properties.Resources.kasa;
            this.btn_KasaIslemleri.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_KasaIslemleri.Location = new System.Drawing.Point(0, 126);
            this.btn_KasaIslemleri.Name = "btn_KasaIslemleri";
            this.btn_KasaIslemleri.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btn_KasaIslemleri.Size = new System.Drawing.Size(183, 52);
            this.btn_KasaIslemleri.TabIndex = 2;
            this.btn_KasaIslemleri.Text = "  Kasa İşlemleri";
            this.btn_KasaIslemleri.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_KasaIslemleri.UseVisualStyleBackColor = true;
            this.btn_KasaIslemleri.Click += new System.EventHandler(this.btn_KasaIslemleri_Click);
            // 
            // btn_Mutfak
            // 
            this.btn_Mutfak.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btn_Mutfak.FlatAppearance.BorderSize = 0;
            this.btn_Mutfak.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Mutfak.Font = new System.Drawing.Font("Trajan Pro", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Mutfak.ForeColor = System.Drawing.Color.Black;
            this.btn_Mutfak.Image = global::PB_Cafe.Properties.Resources.food;
            this.btn_Mutfak.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Mutfak.Location = new System.Drawing.Point(0, 358);
            this.btn_Mutfak.Name = "btn_Mutfak";
            this.btn_Mutfak.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btn_Mutfak.Size = new System.Drawing.Size(183, 52);
            this.btn_Mutfak.TabIndex = 4;
            this.btn_Mutfak.Text = "  Mutfak";
            this.btn_Mutfak.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Mutfak.UseVisualStyleBackColor = false;
            this.btn_Mutfak.Click += new System.EventHandler(this.btn_Mutfak_Click);
            // 
            // btn_Kampanyalar
            // 
            this.btn_Kampanyalar.FlatAppearance.BorderSize = 0;
            this.btn_Kampanyalar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Kampanyalar.Font = new System.Drawing.Font("Trajan Pro", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Kampanyalar.ForeColor = System.Drawing.Color.Black;
            this.btn_Kampanyalar.Image = global::PB_Cafe.Properties.Resources.ads;
            this.btn_Kampanyalar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Kampanyalar.Location = new System.Drawing.Point(0, 242);
            this.btn_Kampanyalar.Name = "btn_Kampanyalar";
            this.btn_Kampanyalar.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btn_Kampanyalar.Size = new System.Drawing.Size(183, 52);
            this.btn_Kampanyalar.TabIndex = 3;
            this.btn_Kampanyalar.Text = "  Kampanyalar";
            this.btn_Kampanyalar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Kampanyalar.UseVisualStyleBackColor = true;
            this.btn_Kampanyalar.Click += new System.EventHandler(this.btn_Kampanyalar_Click);
            // 
            // btn_Masalar
            // 
            this.btn_Masalar.FlatAppearance.BorderSize = 0;
            this.btn_Masalar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Masalar.Font = new System.Drawing.Font("Trajan Pro", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Masalar.ForeColor = System.Drawing.Color.Black;
            this.btn_Masalar.Image = global::PB_Cafe.Properties.Resources.desk;
            this.btn_Masalar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Masalar.Location = new System.Drawing.Point(0, 300);
            this.btn_Masalar.Name = "btn_Masalar";
            this.btn_Masalar.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btn_Masalar.Size = new System.Drawing.Size(183, 52);
            this.btn_Masalar.TabIndex = 0;
            this.btn_Masalar.Text = "  Masalar";
            this.btn_Masalar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Masalar.UseVisualStyleBackColor = true;
            this.btn_Masalar.Click += new System.EventHandler(this.btn_Masalar_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lithos Pro Regular", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(69, 354);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(716, 82);
            this.label1.TabIndex = 1;
            this.label1.Text = "PASTORİZE BİLİŞİM";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 559);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelMenu);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.MinimumSize = new System.Drawing.Size(1061, 598);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pastorize Bilişim Cafe";
            this.Load += new System.EventHandler(this.Home_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelDesktop.ResumeLayout(false);
            this.panelDesktop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Masalar;
        private System.Windows.Forms.Button btn_Personel;
        private System.Windows.Forms.Button btn_KasaIslemleri;
        private System.Windows.Forms.Button btn_Kampanyalar;
        private System.Windows.Forms.Button btn_Mutfak;
        private System.Windows.Forms.Button btn_Raporlar;
        private System.Windows.Forms.Button btn_Ayarlar;
        private System.Windows.Forms.Button btn_Menu;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelMenu;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Button btn_FormClose;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}

