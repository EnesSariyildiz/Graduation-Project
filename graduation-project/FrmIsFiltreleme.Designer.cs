﻿namespace graduation_project
{
    partial class FrmIsFiltreleme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmIsFiltreleme));
            this.label1 = new System.Windows.Forms.Label();
            this.CmbDurum = new System.Windows.Forms.ComboBox();
            this.CmbIsTipi = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CmbSorumlu = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.DtpOlusturmaTarih = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnFiltrele = new System.Windows.Forms.Button();
            this.BtnGeriDön = new System.Windows.Forms.Button();
            this.BtnListeyiGuncelle = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(16, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Durum";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // CmbDurum
            // 
            this.CmbDurum.Font = new System.Drawing.Font("Baloo Thambi 2", 14.25F);
            this.CmbDurum.FormattingEnabled = true;
            this.CmbDurum.Items.AddRange(new object[] {
            "Test",
            "Yeni",
            "Canlı",
            "Analiz",
            "Geliştirme",
            "Müşteri Testi"});
            this.CmbDurum.Location = new System.Drawing.Point(69, 32);
            this.CmbDurum.Name = "CmbDurum";
            this.CmbDurum.Size = new System.Drawing.Size(131, 37);
            this.CmbDurum.TabIndex = 1;
            // 
            // CmbIsTipi
            // 
            this.CmbIsTipi.Font = new System.Drawing.Font("Baloo Thambi 2", 14.25F);
            this.CmbIsTipi.FormattingEnabled = true;
            this.CmbIsTipi.Items.AddRange(new object[] {
            "Soru",
            "Hata",
            "Geliştirme"});
            this.CmbIsTipi.Location = new System.Drawing.Point(258, 32);
            this.CmbIsTipi.Name = "CmbIsTipi";
            this.CmbIsTipi.Size = new System.Drawing.Size(131, 37);
            this.CmbIsTipi.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(205, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "İş Tipi";
            // 
            // CmbSorumlu
            // 
            this.CmbSorumlu.Font = new System.Drawing.Font("Baloo Thambi 2", 14.25F);
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
            this.CmbSorumlu.Location = new System.Drawing.Point(467, 31);
            this.CmbSorumlu.Name = "CmbSorumlu";
            this.CmbSorumlu.Size = new System.Drawing.Size(131, 37);
            this.CmbSorumlu.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.label5.Location = new System.Drawing.Point(399, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 19);
            this.label5.TabIndex = 10;
            this.label5.Text = "Sorumlu";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.label8.Location = new System.Drawing.Point(607, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 19);
            this.label8.TabIndex = 14;
            this.label8.Text = "Oluşturma Tarihi";
            // 
            // DtpOlusturmaTarih
            // 
            this.DtpOlusturmaTarih.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F);
            this.DtpOlusturmaTarih.Location = new System.Drawing.Point(721, 38);
            this.DtpOlusturmaTarih.Name = "DtpOlusturmaTarih";
            this.DtpOlusturmaTarih.Size = new System.Drawing.Size(182, 24);
            this.DtpOlusturmaTarih.TabIndex = 15;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 181);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1090, 348);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1084, 321);
            this.dataGridView1.TabIndex = 0;
            // 
            // BtnFiltrele
            // 
            this.BtnFiltrele.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.BtnFiltrele.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.BtnFiltrele.Location = new System.Drawing.Point(786, 134);
            this.BtnFiltrele.Name = "BtnFiltrele";
            this.BtnFiltrele.Size = new System.Drawing.Size(224, 41);
            this.BtnFiltrele.TabIndex = 22;
            this.BtnFiltrele.Text = "Filtrele";
            this.BtnFiltrele.UseVisualStyleBackColor = false;
            this.BtnFiltrele.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnGeriDön
            // 
            this.BtnGeriDön.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(103)))), ((int)(((byte)(105)))));
            this.BtnGeriDön.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.BtnGeriDön.Location = new System.Drawing.Point(323, 134);
            this.BtnGeriDön.Name = "BtnGeriDön";
            this.BtnGeriDön.Size = new System.Drawing.Size(224, 41);
            this.BtnGeriDön.TabIndex = 23;
            this.BtnGeriDön.Text = "Geri Dön";
            this.BtnGeriDön.UseVisualStyleBackColor = false;
            this.BtnGeriDön.Click += new System.EventHandler(this.button2_Click);
            // 
            // BtnListeyiGuncelle
            // 
            this.BtnListeyiGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.BtnListeyiGuncelle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.BtnListeyiGuncelle.Location = new System.Drawing.Point(553, 134);
            this.BtnListeyiGuncelle.Name = "BtnListeyiGuncelle";
            this.BtnListeyiGuncelle.Size = new System.Drawing.Size(224, 41);
            this.BtnListeyiGuncelle.TabIndex = 26;
            this.BtnListeyiGuncelle.Text = "Listeyi Güncelle";
            this.BtnListeyiGuncelle.UseVisualStyleBackColor = false;
            this.BtnListeyiGuncelle.Click += new System.EventHandler(this.BtnListeyiGuncelle_Click);
            // 
            // FrmIsFiltreleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(169)))), ((int)(((byte)(155)))));
            this.ClientSize = new System.Drawing.Size(1113, 538);
            this.Controls.Add(this.BtnListeyiGuncelle);
            this.Controls.Add(this.BtnGeriDön);
            this.Controls.Add(this.BtnFiltrele);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DtpOlusturmaTarih);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.CmbSorumlu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CmbIsTipi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CmbDurum);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmIsFiltreleme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "İş Filtreleme";
            this.Load += new System.EventHandler(this.FrmIsFiltreleme_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CmbDurum;
        private System.Windows.Forms.ComboBox CmbIsTipi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CmbSorumlu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker DtpOlusturmaTarih;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnFiltrele;
        private System.Windows.Forms.Button BtnGeriDön;
        private System.Windows.Forms.Button BtnListeyiGuncelle;
    }
}