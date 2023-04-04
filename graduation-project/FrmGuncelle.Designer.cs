namespace graduation_project
{
    partial class FrmGuncelle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGuncelle));
            this.CmbSorumlu = new System.Windows.Forms.ComboBox();
            this.RchAciklama = new System.Windows.Forms.RichTextBox();
            this.TxtProje = new System.Windows.Forms.TextBox();
            this.DtpTeslimTarih = new System.Windows.Forms.DateTimePicker();
            this.TxtBaslik = new System.Windows.Forms.TextBox();
            this.CmbIsTipi = new System.Windows.Forms.ComboBox();
            this.BtnTemizle = new System.Windows.Forms.Button();
            this.CmbDurum = new System.Windows.Forms.ComboBox();
            this.DtpGuncellemeTarih = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DtpOlusturmaTarih = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnIslemDon = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnGuncelle = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TxtId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // CmbSorumlu
            // 
            this.CmbSorumlu.FormattingEnabled = true;
            this.CmbSorumlu.Items.AddRange(new object[] {
            "Boran Tufan",
            "Aysun Kutlu",
            "Celal Topçu",
            "Ceyda Saygi",
            "Güney Uğurlu",
            "Altay Köse",
            "Burçin Koçyigit",
            "Doruk Öztürk"});
            this.CmbSorumlu.Location = new System.Drawing.Point(573, 151);
            this.CmbSorumlu.Name = "CmbSorumlu";
            this.CmbSorumlu.Size = new System.Drawing.Size(224, 29);
            this.CmbSorumlu.TabIndex = 34;
            // 
            // RchAciklama
            // 
            this.RchAciklama.Location = new System.Drawing.Point(170, 278);
            this.RchAciklama.Name = "RchAciklama";
            this.RchAciklama.Size = new System.Drawing.Size(987, 151);
            this.RchAciklama.TabIndex = 35;
            this.RchAciklama.Text = "";
            // 
            // TxtProje
            // 
            this.TxtProje.Location = new System.Drawing.Point(933, 154);
            this.TxtProje.Name = "TxtProje";
            this.TxtProje.Size = new System.Drawing.Size(224, 28);
            this.TxtProje.TabIndex = 33;
            // 
            // DtpTeslimTarih
            // 
            this.DtpTeslimTarih.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpTeslimTarih.Location = new System.Drawing.Point(933, 81);
            this.DtpTeslimTarih.Name = "DtpTeslimTarih";
            this.DtpTeslimTarih.Size = new System.Drawing.Size(224, 28);
            this.DtpTeslimTarih.TabIndex = 38;
            // 
            // TxtBaslik
            // 
            this.TxtBaslik.Location = new System.Drawing.Point(170, 218);
            this.TxtBaslik.Name = "TxtBaslik";
            this.TxtBaslik.Size = new System.Drawing.Size(224, 28);
            this.TxtBaslik.TabIndex = 32;
            // 
            // CmbIsTipi
            // 
            this.CmbIsTipi.FormattingEnabled = true;
            this.CmbIsTipi.Items.AddRange(new object[] {
            "Soru",
            "Hata",
            "Geliştirme"});
            this.CmbIsTipi.Location = new System.Drawing.Point(573, 219);
            this.CmbIsTipi.Name = "CmbIsTipi";
            this.CmbIsTipi.Size = new System.Drawing.Size(224, 29);
            this.CmbIsTipi.TabIndex = 31;
            // 
            // BtnTemizle
            // 
            this.BtnTemizle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(91)))), ((int)(((byte)(72)))));
            this.BtnTemizle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(38)))), ((int)(((byte)(57)))));
            this.BtnTemizle.Location = new System.Drawing.Point(893, 459);
            this.BtnTemizle.Name = "BtnTemizle";
            this.BtnTemizle.Size = new System.Drawing.Size(129, 41);
            this.BtnTemizle.TabIndex = 41;
            this.BtnTemizle.Text = "Temizle";
            this.BtnTemizle.UseVisualStyleBackColor = false;
            this.BtnTemizle.Click += new System.EventHandler(this.BtnTemizle_Click);
            // 
            // CmbDurum
            // 
            this.CmbDurum.FormattingEnabled = true;
            this.CmbDurum.Items.AddRange(new object[] {
            "Test",
            "Yeni",
            "Canlı",
            "Analiz",
            "Geliştirme",
            "Müşteri Testi"});
            this.CmbDurum.Location = new System.Drawing.Point(170, 148);
            this.CmbDurum.Name = "CmbDurum";
            this.CmbDurum.Size = new System.Drawing.Size(224, 29);
            this.CmbDurum.TabIndex = 30;
            // 
            // DtpGuncellemeTarih
            // 
            this.DtpGuncellemeTarih.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpGuncellemeTarih.Location = new System.Drawing.Point(573, 80);
            this.DtpGuncellemeTarih.Name = "DtpGuncellemeTarih";
            this.DtpGuncellemeTarih.Size = new System.Drawing.Size(224, 28);
            this.DtpGuncellemeTarih.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(97, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 21);
            this.label1.TabIndex = 21;
            this.label1.Text = "Durum :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(512, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 21);
            this.label2.TabIndex = 22;
            this.label2.Text = "İş Tipi:";
            // 
            // DtpOlusturmaTarih
            // 
            this.DtpOlusturmaTarih.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpOlusturmaTarih.Location = new System.Drawing.Point(170, 78);
            this.DtpOlusturmaTarih.Name = "DtpOlusturmaTarih";
            this.DtpOlusturmaTarih.Size = new System.Drawing.Size(224, 28);
            this.DtpOlusturmaTarih.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(106, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 21);
            this.label3.TabIndex = 23;
            this.label3.Text = "Başlık: ";
            // 
            // BtnIslemDon
            // 
            this.BtnIslemDon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(103)))), ((int)(((byte)(105)))));
            this.BtnIslemDon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(38)))), ((int)(((byte)(57)))));
            this.BtnIslemDon.Location = new System.Drawing.Point(758, 459);
            this.BtnIslemDon.Name = "BtnIslemDon";
            this.BtnIslemDon.Size = new System.Drawing.Size(129, 41);
            this.BtnIslemDon.TabIndex = 40;
            this.BtnIslemDon.Text = "Geri Dön";
            this.BtnIslemDon.UseVisualStyleBackColor = false;
            this.BtnIslemDon.Click += new System.EventHandler(this.BtnIslemDon_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.label6.Location = new System.Drawing.Point(473, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 21);
            this.label6.TabIndex = 26;
            this.label6.Text = "S. Kullanıcı:";
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(177)))), ((int)(((byte)(152)))));
            this.BtnGuncelle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(38)))), ((int)(((byte)(57)))));
            this.BtnGuncelle.Location = new System.Drawing.Point(1028, 459);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(129, 41);
            this.BtnGuncelle.TabIndex = 39;
            this.BtnGuncelle.Text = "Güncelle";
            this.BtnGuncelle.UseVisualStyleBackColor = false;
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.label5.Location = new System.Drawing.Point(874, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 21);
            this.label5.TabIndex = 25;
            this.label5.Text = "Proje:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.label7.Location = new System.Drawing.Point(22, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 21);
            this.label7.TabIndex = 27;
            this.label7.Text = "Oluşturma Tarihi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.label4.Location = new System.Drawing.Point(83, 278);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 21);
            this.label4.TabIndex = 24;
            this.label4.Text = "Açıklama:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.label8.Location = new System.Drawing.Point(413, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(151, 21);
            this.label8.TabIndex = 28;
            this.label8.Text = "Güncelleme Tarihi:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.label9.Location = new System.Drawing.Point(817, 85);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 21);
            this.label9.TabIndex = 29;
            this.label9.Text = "Teslim Tarihi:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(26, 513);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1131, 236);
            this.dataGridView1.TabIndex = 42;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // TxtId
            // 
            this.TxtId.Location = new System.Drawing.Point(491, 24);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(100, 28);
            this.TxtId.TabIndex = 43;
            // 
            // FrmGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(169)))), ((int)(((byte)(155)))));
            this.ClientSize = new System.Drawing.Size(1228, 768);
            this.Controls.Add(this.TxtId);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.CmbSorumlu);
            this.Controls.Add(this.RchAciklama);
            this.Controls.Add(this.TxtProje);
            this.Controls.Add(this.DtpTeslimTarih);
            this.Controls.Add(this.TxtBaslik);
            this.Controls.Add(this.CmbIsTipi);
            this.Controls.Add(this.BtnTemizle);
            this.Controls.Add(this.CmbDurum);
            this.Controls.Add(this.DtpGuncellemeTarih);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DtpOlusturmaTarih);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnIslemDon);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BtnGuncelle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MinimizeBox = false;
            this.Name = "FrmGuncelle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Düzenleme Paneli";
            this.Load += new System.EventHandler(this.FrmDuzenle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CmbSorumlu;
        private System.Windows.Forms.RichTextBox RchAciklama;
        private System.Windows.Forms.TextBox TxtProje;
        private System.Windows.Forms.DateTimePicker DtpTeslimTarih;
        private System.Windows.Forms.TextBox TxtBaslik;
        private System.Windows.Forms.ComboBox CmbIsTipi;
        private System.Windows.Forms.Button BtnTemizle;
        private System.Windows.Forms.ComboBox CmbDurum;
        private System.Windows.Forms.DateTimePicker DtpGuncellemeTarih;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DtpOlusturmaTarih;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnIslemDon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtnGuncelle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox TxtId;
    }
}