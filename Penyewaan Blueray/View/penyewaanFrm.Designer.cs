namespace Penyewaan_Blueray.View
{
    partial class penyewaanFrm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_simpan = new System.Windows.Forms.Button();
            this.btn_hapus = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.dgv_sewa = new System.Windows.Forms.DataGridView();
            this._kd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._nm_pel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._judul = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._kd_pel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._kd_film = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._tgl_sewa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._lama_sewa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._tgl_kembali = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._biaya_sewa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._total_sewa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._tgl_pengembalian = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._denda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._keterlambatan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._total_denda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lb_kd = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lb_pelanggan = new System.Windows.Forms.Label();
            this.btn_pelanggan = new System.Windows.Forms.Button();
            this.dtp_sewa = new System.Windows.Forms.DateTimePicker();
            this.btn_film = new System.Windows.Forms.Button();
            this.lb_film = new System.Windows.Forms.Label();
            this.dtp_kembali = new System.Windows.Forms.DateTimePicker();
            this.lb_total = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.txt_lama = new System.Windows.Forms.TextBox();
            this.txt_biaya = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sewa)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 59F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.dgv_sewa, 0, 10);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label5, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.lb_kd, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label6, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.label7, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.lb_pelanggan, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn_pelanggan, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.dtp_sewa, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.btn_film, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lb_film, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.dtp_kembali, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.lb_total, 2, 7);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 2, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 11;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(509, 375);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel2, 4);
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33444F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33444F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33112F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.btn_simpan, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_hapus, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_clear, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 226);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(509, 28);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // btn_simpan
            // 
            this.btn_simpan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_simpan.Location = new System.Drawing.Point(3, 3);
            this.btn_simpan.Name = "btn_simpan";
            this.btn_simpan.Size = new System.Drawing.Size(163, 22);
            this.btn_simpan.TabIndex = 0;
            this.btn_simpan.Text = "SIMPAN";
            this.btn_simpan.UseVisualStyleBackColor = true;
            this.btn_simpan.Click += new System.EventHandler(this.btn_simpan_Click);
            // 
            // btn_hapus
            // 
            this.btn_hapus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_hapus.Location = new System.Drawing.Point(172, 3);
            this.btn_hapus.Name = "btn_hapus";
            this.btn_hapus.Size = new System.Drawing.Size(163, 22);
            this.btn_hapus.TabIndex = 2;
            this.btn_hapus.Text = "HAPUS";
            this.btn_hapus.UseVisualStyleBackColor = true;
            this.btn_hapus.Click += new System.EventHandler(this.btn_hapus_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_clear.Location = new System.Drawing.Point(341, 3);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(165, 22);
            this.btn_clear.TabIndex = 3;
            this.btn_clear.Text = "CLEAR";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // dgv_sewa
            // 
            this.dgv_sewa.AllowUserToAddRows = false;
            this.dgv_sewa.AllowUserToDeleteRows = false;
            this.dgv_sewa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_sewa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_sewa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._kd,
            this._nm_pel,
            this._judul,
            this._kd_pel,
            this._kd_film,
            this._tgl_sewa,
            this._lama_sewa,
            this._tgl_kembali,
            this._biaya_sewa,
            this._total_sewa,
            this._tgl_pengembalian,
            this._denda,
            this._keterlambatan,
            this._total_denda});
            this.tableLayoutPanel1.SetColumnSpan(this.dgv_sewa, 4);
            this.dgv_sewa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_sewa.Location = new System.Drawing.Point(0, 254);
            this.dgv_sewa.Margin = new System.Windows.Forms.Padding(0);
            this.dgv_sewa.Name = "dgv_sewa";
            this.dgv_sewa.ReadOnly = true;
            this.dgv_sewa.Size = new System.Drawing.Size(509, 121);
            this.dgv_sewa.TabIndex = 8;
            this.dgv_sewa.TabStop = false;
            this.dgv_sewa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_sewa_CellClick);
            // 
            // _kd
            // 
            this._kd.DataPropertyName = "kd";
            this._kd.HeaderText = "Kode";
            this._kd.Name = "_kd";
            this._kd.ReadOnly = true;
            this._kd.Width = 57;
            // 
            // _nm_pel
            // 
            this._nm_pel.DataPropertyName = "nm_pel";
            this._nm_pel.HeaderText = "Pelanggan";
            this._nm_pel.Name = "_nm_pel";
            this._nm_pel.ReadOnly = true;
            this._nm_pel.Width = 83;
            // 
            // _judul
            // 
            this._judul.DataPropertyName = "judul";
            this._judul.HeaderText = "Judul";
            this._judul.Name = "_judul";
            this._judul.ReadOnly = true;
            this._judul.Width = 57;
            // 
            // _kd_pel
            // 
            this._kd_pel.DataPropertyName = "kd_pel";
            this._kd_pel.HeaderText = "Kd. Pel";
            this._kd_pel.Name = "_kd_pel";
            this._kd_pel.ReadOnly = true;
            this._kd_pel.Visible = false;
            this._kd_pel.Width = 66;
            // 
            // _kd_film
            // 
            this._kd_film.DataPropertyName = "kd_film";
            this._kd_film.HeaderText = "Kd. Film";
            this._kd_film.Name = "_kd_film";
            this._kd_film.ReadOnly = true;
            this._kd_film.Visible = false;
            this._kd_film.Width = 69;
            // 
            // _tgl_sewa
            // 
            this._tgl_sewa.DataPropertyName = "tgl_sewa";
            this._tgl_sewa.HeaderText = "Tgl. Sewa";
            this._tgl_sewa.Name = "_tgl_sewa";
            this._tgl_sewa.ReadOnly = true;
            this._tgl_sewa.Width = 80;
            // 
            // _lama_sewa
            // 
            this._lama_sewa.DataPropertyName = "lama_sewa";
            this._lama_sewa.HeaderText = "Lama Sewa";
            this._lama_sewa.Name = "_lama_sewa";
            this._lama_sewa.ReadOnly = true;
            this._lama_sewa.Width = 88;
            // 
            // _tgl_kembali
            // 
            this._tgl_kembali.DataPropertyName = "tgl_kembali";
            this._tgl_kembali.HeaderText = "Tgl. Kembali";
            this._tgl_kembali.Name = "_tgl_kembali";
            this._tgl_kembali.ReadOnly = true;
            this._tgl_kembali.Width = 90;
            // 
            // _biaya_sewa
            // 
            this._biaya_sewa.DataPropertyName = "biaya_sewa";
            this._biaya_sewa.HeaderText = "Biaya Sewa";
            this._biaya_sewa.Name = "_biaya_sewa";
            this._biaya_sewa.ReadOnly = true;
            this._biaya_sewa.Width = 88;
            // 
            // _total_sewa
            // 
            this._total_sewa.DataPropertyName = "total_sewa";
            this._total_sewa.HeaderText = "Total Sewa";
            this._total_sewa.Name = "_total_sewa";
            this._total_sewa.ReadOnly = true;
            this._total_sewa.Width = 86;
            // 
            // _tgl_pengembalian
            // 
            this._tgl_pengembalian.DataPropertyName = "tgl_pengembalian";
            this._tgl_pengembalian.HeaderText = "Tgl. Pengem";
            this._tgl_pengembalian.Name = "_tgl_pengembalian";
            this._tgl_pengembalian.ReadOnly = true;
            this._tgl_pengembalian.Visible = false;
            this._tgl_pengembalian.Width = 92;
            // 
            // _denda
            // 
            this._denda.DataPropertyName = "denda";
            this._denda.HeaderText = "Denda";
            this._denda.Name = "_denda";
            this._denda.ReadOnly = true;
            this._denda.Visible = false;
            this._denda.Width = 64;
            // 
            // _keterlambatan
            // 
            this._keterlambatan.DataPropertyName = "keterlambatan";
            this._keterlambatan.HeaderText = "Keterlambatan";
            this._keterlambatan.Name = "_keterlambatan";
            this._keterlambatan.ReadOnly = true;
            this._keterlambatan.Visible = false;
            // 
            // _total_denda
            // 
            this._total_denda.DataPropertyName = "total_denda";
            this._total_denda.HeaderText = "Total Denda";
            this._total_denda.Name = "_total_denda";
            this._total_denda.ReadOnly = true;
            this._total_denda.Visible = false;
            this._total_denda.Width = 91;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(53, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 28);
            this.label1.TabIndex = 7;
            this.label1.Text = "Kode";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(53, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 28);
            this.label4.TabIndex = 10;
            this.label4.Text = "Tgl. Sewa";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(53, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 28);
            this.label5.TabIndex = 11;
            this.label5.Text = "Lama Sewa, Biaya";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lb_kd
            // 
            this.lb_kd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lb_kd.AutoSize = true;
            this.lb_kd.Location = new System.Drawing.Point(173, 15);
            this.lb_kd.Name = "lb_kd";
            this.lb_kd.Size = new System.Drawing.Size(16, 28);
            this.lb_kd.TabIndex = 13;
            this.lb_kd.Text = "...";
            this.lb_kd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(53, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 28);
            this.label6.TabIndex = 15;
            this.label6.Text = "Tgl. Kembali";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(53, 183);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 28);
            this.label7.TabIndex = 16;
            this.label7.Text = "Total Biaya";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lb_pelanggan
            // 
            this.lb_pelanggan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lb_pelanggan.AutoSize = true;
            this.lb_pelanggan.Location = new System.Drawing.Point(173, 43);
            this.lb_pelanggan.Name = "lb_pelanggan";
            this.lb_pelanggan.Size = new System.Drawing.Size(16, 28);
            this.lb_pelanggan.TabIndex = 17;
            this.lb_pelanggan.Text = "...";
            this.lb_pelanggan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_pelanggan
            // 
            this.btn_pelanggan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_pelanggan.Location = new System.Drawing.Point(53, 46);
            this.btn_pelanggan.Name = "btn_pelanggan";
            this.btn_pelanggan.Size = new System.Drawing.Size(114, 22);
            this.btn_pelanggan.TabIndex = 0;
            this.btn_pelanggan.Text = "Pelanggan";
            this.btn_pelanggan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_pelanggan.UseVisualStyleBackColor = true;
            this.btn_pelanggan.Click += new System.EventHandler(this.btn_pelanggan_Click);
            // 
            // dtp_sewa
            // 
            this.dtp_sewa.CustomFormat = "dddd, d MMMM yyyy";
            this.dtp_sewa.Enabled = false;
            this.dtp_sewa.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_sewa.Location = new System.Drawing.Point(173, 102);
            this.dtp_sewa.Name = "dtp_sewa";
            this.dtp_sewa.Size = new System.Drawing.Size(200, 20);
            this.dtp_sewa.TabIndex = 2;
            // 
            // btn_film
            // 
            this.btn_film.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_film.Location = new System.Drawing.Point(53, 74);
            this.btn_film.Name = "btn_film";
            this.btn_film.Size = new System.Drawing.Size(114, 22);
            this.btn_film.TabIndex = 1;
            this.btn_film.Text = "Film";
            this.btn_film.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_film.UseVisualStyleBackColor = true;
            this.btn_film.Click += new System.EventHandler(this.btn_film_Click);
            // 
            // lb_film
            // 
            this.lb_film.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lb_film.AutoSize = true;
            this.lb_film.Location = new System.Drawing.Point(173, 71);
            this.lb_film.Name = "lb_film";
            this.lb_film.Size = new System.Drawing.Size(16, 28);
            this.lb_film.TabIndex = 20;
            this.lb_film.Text = "...";
            this.lb_film.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtp_kembali
            // 
            this.dtp_kembali.CustomFormat = "dddd, d MMMM yyyy";
            this.dtp_kembali.Enabled = false;
            this.dtp_kembali.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_kembali.Location = new System.Drawing.Point(173, 158);
            this.dtp_kembali.Name = "dtp_kembali";
            this.dtp_kembali.Size = new System.Drawing.Size(200, 20);
            this.dtp_kembali.TabIndex = 4;
            // 
            // lb_total
            // 
            this.lb_total.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lb_total.AutoSize = true;
            this.lb_total.Location = new System.Drawing.Point(173, 183);
            this.lb_total.Name = "lb_total";
            this.lb_total.Size = new System.Drawing.Size(16, 28);
            this.lb_total.TabIndex = 23;
            this.lb_total.Text = "...";
            this.lb_total.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.57747F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.42254F));
            this.tableLayoutPanel3.Controls.Add(this.txt_lama, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.txt_biaya, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(170, 127);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(280, 28);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // txt_lama
            // 
            this.txt_lama.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_lama.Location = new System.Drawing.Point(3, 3);
            this.txt_lama.Name = "txt_lama";
            this.txt_lama.Size = new System.Drawing.Size(76, 20);
            this.txt_lama.TabIndex = 0;
            this.txt_lama.TextChanged += new System.EventHandler(this.txt_lama_TextChanged);
            // 
            // txt_biaya
            // 
            this.txt_biaya.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_biaya.Location = new System.Drawing.Point(85, 3);
            this.txt_biaya.Name = "txt_biaya";
            this.txt_biaya.Size = new System.Drawing.Size(192, 20);
            this.txt_biaya.TabIndex = 1;
            this.txt_biaya.TextChanged += new System.EventHandler(this.txt_biaya_TextChanged);
            // 
            // penyewaanFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 375);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "penyewaanFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PENYEWAAN";
            this.Load += new System.EventHandler(this.penyewaanFrm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sewa)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btn_simpan;
        private System.Windows.Forms.Button btn_hapus;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.DataGridView dgv_sewa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lb_kd;
        private System.Windows.Forms.DateTimePicker dtp_sewa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_pelanggan;
        private System.Windows.Forms.Button btn_film;
        private System.Windows.Forms.DateTimePicker dtp_kembali;
        private System.Windows.Forms.Label lb_total;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TextBox txt_lama;
        private System.Windows.Forms.TextBox txt_biaya;
        private System.Windows.Forms.DataGridViewTextBoxColumn _kd;
        private System.Windows.Forms.DataGridViewTextBoxColumn _nm_pel;
        private System.Windows.Forms.DataGridViewTextBoxColumn _judul;
        private System.Windows.Forms.DataGridViewTextBoxColumn _kd_pel;
        private System.Windows.Forms.DataGridViewTextBoxColumn _kd_film;
        private System.Windows.Forms.DataGridViewTextBoxColumn _tgl_sewa;
        private System.Windows.Forms.DataGridViewTextBoxColumn _lama_sewa;
        private System.Windows.Forms.DataGridViewTextBoxColumn _tgl_kembali;
        private System.Windows.Forms.DataGridViewTextBoxColumn _biaya_sewa;
        private System.Windows.Forms.DataGridViewTextBoxColumn _total_sewa;
        private System.Windows.Forms.DataGridViewTextBoxColumn _tgl_pengembalian;
        private System.Windows.Forms.DataGridViewTextBoxColumn _denda;
        private System.Windows.Forms.DataGridViewTextBoxColumn _keterlambatan;
        private System.Windows.Forms.DataGridViewTextBoxColumn _total_denda;
        public System.Windows.Forms.Label lb_pelanggan;
        public System.Windows.Forms.Label lb_film;
    }
}