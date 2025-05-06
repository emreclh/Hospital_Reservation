namespace HastaneProje
{
    partial class FrmPrsnlGuncelle
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CmbDktrBrns = new System.Windows.Forms.ComboBox();
            this.TxtDktrSoyad = new System.Windows.Forms.TextBox();
            this.TxtDktrAd = new System.Windows.Forms.TextBox();
            this.TxtDktrTc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnDktrEkle = new System.Windows.Forms.Button();
            this.BtnDktrSil = new System.Windows.Forms.Button();
            this.BtnDktrGunc = new System.Windows.Forms.Button();
            this.BtnDktrList = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.doktorIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doktorAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doktorSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doktorBransDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doktorTCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblDoktorlarBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.hastaneProjeDataSet1 = new HastaneProje.HastaneProjeDataSet1();
            this.hastaneProjeDataSet = new HastaneProje.HastaneProjeDataSet();
            this.tblDoktorlarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_DoktorlarTableAdapter = new HastaneProje.HastaneProjeDataSetTableAdapters.Tbl_DoktorlarTableAdapter();
            this.tblSekreterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_SekreterTableAdapter = new HastaneProje.HastaneProjeDataSetTableAdapters.Tbl_SekreterTableAdapter();
            this.tbl_DoktorlarTableAdapter1 = new HastaneProje.HastaneProjeDataSet1TableAdapters.Tbl_DoktorlarTableAdapter();
            this.tblSekreterBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_SekreterTableAdapter1 = new HastaneProje.HastaneProjeDataSet1TableAdapters.Tbl_SekreterTableAdapter();
            this.BtnSkrtrList = new System.Windows.Forms.Button();
            this.BtnSkrtrGnc = new System.Windows.Forms.Button();
            this.BtnSkrtrSil = new System.Windows.Forms.Button();
            this.BtnSkrtrEkle = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtSkrtrSoyad = new System.Windows.Forms.TextBox();
            this.TxtSkrtrTc = new System.Windows.Forms.TextBox();
            this.TxtSkrtrAd = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.sekreterIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sekreterAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sekreterSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sekreterTCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDoktorlarBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneProjeDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneProjeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDoktorlarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSekreterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSekreterBindingSource1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CmbDktrBrns);
            this.groupBox1.Controls.Add(this.TxtDktrSoyad);
            this.groupBox1.Controls.Add(this.TxtDktrAd);
            this.groupBox1.Controls.Add(this.TxtDktrTc);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.BtnDktrEkle);
            this.groupBox1.Controls.Add(this.BtnDktrSil);
            this.groupBox1.Controls.Add(this.BtnDktrGunc);
            this.groupBox1.Controls.Add(this.BtnDktrList);
            this.groupBox1.Location = new System.Drawing.Point(12, 299);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(348, 284);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Doktor Menüsü";
            // 
            // CmbDktrBrns
            // 
            this.CmbDktrBrns.FormattingEnabled = true;
            this.CmbDktrBrns.Location = new System.Drawing.Point(89, 126);
            this.CmbDktrBrns.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CmbDktrBrns.Name = "CmbDktrBrns";
            this.CmbDktrBrns.Size = new System.Drawing.Size(120, 30);
            this.CmbDktrBrns.TabIndex = 26;
            this.CmbDktrBrns.SelectedIndexChanged += new System.EventHandler(this.CmbDktrBrns_SelectedIndexChanged);
            // 
            // TxtDktrSoyad
            // 
            this.TxtDktrSoyad.Location = new System.Drawing.Point(89, 92);
            this.TxtDktrSoyad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtDktrSoyad.Name = "TxtDktrSoyad";
            this.TxtDktrSoyad.Size = new System.Drawing.Size(120, 28);
            this.TxtDktrSoyad.TabIndex = 20;
            // 
            // TxtDktrAd
            // 
            this.TxtDktrAd.Location = new System.Drawing.Point(89, 57);
            this.TxtDktrAd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtDktrAd.Name = "TxtDktrAd";
            this.TxtDktrAd.Size = new System.Drawing.Size(120, 28);
            this.TxtDktrAd.TabIndex = 21;
            // 
            // TxtDktrTc
            // 
            this.TxtDktrTc.Location = new System.Drawing.Point(89, 163);
            this.TxtDktrTc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtDktrTc.Name = "TxtDktrTc";
            this.TxtDktrTc.Size = new System.Drawing.Size(120, 28);
            this.TxtDktrTc.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 22);
            this.label4.TabIndex = 12;
            this.label4.Text = "T.C. No:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 22);
            this.label3.TabIndex = 11;
            this.label3.Text = "Branş:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 22);
            this.label2.TabIndex = 10;
            this.label2.Text = "Soyad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ad:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // BtnDktrEkle
            // 
            this.BtnDktrEkle.Location = new System.Drawing.Point(134, 205);
            this.BtnDktrEkle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnDktrEkle.Name = "BtnDktrEkle";
            this.BtnDktrEkle.Size = new System.Drawing.Size(120, 31);
            this.BtnDktrEkle.TabIndex = 9;
            this.BtnDktrEkle.Text = "Ekle";
            this.BtnDktrEkle.UseVisualStyleBackColor = true;
            this.BtnDktrEkle.Click += new System.EventHandler(this.BtnDktrEkle_Click);
            // 
            // BtnDktrSil
            // 
            this.BtnDktrSil.Location = new System.Drawing.Point(134, 241);
            this.BtnDktrSil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnDktrSil.Name = "BtnDktrSil";
            this.BtnDktrSil.Size = new System.Drawing.Size(120, 31);
            this.BtnDktrSil.TabIndex = 8;
            this.BtnDktrSil.Text = "Sil";
            this.BtnDktrSil.UseVisualStyleBackColor = true;
            this.BtnDktrSil.Click += new System.EventHandler(this.BtnDktrSil_Click);
            // 
            // BtnDktrGunc
            // 
            this.BtnDktrGunc.Location = new System.Drawing.Point(6, 241);
            this.BtnDktrGunc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnDktrGunc.Name = "BtnDktrGunc";
            this.BtnDktrGunc.Size = new System.Drawing.Size(120, 31);
            this.BtnDktrGunc.TabIndex = 7;
            this.BtnDktrGunc.Text = "Güncelle";
            this.BtnDktrGunc.UseVisualStyleBackColor = true;
            this.BtnDktrGunc.Click += new System.EventHandler(this.BtnDktrGunc_Click);
            // 
            // BtnDktrList
            // 
            this.BtnDktrList.Location = new System.Drawing.Point(6, 205);
            this.BtnDktrList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnDktrList.Name = "BtnDktrList";
            this.BtnDktrList.Size = new System.Drawing.Size(120, 31);
            this.BtnDktrList.TabIndex = 6;
            this.BtnDktrList.Text = "Listele";
            this.BtnDktrList.UseVisualStyleBackColor = true;
            this.BtnDktrList.Click += new System.EventHandler(this.BtnDktrList_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(369, 299);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(655, 284);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Doktorlar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.doktorIDDataGridViewTextBoxColumn,
            this.doktorAdDataGridViewTextBoxColumn,
            this.doktorSoyadDataGridViewTextBoxColumn,
            this.doktorBransDataGridViewTextBoxColumn,
            this.doktorTCDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblDoktorlarBindingSource1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 17);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(649, 265);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // doktorIDDataGridViewTextBoxColumn
            // 
            this.doktorIDDataGridViewTextBoxColumn.DataPropertyName = "DoktorID";
            this.doktorIDDataGridViewTextBoxColumn.HeaderText = "DoktorID";
            this.doktorIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.doktorIDDataGridViewTextBoxColumn.Name = "doktorIDDataGridViewTextBoxColumn";
            this.doktorIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.doktorIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // doktorAdDataGridViewTextBoxColumn
            // 
            this.doktorAdDataGridViewTextBoxColumn.DataPropertyName = "DoktorAd";
            this.doktorAdDataGridViewTextBoxColumn.HeaderText = "DoktorAd";
            this.doktorAdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.doktorAdDataGridViewTextBoxColumn.Name = "doktorAdDataGridViewTextBoxColumn";
            this.doktorAdDataGridViewTextBoxColumn.Width = 125;
            // 
            // doktorSoyadDataGridViewTextBoxColumn
            // 
            this.doktorSoyadDataGridViewTextBoxColumn.DataPropertyName = "DoktorSoyad";
            this.doktorSoyadDataGridViewTextBoxColumn.HeaderText = "DoktorSoyad";
            this.doktorSoyadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.doktorSoyadDataGridViewTextBoxColumn.Name = "doktorSoyadDataGridViewTextBoxColumn";
            this.doktorSoyadDataGridViewTextBoxColumn.Width = 125;
            // 
            // doktorBransDataGridViewTextBoxColumn
            // 
            this.doktorBransDataGridViewTextBoxColumn.DataPropertyName = "DoktorBrans";
            this.doktorBransDataGridViewTextBoxColumn.HeaderText = "DoktorBrans";
            this.doktorBransDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.doktorBransDataGridViewTextBoxColumn.Name = "doktorBransDataGridViewTextBoxColumn";
            this.doktorBransDataGridViewTextBoxColumn.Width = 125;
            // 
            // doktorTCDataGridViewTextBoxColumn
            // 
            this.doktorTCDataGridViewTextBoxColumn.DataPropertyName = "DoktorTC";
            this.doktorTCDataGridViewTextBoxColumn.HeaderText = "DoktorTC";
            this.doktorTCDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.doktorTCDataGridViewTextBoxColumn.Name = "doktorTCDataGridViewTextBoxColumn";
            this.doktorTCDataGridViewTextBoxColumn.Width = 125;
            // 
            // tblDoktorlarBindingSource1
            // 
            this.tblDoktorlarBindingSource1.DataMember = "Tbl_Doktorlar";
            this.tblDoktorlarBindingSource1.DataSource = this.hastaneProjeDataSet1;
            // 
            // hastaneProjeDataSet1
            // 
            this.hastaneProjeDataSet1.DataSetName = "HastaneProjeDataSet1";
            this.hastaneProjeDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hastaneProjeDataSet
            // 
            this.hastaneProjeDataSet.DataSetName = "HastaneProjeDataSet";
            this.hastaneProjeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblDoktorlarBindingSource
            // 
            this.tblDoktorlarBindingSource.DataMember = "Tbl_Doktorlar";
            this.tblDoktorlarBindingSource.DataSource = this.hastaneProjeDataSet;
            // 
            // tbl_DoktorlarTableAdapter
            // 
            this.tbl_DoktorlarTableAdapter.ClearBeforeFill = true;
            // 
            // tblSekreterBindingSource
            // 
            this.tblSekreterBindingSource.DataMember = "Tbl_Sekreter";
            this.tblSekreterBindingSource.DataSource = this.hastaneProjeDataSet;
            // 
            // tbl_SekreterTableAdapter
            // 
            this.tbl_SekreterTableAdapter.ClearBeforeFill = true;
            // 
            // tbl_DoktorlarTableAdapter1
            // 
            this.tbl_DoktorlarTableAdapter1.ClearBeforeFill = true;
            // 
            // tblSekreterBindingSource1
            // 
            this.tblSekreterBindingSource1.DataMember = "Tbl_Sekreter";
            this.tblSekreterBindingSource1.DataSource = this.hastaneProjeDataSet1;
            // 
            // tbl_SekreterTableAdapter1
            // 
            this.tbl_SekreterTableAdapter1.ClearBeforeFill = true;
            // 
            // BtnSkrtrList
            // 
            this.BtnSkrtrList.Location = new System.Drawing.Point(6, 205);
            this.BtnSkrtrList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnSkrtrList.Name = "BtnSkrtrList";
            this.BtnSkrtrList.Size = new System.Drawing.Size(120, 31);
            this.BtnSkrtrList.TabIndex = 1;
            this.BtnSkrtrList.Text = "Listele";
            this.BtnSkrtrList.UseVisualStyleBackColor = true;
            this.BtnSkrtrList.Click += new System.EventHandler(this.BtnSkrtrList_Click);
            // 
            // BtnSkrtrGnc
            // 
            this.BtnSkrtrGnc.Location = new System.Drawing.Point(6, 241);
            this.BtnSkrtrGnc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnSkrtrGnc.Name = "BtnSkrtrGnc";
            this.BtnSkrtrGnc.Size = new System.Drawing.Size(120, 31);
            this.BtnSkrtrGnc.TabIndex = 3;
            this.BtnSkrtrGnc.Text = "Güncelle";
            this.BtnSkrtrGnc.UseVisualStyleBackColor = true;
            this.BtnSkrtrGnc.Click += new System.EventHandler(this.BtnSkrtrGnc_Click);
            // 
            // BtnSkrtrSil
            // 
            this.BtnSkrtrSil.Location = new System.Drawing.Point(134, 241);
            this.BtnSkrtrSil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnSkrtrSil.Name = "BtnSkrtrSil";
            this.BtnSkrtrSil.Size = new System.Drawing.Size(120, 31);
            this.BtnSkrtrSil.TabIndex = 4;
            this.BtnSkrtrSil.Text = "Sil";
            this.BtnSkrtrSil.UseVisualStyleBackColor = true;
            this.BtnSkrtrSil.Click += new System.EventHandler(this.BtnSkrtrSil_Click);
            // 
            // BtnSkrtrEkle
            // 
            this.BtnSkrtrEkle.Location = new System.Drawing.Point(134, 205);
            this.BtnSkrtrEkle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnSkrtrEkle.Name = "BtnSkrtrEkle";
            this.BtnSkrtrEkle.Size = new System.Drawing.Size(120, 31);
            this.BtnSkrtrEkle.TabIndex = 5;
            this.BtnSkrtrEkle.Text = "Ekle";
            this.BtnSkrtrEkle.UseVisualStyleBackColor = true;
            this.BtnSkrtrEkle.Click += new System.EventHandler(this.BtnSkrtrEkle_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(44, 57);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 22);
            this.label11.TabIndex = 16;
            this.label11.Text = "Ad:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 89);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 22);
            this.label10.TabIndex = 17;
            this.label10.Text = "Soyad:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 22);
            this.label5.TabIndex = 19;
            this.label5.Text = "T.C. No:";
            // 
            // TxtSkrtrSoyad
            // 
            this.TxtSkrtrSoyad.Location = new System.Drawing.Point(88, 86);
            this.TxtSkrtrSoyad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtSkrtrSoyad.Name = "TxtSkrtrSoyad";
            this.TxtSkrtrSoyad.Size = new System.Drawing.Size(120, 28);
            this.TxtSkrtrSoyad.TabIndex = 23;
            // 
            // TxtSkrtrTc
            // 
            this.TxtSkrtrTc.Location = new System.Drawing.Point(88, 120);
            this.TxtSkrtrTc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtSkrtrTc.Name = "TxtSkrtrTc";
            this.TxtSkrtrTc.Size = new System.Drawing.Size(120, 28);
            this.TxtSkrtrTc.TabIndex = 22;
            // 
            // TxtSkrtrAd
            // 
            this.TxtSkrtrAd.Location = new System.Drawing.Point(88, 55);
            this.TxtSkrtrAd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtSkrtrAd.Name = "TxtSkrtrAd";
            this.TxtSkrtrAd.Size = new System.Drawing.Size(120, 28);
            this.TxtSkrtrAd.TabIndex = 25;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TxtSkrtrAd);
            this.groupBox2.Controls.Add(this.TxtSkrtrTc);
            this.groupBox2.Controls.Add(this.TxtSkrtrSoyad);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.BtnSkrtrEkle);
            this.groupBox2.Controls.Add(this.BtnSkrtrSil);
            this.groupBox2.Controls.Add(this.BtnSkrtrGnc);
            this.groupBox2.Controls.Add(this.BtnSkrtrList);
            this.groupBox2.Location = new System.Drawing.Point(12, 11);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(348, 284);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sekreter Menüsü";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView2);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox4.Location = new System.Drawing.Point(366, 11);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(655, 284);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Sekreterler";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sekreterIDDataGridViewTextBoxColumn,
            this.sekreterAdDataGridViewTextBoxColumn,
            this.sekreterSoyadDataGridViewTextBoxColumn,
            this.sekreterTCDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.tblSekreterBindingSource1;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 17);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(649, 265);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellDoubleClick);
            // 
            // sekreterIDDataGridViewTextBoxColumn
            // 
            this.sekreterIDDataGridViewTextBoxColumn.DataPropertyName = "SekreterID";
            this.sekreterIDDataGridViewTextBoxColumn.HeaderText = "SekreterID";
            this.sekreterIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sekreterIDDataGridViewTextBoxColumn.Name = "sekreterIDDataGridViewTextBoxColumn";
            this.sekreterIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.sekreterIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // sekreterAdDataGridViewTextBoxColumn
            // 
            this.sekreterAdDataGridViewTextBoxColumn.DataPropertyName = "SekreterAd";
            this.sekreterAdDataGridViewTextBoxColumn.HeaderText = "SekreterAd";
            this.sekreterAdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sekreterAdDataGridViewTextBoxColumn.Name = "sekreterAdDataGridViewTextBoxColumn";
            this.sekreterAdDataGridViewTextBoxColumn.Width = 125;
            // 
            // sekreterSoyadDataGridViewTextBoxColumn
            // 
            this.sekreterSoyadDataGridViewTextBoxColumn.DataPropertyName = "SekreterSoyad";
            this.sekreterSoyadDataGridViewTextBoxColumn.HeaderText = "SekreterSoyad";
            this.sekreterSoyadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sekreterSoyadDataGridViewTextBoxColumn.Name = "sekreterSoyadDataGridViewTextBoxColumn";
            this.sekreterSoyadDataGridViewTextBoxColumn.Width = 125;
            // 
            // sekreterTCDataGridViewTextBoxColumn
            // 
            this.sekreterTCDataGridViewTextBoxColumn.DataPropertyName = "SekreterTC";
            this.sekreterTCDataGridViewTextBoxColumn.HeaderText = "SekreterTC";
            this.sekreterTCDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sekreterTCDataGridViewTextBoxColumn.Name = "sekreterTCDataGridViewTextBoxColumn";
            this.sekreterTCDataGridViewTextBoxColumn.Width = 125;
            // 
            // FrmPrsnlGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1039, 590);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmPrsnlGuncelle";
            this.Text = "FrmPrsnlGuncelle";
            this.Load += new System.EventHandler(this.FrmPrsnlGuncelle_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDoktorlarBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneProjeDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneProjeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDoktorlarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSekreterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSekreterBindingSource1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnDktrEkle;
        private System.Windows.Forms.Button BtnDktrSil;
        private System.Windows.Forms.Button BtnDktrGunc;
        private System.Windows.Forms.Button BtnDktrList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CmbDktrBrns;
        private System.Windows.Forms.TextBox TxtDktrSoyad;
        private System.Windows.Forms.TextBox TxtDktrAd;
        private System.Windows.Forms.TextBox TxtDktrTc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private HastaneProjeDataSet hastaneProjeDataSet;
        private System.Windows.Forms.BindingSource tblDoktorlarBindingSource;
        private HastaneProjeDataSetTableAdapters.Tbl_DoktorlarTableAdapter tbl_DoktorlarTableAdapter;
        private System.Windows.Forms.BindingSource tblSekreterBindingSource;
        private HastaneProjeDataSetTableAdapters.Tbl_SekreterTableAdapter tbl_SekreterTableAdapter;
        private HastaneProjeDataSet1 hastaneProjeDataSet1;
        private System.Windows.Forms.BindingSource tblDoktorlarBindingSource1;
        private HastaneProjeDataSet1TableAdapters.Tbl_DoktorlarTableAdapter tbl_DoktorlarTableAdapter1;
        private System.Windows.Forms.BindingSource tblSekreterBindingSource1;
        private HastaneProjeDataSet1TableAdapters.Tbl_SekreterTableAdapter tbl_SekreterTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn doktorIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doktorAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doktorSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doktorBransDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doktorTCDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button BtnSkrtrList;
        private System.Windows.Forms.Button BtnSkrtrGnc;
        private System.Windows.Forms.Button BtnSkrtrSil;
        private System.Windows.Forms.Button BtnSkrtrEkle;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtSkrtrSoyad;
        private System.Windows.Forms.TextBox TxtSkrtrTc;
        private System.Windows.Forms.TextBox TxtSkrtrAd;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn sekreterIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sekreterAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sekreterSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sekreterTCDataGridViewTextBoxColumn;
    }
}