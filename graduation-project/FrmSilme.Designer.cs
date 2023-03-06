namespace graduation_project
{
    partial class FrmSilme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSilme));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.BtnKaydıSil = new System.Windows.Forms.Button();
            this.BtnListeGüncelle = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(14, 92);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(1085, 432);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kayıtlar";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(5, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1075, 401);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID :";
            // 
            // TxtId
            // 
            this.TxtId.Location = new System.Drawing.Point(74, 39);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(196, 28);
            this.TxtId.TabIndex = 2;
            // 
            // BtnKaydıSil
            // 
            this.BtnKaydıSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(91)))), ((int)(((byte)(72)))));
            this.BtnKaydıSil.Location = new System.Drawing.Point(276, 39);
            this.BtnKaydıSil.Name = "BtnKaydıSil";
            this.BtnKaydıSil.Size = new System.Drawing.Size(196, 31);
            this.BtnKaydıSil.TabIndex = 3;
            this.BtnKaydıSil.Text = "Kaydı Sil";
            this.BtnKaydıSil.UseVisualStyleBackColor = false;
            this.BtnKaydıSil.Click += new System.EventHandler(this.BtnKaydıSil_Click);
            // 
            // BtnListeGüncelle
            // 
            this.BtnListeGüncelle.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnListeGüncelle.Location = new System.Drawing.Point(478, 39);
            this.BtnListeGüncelle.Name = "BtnListeGüncelle";
            this.BtnListeGüncelle.Size = new System.Drawing.Size(196, 31);
            this.BtnListeGüncelle.TabIndex = 4;
            this.BtnListeGüncelle.Text = "Listeyi Güncelle";
            this.BtnListeGüncelle.UseVisualStyleBackColor = false;
            this.BtnListeGüncelle.Click += new System.EventHandler(this.BtnListeGüncelle_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.CadetBlue;
            this.button2.Location = new System.Drawing.Point(680, 39);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(196, 31);
            this.button2.TabIndex = 5;
            this.button2.Text = "Geri Dön";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FrmSilme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(169)))), ((int)(((byte)(155)))));
            this.ClientSize = new System.Drawing.Size(1113, 538);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.BtnListeGüncelle);
            this.Controls.Add(this.BtnKaydıSil);
            this.Controls.Add(this.TxtId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "FrmSilme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "İşlem Silme";
            this.Load += new System.EventHandler(this.FrmSilme_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.Button BtnKaydıSil;
        private System.Windows.Forms.Button BtnListeGüncelle;
        private System.Windows.Forms.Button button2;
    }
}