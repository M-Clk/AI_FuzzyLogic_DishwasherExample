namespace AI_Fuzzy_Logic
{
    partial class Form1
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
            if(disposing && (components != null))
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panelGirisler = new System.Windows.Forms.TableLayoutPanel();
            this.lblKirlilik = new System.Windows.Forms.Label();
            this.lblHassaslik = new System.Windows.Forms.Label();
            this.lblKirlilikEtiket = new System.Windows.Forms.Label();
            this.lblHassaslikEtiket = new System.Windows.Forms.Label();
            this.lblMiktarEtiket = new System.Windows.Forms.Label();
            this.numHassaslik = new System.Windows.Forms.NumericUpDown();
            this.numMiktar = new System.Windows.Forms.NumericUpDown();
            this.numKirlilik = new System.Windows.Forms.NumericUpDown();
            this.lblMiktar = new System.Windows.Forms.Label();
            this.lbMamdani = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblDeterjanSozelSonuc = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDeterjanAgirlikliOrtalama = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lblSureSozelSonuc = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblSureAgirlikliOrtalama = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.lblDonusHiziSozelSonuc = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblDonusHiziAgirlikliOrtalama = new System.Windows.Forms.Label();
            this.dgKuralTabani = new System.Windows.Forms.DataGridView();
            this.Hassaslik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Miktar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kirlilik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Deterjan_Miktari = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Donus_Hizi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1.SuspendLayout();
            this.panelGirisler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numHassaslik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMiktar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numKirlilik)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgKuralTabani)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panelGirisler);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(420, 164);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Giris Degerleri";
            // 
            // panelGirisler
            // 
            this.panelGirisler.ColumnCount = 3;
            this.panelGirisler.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.74892F));
            this.panelGirisler.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.36797F));
            this.panelGirisler.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.88312F));
            this.panelGirisler.Controls.Add(this.lblKirlilik, 2, 2);
            this.panelGirisler.Controls.Add(this.lblHassaslik, 2, 0);
            this.panelGirisler.Controls.Add(this.lblKirlilikEtiket, 0, 2);
            this.panelGirisler.Controls.Add(this.lblHassaslikEtiket, 0, 0);
            this.panelGirisler.Controls.Add(this.lblMiktarEtiket, 0, 1);
            this.panelGirisler.Controls.Add(this.numHassaslik, 1, 0);
            this.panelGirisler.Controls.Add(this.numMiktar, 1, 1);
            this.panelGirisler.Controls.Add(this.numKirlilik, 1, 2);
            this.panelGirisler.Controls.Add(this.lblMiktar, 2, 1);
            this.panelGirisler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGirisler.Location = new System.Drawing.Point(3, 16);
            this.panelGirisler.Name = "panelGirisler";
            this.panelGirisler.RowCount = 3;
            this.panelGirisler.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.panelGirisler.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.panelGirisler.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.panelGirisler.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panelGirisler.Size = new System.Drawing.Size(414, 145);
            this.panelGirisler.TabIndex = 3;
            // 
            // lblKirlilik
            // 
            this.lblKirlilik.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblKirlilik.AutoSize = true;
            this.lblKirlilik.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.lblKirlilik.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblKirlilik.Location = new System.Drawing.Point(139, 114);
            this.lblKirlilik.Name = "lblKirlilik";
            this.lblKirlilik.Size = new System.Drawing.Size(272, 13);
            this.lblKirlilik.TabIndex = 10;
            this.lblKirlilik.Text = "0 (Silinecek:Kucuk-Orta-Buyuk)";
            // 
            // lblHassaslik
            // 
            this.lblHassaslik.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHassaslik.AutoSize = true;
            this.lblHassaslik.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.lblHassaslik.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblHassaslik.Location = new System.Drawing.Point(139, 17);
            this.lblHassaslik.Name = "lblHassaslik";
            this.lblHassaslik.Size = new System.Drawing.Size(272, 13);
            this.lblHassaslik.TabIndex = 8;
            this.lblHassaslik.Text = "0 (Silinecek:Saglam-Orta-Hassas)";
            // 
            // lblKirlilikEtiket
            // 
            this.lblKirlilikEtiket.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblKirlilikEtiket.AutoSize = true;
            this.lblKirlilikEtiket.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.lblKirlilikEtiket.Location = new System.Drawing.Point(3, 114);
            this.lblKirlilikEtiket.Name = "lblKirlilikEtiket";
            this.lblKirlilikEtiket.Size = new System.Drawing.Size(67, 13);
            this.lblKirlilikEtiket.TabIndex = 4;
            this.lblKirlilikEtiket.Text = "Kirlilik";
            // 
            // lblHassaslikEtiket
            // 
            this.lblHassaslikEtiket.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHassaslikEtiket.AutoSize = true;
            this.lblHassaslikEtiket.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.lblHassaslikEtiket.Location = new System.Drawing.Point(3, 17);
            this.lblHassaslikEtiket.Name = "lblHassaslikEtiket";
            this.lblHassaslikEtiket.Size = new System.Drawing.Size(67, 13);
            this.lblHassaslikEtiket.TabIndex = 1;
            this.lblHassaslikEtiket.Text = "Hassaslık";
            // 
            // lblMiktarEtiket
            // 
            this.lblMiktarEtiket.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMiktarEtiket.AutoSize = true;
            this.lblMiktarEtiket.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.lblMiktarEtiket.Location = new System.Drawing.Point(3, 65);
            this.lblMiktarEtiket.Name = "lblMiktarEtiket";
            this.lblMiktarEtiket.Size = new System.Drawing.Size(67, 13);
            this.lblMiktarEtiket.TabIndex = 3;
            this.lblMiktarEtiket.Text = "Miktar";
            // 
            // numHassaslik
            // 
            this.numHassaslik.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.numHassaslik.DecimalPlaces = 2;
            this.numHassaslik.Location = new System.Drawing.Point(76, 14);
            this.numHassaslik.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numHassaslik.Name = "numHassaslik";
            this.numHassaslik.Size = new System.Drawing.Size(57, 20);
            this.numHassaslik.TabIndex = 5;
            this.numHassaslik.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
            // 
            // numMiktar
            // 
            this.numMiktar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.numMiktar.DecimalPlaces = 2;
            this.numMiktar.Location = new System.Drawing.Point(76, 62);
            this.numMiktar.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numMiktar.Name = "numMiktar";
            this.numMiktar.Size = new System.Drawing.Size(57, 20);
            this.numMiktar.TabIndex = 6;
            this.numMiktar.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
            // 
            // numKirlilik
            // 
            this.numKirlilik.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.numKirlilik.DecimalPlaces = 2;
            this.numKirlilik.Location = new System.Drawing.Point(76, 110);
            this.numKirlilik.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numKirlilik.Name = "numKirlilik";
            this.numKirlilik.Size = new System.Drawing.Size(57, 20);
            this.numKirlilik.TabIndex = 7;
            this.numKirlilik.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
            // 
            // lblMiktar
            // 
            this.lblMiktar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMiktar.AutoSize = true;
            this.lblMiktar.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.lblMiktar.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblMiktar.Location = new System.Drawing.Point(139, 65);
            this.lblMiktar.Name = "lblMiktar";
            this.lblMiktar.Size = new System.Drawing.Size(272, 13);
            this.lblMiktar.TabIndex = 9;
            this.lblMiktar.Text = "0 (Silinecek:Kucuk-Orta-Buyuk)";
            // 
            // lbMamdani
            // 
            this.lbMamdani.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbMamdani.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbMamdani.FormattingEnabled = true;
            this.lbMamdani.Location = new System.Drawing.Point(3, 20);
            this.lbMamdani.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.lbMamdani.Name = "lbMamdani";
            this.lbMamdani.Size = new System.Drawing.Size(100, 440);
            this.lbMamdani.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(278, 106);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Deterjan Miktari - Cikis Degerleri";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lblDeterjanSozelSonuc, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblDeterjanAgirlikliOrtalama, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(272, 87);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // lblDeterjanSozelSonuc
            // 
            this.lblDeterjanSozelSonuc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDeterjanSozelSonuc.AutoSize = true;
            this.lblDeterjanSozelSonuc.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.lblDeterjanSozelSonuc.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblDeterjanSozelSonuc.Location = new System.Drawing.Point(139, 58);
            this.lblDeterjanSozelSonuc.Name = "lblDeterjanSozelSonuc";
            this.lblDeterjanSozelSonuc.Size = new System.Drawing.Size(130, 13);
            this.lblDeterjanSozelSonuc.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(3, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sozel Sonuc";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(3, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Agirlikli Ortalama";
            // 
            // lblDeterjanAgirlikliOrtalama
            // 
            this.lblDeterjanAgirlikliOrtalama.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDeterjanAgirlikliOrtalama.AutoSize = true;
            this.lblDeterjanAgirlikliOrtalama.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.lblDeterjanAgirlikliOrtalama.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblDeterjanAgirlikliOrtalama.Location = new System.Drawing.Point(139, 15);
            this.lblDeterjanAgirlikliOrtalama.Name = "lblDeterjanAgirlikliOrtalama";
            this.lblDeterjanAgirlikliOrtalama.Size = new System.Drawing.Size(130, 13);
            this.lblDeterjanAgirlikliOrtalama.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tableLayoutPanel3);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(287, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(278, 106);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sure - Cikis Degerleri";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.lblSureSozelSonuc, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.label10, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label11, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.lblSureAgirlikliOrtalama, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(272, 87);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // lblSureSozelSonuc
            // 
            this.lblSureSozelSonuc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSureSozelSonuc.AutoSize = true;
            this.lblSureSozelSonuc.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.lblSureSozelSonuc.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblSureSozelSonuc.Location = new System.Drawing.Point(139, 58);
            this.lblSureSozelSonuc.Name = "lblSureSozelSonuc";
            this.lblSureSozelSonuc.Size = new System.Drawing.Size(130, 13);
            this.lblSureSozelSonuc.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(3, 58);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(130, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Sozel Sonuc";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(3, 15);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(130, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Agirlikli Ortalama";
            // 
            // lblSureAgirlikliOrtalama
            // 
            this.lblSureAgirlikliOrtalama.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSureAgirlikliOrtalama.AutoSize = true;
            this.lblSureAgirlikliOrtalama.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.lblSureAgirlikliOrtalama.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblSureAgirlikliOrtalama.Location = new System.Drawing.Point(139, 15);
            this.lblSureAgirlikliOrtalama.Name = "lblSureAgirlikliOrtalama";
            this.lblSureAgirlikliOrtalama.Size = new System.Drawing.Size(130, 13);
            this.lblSureAgirlikliOrtalama.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tableLayoutPanel4);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(571, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(279, 106);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Donus Hizi - Cikis Degerleri";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.lblDonusHiziSozelSonuc, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.label14, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.label15, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.lblDonusHiziAgirlikliOrtalama, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(273, 87);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // lblDonusHiziSozelSonuc
            // 
            this.lblDonusHiziSozelSonuc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDonusHiziSozelSonuc.AutoSize = true;
            this.lblDonusHiziSozelSonuc.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.lblDonusHiziSozelSonuc.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblDonusHiziSozelSonuc.Location = new System.Drawing.Point(139, 58);
            this.lblDonusHiziSozelSonuc.Name = "lblDonusHiziSozelSonuc";
            this.lblDonusHiziSozelSonuc.Size = new System.Drawing.Size(131, 13);
            this.lblDonusHiziSozelSonuc.TabIndex = 2;
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label14.Location = new System.Drawing.Point(3, 58);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(130, 13);
            this.label14.TabIndex = 3;
            this.label14.Text = "Sozel Sonuc";
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label15.Location = new System.Drawing.Point(3, 15);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(130, 13);
            this.label15.TabIndex = 1;
            this.label15.Text = "Agirlikli Ortalama";
            // 
            // lblDonusHiziAgirlikliOrtalama
            // 
            this.lblDonusHiziAgirlikliOrtalama.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDonusHiziAgirlikliOrtalama.AutoSize = true;
            this.lblDonusHiziAgirlikliOrtalama.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.lblDonusHiziAgirlikliOrtalama.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblDonusHiziAgirlikliOrtalama.Location = new System.Drawing.Point(139, 15);
            this.lblDonusHiziAgirlikliOrtalama.Name = "lblDonusHiziAgirlikliOrtalama";
            this.lblDonusHiziAgirlikliOrtalama.Size = new System.Drawing.Size(131, 13);
            this.lblDonusHiziAgirlikliOrtalama.TabIndex = 0;
            // 
            // dgKuralTabani
            // 
            this.dgKuralTabani.AllowUserToAddRows = false;
            this.dgKuralTabani.AllowUserToDeleteRows = false;
            this.dgKuralTabani.AllowUserToResizeRows = false;
            this.dgKuralTabani.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgKuralTabani.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgKuralTabani.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgKuralTabani.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Hassaslik,
            this.Miktar,
            this.Kirlilik,
            this.Deterjan_Miktari,
            this.Sure,
            this.Donus_Hizi});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgKuralTabani.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgKuralTabani.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgKuralTabani.Location = new System.Drawing.Point(109, 3);
            this.dgKuralTabani.MultiSelect = false;
            this.dgKuralTabani.Name = "dgKuralTabani";
            this.dgKuralTabani.ReadOnly = true;
            this.dgKuralTabani.RowHeadersVisible = false;
            this.dgKuralTabani.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.tableLayoutPanel6.SetRowSpan(this.dgKuralTabani, 2);
            this.dgKuralTabani.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgKuralTabani.Size = new System.Drawing.Size(741, 457);
            this.dgKuralTabani.TabIndex = 4;
            // 
            // Hassaslik
            // 
            this.Hassaslik.HeaderText = "Hassaslık";
            this.Hassaslik.Name = "Hassaslik";
            this.Hassaslik.ReadOnly = true;
            this.Hassaslik.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Miktar
            // 
            this.Miktar.HeaderText = "Miktar";
            this.Miktar.Name = "Miktar";
            this.Miktar.ReadOnly = true;
            this.Miktar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Kirlilik
            // 
            this.Kirlilik.HeaderText = "Kirlilik";
            this.Kirlilik.Name = "Kirlilik";
            this.Kirlilik.ReadOnly = true;
            this.Kirlilik.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Deterjan_Miktari
            // 
            this.Deterjan_Miktari.HeaderText = "Deterjan Miktarı";
            this.Deterjan_Miktari.Name = "Deterjan_Miktari";
            this.Deterjan_Miktari.ReadOnly = true;
            this.Deterjan_Miktari.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Sure
            // 
            this.Sure.HeaderText = "Süre";
            this.Sure.Name = "Sure";
            this.Sure.ReadOnly = true;
            this.Sure.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Donus_Hizi
            // 
            this.Donus_Hizi.HeaderText = "Dönüş Hızı";
            this.Donus_Hizi.Name = "Donus_Hizi";
            this.Donus_Hizi.ReadOnly = true;
            this.Donus_Hizi.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.ForestGreen;
            this.label3.Location = new System.Drawing.Point(429, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(421, 170);
            this.label3.TabIndex = 9;
            this.label3.Text = "Designed By Muhammed CELIK";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel7, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel6, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.17961F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 61.65049F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.29126F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(859, 763);
            this.tableLayoutPanel2.TabIndex = 10;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 3;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel7.Controls.Add(this.groupBox2, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.groupBox4, 2, 0);
            this.tableLayoutPanel7.Controls.Add(this.groupBox3, 1, 0);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(3, 648);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 112F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(853, 112);
            this.tableLayoutPanel7.TabIndex = 11;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.47401F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 87.52599F));
            this.tableLayoutPanel6.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.lbMamdani, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.dgKuralTabani, 1, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 179);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(853, 463);
            this.tableLayoutPanel6.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Window;
            this.label6.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label6.Location = new System.Drawing.Point(0, 3);
            this.label6.Margin = new System.Windows.Forms.Padding(0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Mamdani";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.label3, 1, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 170F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(853, 170);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 763);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bulanik Mantik";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            this.panelGirisler.ResumeLayout(false);
            this.panelGirisler.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numHassaslik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMiktar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numKirlilik)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgKuralTabani)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lbMamdani;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDeterjanSozelSonuc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDeterjanAgirlikliOrtalama;
        private System.Windows.Forms.TableLayoutPanel panelGirisler;
        private System.Windows.Forms.Label lblKirlilikEtiket;
        private System.Windows.Forms.Label lblHassaslikEtiket;
        private System.Windows.Forms.Label lblMiktarEtiket;
        private System.Windows.Forms.NumericUpDown numHassaslik;
        private System.Windows.Forms.NumericUpDown numMiktar;
        private System.Windows.Forms.NumericUpDown numKirlilik;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblKirlilik;
        private System.Windows.Forms.Label lblMiktar;
        private System.Windows.Forms.Label lblHassaslik;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label lblSureSozelSonuc;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblSureAgirlikliOrtalama;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label lblDonusHiziSozelSonuc;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblDonusHiziAgirlikliOrtalama;
        private System.Windows.Forms.DataGridView dgKuralTabani;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hassaslik;
        private System.Windows.Forms.DataGridViewTextBoxColumn Miktar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kirlilik;
        private System.Windows.Forms.DataGridViewTextBoxColumn Deterjan_Miktari;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sure;
        private System.Windows.Forms.DataGridViewTextBoxColumn Donus_Hizi;
    }
}

