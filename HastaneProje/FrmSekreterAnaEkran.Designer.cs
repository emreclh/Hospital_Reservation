namespace HastaneProje
{
    partial class FrmSekreterAnaEkran
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LblSifre = new System.Windows.Forms.LinkLabel();
            this.BtnCikis = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BtnRandevuGuncelle = new System.Windows.Forms.Button();
            this.TxtSaat = new System.Windows.Forms.MaskedTextBox();
            this.CmbBrans = new System.Windows.Forms.ComboBox();
            this.CmbDktr = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.LblHastaSoyad = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.LblHastaTc = new System.Windows.Forms.Label();
            this.LblHastaAd = new System.Windows.Forms.Label();
            this.BtnPrsnlDuznle = new System.Windows.Forms.Button();
            this.LblSoyad = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LblTc = new System.Windows.Forms.Label();
            this.LblAd = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TxtTarih = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LblSifre);
            this.groupBox1.Controls.Add(this.BtnCikis);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.BtnPrsnlDuznle);
            this.groupBox1.Controls.Add(this.LblSoyad);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.LblTc);
            this.groupBox1.Controls.Add(this.LblAd);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(273, 488);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sekreter Bilgi";
            // 
            // LblSifre
            // 
            this.LblSifre.AutoSize = true;
            this.LblSifre.LinkColor = System.Drawing.Color.Red;
            this.LblSifre.Location = new System.Drawing.Point(154, 98);
            this.LblSifre.Name = "LblSifre";
            this.LblSifre.Size = new System.Drawing.Size(113, 22);
            this.LblSifre.TabIndex = 25;
            this.LblSifre.TabStop = true;
            this.LblSifre.Text = "Şifre Değiştir";
            this.LblSifre.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LblSifre_LinkClicked);
            // 
            // BtnCikis
            // 
            this.BtnCikis.Location = new System.Drawing.Point(6, 450);
            this.BtnCikis.Name = "BtnCikis";
            this.BtnCikis.Size = new System.Drawing.Size(261, 32);
            this.BtnCikis.TabIndex = 24;
            this.BtnCikis.Text = "Sistemi Kapat";
            this.BtnCikis.UseVisualStyleBackColor = true;
            this.BtnCikis.Click += new System.EventHandler(this.BtnCikis_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BtnRandevuGuncelle);
            this.groupBox3.Controls.Add(this.TxtSaat);
            this.groupBox3.Controls.Add(this.TxtTarih);
            this.groupBox3.Controls.Add(this.CmbBrans);
            this.groupBox3.Controls.Add(this.CmbDktr);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.LblHastaSoyad);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.LblHastaTc);
            this.groupBox3.Controls.Add(this.LblHastaAd);
            this.groupBox3.Location = new System.Drawing.Point(6, 123);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(261, 283);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Randevu İşlemleri";
            // 
            // BtnRandevuGuncelle
            // 
            this.BtnRandevuGuncelle.Location = new System.Drawing.Point(36, 247);
            this.BtnRandevuGuncelle.Name = "BtnRandevuGuncelle";
            this.BtnRandevuGuncelle.Size = new System.Drawing.Size(195, 29);
            this.BtnRandevuGuncelle.TabIndex = 0;
            this.BtnRandevuGuncelle.Text = "Randevuyu Tamamla";
            this.BtnRandevuGuncelle.UseVisualStyleBackColor = true;
            this.BtnRandevuGuncelle.Click += new System.EventHandler(this.BtnRandevuGuncelle_Click);
            // 
            // TxtSaat
            // 
            this.TxtSaat.Location = new System.Drawing.Point(134, 213);
            this.TxtSaat.Mask = "00:00";
            this.TxtSaat.Name = "TxtSaat";
            this.TxtSaat.Size = new System.Drawing.Size(121, 28);
            this.TxtSaat.TabIndex = 37;
            this.TxtSaat.ValidatingType = typeof(System.DateTime);
            // 
            // CmbBrans
            // 
            this.CmbBrans.FormattingEnabled = true;
            this.CmbBrans.Location = new System.Drawing.Point(134, 138);
            this.CmbBrans.Name = "CmbBrans";
            this.CmbBrans.Size = new System.Drawing.Size(121, 30);
            this.CmbBrans.TabIndex = 36;
            // 
            // CmbDktr
            // 
            this.CmbDktr.FormattingEnabled = true;
            this.CmbDktr.Location = new System.Drawing.Point(134, 102);
            this.CmbDktr.Name = "CmbDktr";
            this.CmbDktr.Size = new System.Drawing.Size(121, 30);
            this.CmbDktr.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 22);
            this.label2.TabIndex = 35;
            this.label2.Text = "Saat:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(67, 182);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 22);
            this.label8.TabIndex = 34;
            this.label8.Text = "Tarih:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(56, 105);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 22);
            this.label9.TabIndex = 32;
            this.label9.Text = "Doktor:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(4, 141);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(120, 22);
            this.label10.TabIndex = 30;
            this.label10.Text = "Doktor Branş:";
            // 
            // LblHastaSoyad
            // 
            this.LblHastaSoyad.AutoSize = true;
            this.LblHastaSoyad.Location = new System.Drawing.Point(130, 68);
            this.LblHastaSoyad.Name = "LblHastaSoyad";
            this.LblHastaSoyad.Size = new System.Drawing.Size(0, 22);
            this.LblHastaSoyad.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 22);
            this.label5.TabIndex = 28;
            this.label5.Text = "Hasta Soyad:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 22);
            this.label6.TabIndex = 26;
            this.label6.Text = "Hasta Ad:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 22);
            this.label7.TabIndex = 24;
            this.label7.Text = "Hasta TC:";
            // 
            // LblHastaTc
            // 
            this.LblHastaTc.AutoSize = true;
            this.LblHastaTc.Location = new System.Drawing.Point(130, 24);
            this.LblHastaTc.Name = "LblHastaTc";
            this.LblHastaTc.Size = new System.Drawing.Size(120, 22);
            this.LblHastaTc.TabIndex = 25;
            this.LblHastaTc.Text = "00000000000";
            // 
            // LblHastaAd
            // 
            this.LblHastaAd.AutoSize = true;
            this.LblHastaAd.Location = new System.Drawing.Point(130, 46);
            this.LblHastaAd.Name = "LblHastaAd";
            this.LblHastaAd.Size = new System.Drawing.Size(0, 22);
            this.LblHastaAd.TabIndex = 27;
            // 
            // BtnPrsnlDuznle
            // 
            this.BtnPrsnlDuznle.Location = new System.Drawing.Point(6, 412);
            this.BtnPrsnlDuznle.Name = "BtnPrsnlDuznle";
            this.BtnPrsnlDuznle.Size = new System.Drawing.Size(261, 32);
            this.BtnPrsnlDuznle.TabIndex = 1;
            this.BtnPrsnlDuznle.Text = "Personel Düzenleme Menüsü";
            this.BtnPrsnlDuznle.UseVisualStyleBackColor = true;
            this.BtnPrsnlDuznle.Click += new System.EventHandler(this.BtnPrsnlDuznle_Click);
            // 
            // LblSoyad
            // 
            this.LblSoyad.AutoSize = true;
            this.LblSoyad.Location = new System.Drawing.Point(90, 68);
            this.LblSoyad.Name = "LblSoyad";
            this.LblSoyad.Size = new System.Drawing.Size(0, 22);
            this.LblSoyad.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 22);
            this.label4.TabIndex = 22;
            this.label4.Text = "Soyad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 22);
            this.label3.TabIndex = 20;
            this.label3.Text = "Ad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 22);
            this.label1.TabIndex = 18;
            this.label1.Text = "T.C. No:";
            // 
            // LblTc
            // 
            this.LblTc.AutoSize = true;
            this.LblTc.Location = new System.Drawing.Point(90, 24);
            this.LblTc.Name = "LblTc";
            this.LblTc.Size = new System.Drawing.Size(120, 22);
            this.LblTc.TabIndex = 19;
            this.LblTc.Text = "00000000000";
            this.LblTc.Click += new System.EventHandler(this.LblTc_Click);
            // 
            // LblAd
            // 
            this.LblAd.AutoSize = true;
            this.LblAd.Location = new System.Drawing.Point(90, 46);
            this.LblAd.Name = "LblAd";
            this.LblAd.Size = new System.Drawing.Size(0, 22);
            this.LblAd.TabIndex = 21;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(291, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(748, 488);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Aktif Randevular";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(742, 461);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // TxtTarih
            // 
            this.TxtTarih.Location = new System.Drawing.Point(134, 179);
            this.TxtTarih.Mask = "00/00/0000";
            this.TxtTarih.Name = "TxtTarih";
            this.TxtTarih.Size = new System.Drawing.Size(121, 28);
            this.TxtTarih.TabIndex = 1;
            this.TxtTarih.ValidatingType = typeof(System.DateTime);
            // 
            // FrmSekreterAnaEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1048, 512);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmSekreterAnaEkran";
            this.Text = "FrmSekreterAnaEkran";
            this.Load += new System.EventHandler(this.FrmSekreterAnaEkran_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LblSoyad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblTc;
        private System.Windows.Forms.Label LblAd;
        private System.Windows.Forms.Button BtnPrsnlDuznle;
        private System.Windows.Forms.Button BtnRandevuGuncelle;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label LblHastaSoyad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label LblHastaTc;
        private System.Windows.Forms.Label LblHastaAd;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MaskedTextBox TxtSaat;
        private System.Windows.Forms.ComboBox CmbBrans;
        private System.Windows.Forms.ComboBox CmbDktr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button BtnCikis;
        private System.Windows.Forms.LinkLabel LblSifre;
        private System.Windows.Forms.MaskedTextBox TxtTarih;
    }
}