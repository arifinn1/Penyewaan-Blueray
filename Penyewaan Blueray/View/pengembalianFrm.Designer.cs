namespace Penyewaan_Blueray.View
{
    partial class pengembalianFrm
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
            this.lb_total_denda = new System.Windows.Forms.Label();
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
            this.lb_kd = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.lb_film = new System.Windows.Forms.Label();
            this.lb_pel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtp_sewa = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lb_biaya_sewa = new System.Windows.Forms.Label();
            this.lb_lama_sewa = new System.Windows.Forms.Label();
            this.dtp_kembali = new System.Windows.Forms.DateTimePicker();
            this.lb_total_sewa = new System.Windows.Forms.Label();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.lb_telat = new System.Windows.Forms.Label();
            this.txt_denda = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dtp_pengem = new System.Windows.Forms.DateTimePicker();
            this.btn_simpan = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sewa)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 105F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tableLayoutPanel1.Controls.Add(this.lb_total_denda, 2, 9);
            this.tableLayoutPanel1.Controls.Add(this.dgv_sewa, 0, 12);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lb_kd, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label6, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label7, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.dtp_sewa, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.dtp_kembali, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.lb_total_sewa, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel5, 2, 8);
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.label8, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.label9, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.dtp_pengem, 2, 7);
            this.tableLayoutPanel1.Controls.Add(this.btn_simpan, 0, 11);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 13;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(604, 442);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // lb_total_denda
            // 
            this.lb_total_denda.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lb_total_denda.AutoSize = true;
            this.lb_total_denda.Location = new System.Drawing.Point(158, 239);
            this.lb_total_denda.Name = "lb_total_denda";
            this.lb_total_denda.Size = new System.Drawing.Size(16, 28);
            this.lb_total_denda.TabIndex = 33;
            this.lb_total_denda.Text = "...";
            this.lb_total_denda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.dgv_sewa.Location = new System.Drawing.Point(0, 310);
            this.dgv_sewa.Margin = new System.Windows.Forms.Padding(0);
            this.dgv_sewa.Name = "dgv_sewa";
            this.dgv_sewa.ReadOnly = true;
            this.dgv_sewa.Size = new System.Drawing.Size(604, 132);
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
            this._tgl_pengembalian.Width = 92;
            // 
            // _denda
            // 
            this._denda.DataPropertyName = "denda";
            this._denda.HeaderText = "Denda";
            this._denda.Name = "_denda";
            this._denda.ReadOnly = true;
            this._denda.Width = 64;
            // 
            // _keterlambatan
            // 
            this._keterlambatan.DataPropertyName = "keterlambatan";
            this._keterlambatan.HeaderText = "Keterlambatan";
            this._keterlambatan.Name = "_keterlambatan";
            this._keterlambatan.ReadOnly = true;
            // 
            // _total_denda
            // 
            this._total_denda.DataPropertyName = "total_denda";
            this._total_denda.HeaderText = "Total Denda";
            this._total_denda.Name = "_total_denda";
            this._total_denda.ReadOnly = true;
            this._total_denda.Width = 91;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(53, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 28);
            this.label1.TabIndex = 7;
            this.label1.Text = "Kode";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lb_kd
            // 
            this.lb_kd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lb_kd.AutoSize = true;
            this.lb_kd.Location = new System.Drawing.Point(158, 15);
            this.lb_kd.Name = "lb_kd";
            this.lb_kd.Size = new System.Drawing.Size(16, 28);
            this.lb_kd.TabIndex = 13;
            this.lb_kd.Text = "...";
            this.lb_kd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 28);
            this.label2.TabIndex = 24;
            this.label2.Text = "Pelanggan, Film";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.57747F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.42254F));
            this.tableLayoutPanel4.Controls.Add(this.lb_film, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.lb_pel, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(155, 43);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(393, 28);
            this.tableLayoutPanel4.TabIndex = 26;
            this.tableLayoutPanel4.TabStop = true;
            // 
            // lb_film
            // 
            this.lb_film.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lb_film.AutoSize = true;
            this.lb_film.Location = new System.Drawing.Point(119, 0);
            this.lb_film.Name = "lb_film";
            this.lb_film.Size = new System.Drawing.Size(16, 28);
            this.lb_film.TabIndex = 15;
            this.lb_film.Text = "...";
            this.lb_film.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_pel
            // 
            this.lb_pel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lb_pel.AutoSize = true;
            this.lb_pel.Location = new System.Drawing.Point(3, 0);
            this.lb_pel.Name = "lb_pel";
            this.lb_pel.Size = new System.Drawing.Size(16, 28);
            this.lb_pel.TabIndex = 14;
            this.lb_pel.Text = "...";
            this.lb_pel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(97, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 28);
            this.label4.TabIndex = 10;
            this.label4.Text = "Tgl. Sewa";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 28);
            this.label5.TabIndex = 11;
            this.label5.Text = "Lama Sewa, Biaya";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(87, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 28);
            this.label6.TabIndex = 15;
            this.label6.Text = "Tgl. Kembali";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(91, 155);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 28);
            this.label7.TabIndex = 16;
            this.label7.Text = "Total Sewa";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtp_sewa
            // 
            this.dtp_sewa.CustomFormat = "dddd, d MMMM yyyy";
            this.dtp_sewa.Enabled = false;
            this.dtp_sewa.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_sewa.Location = new System.Drawing.Point(158, 74);
            this.dtp_sewa.Name = "dtp_sewa";
            this.dtp_sewa.Size = new System.Drawing.Size(200, 20);
            this.dtp_sewa.TabIndex = 2;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.57747F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.42254F));
            this.tableLayoutPanel3.Controls.Add(this.lb_biaya_sewa, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.lb_lama_sewa, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(155, 99);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(393, 28);
            this.tableLayoutPanel3.TabIndex = 2;
            this.tableLayoutPanel3.TabStop = true;
            // 
            // lb_biaya_sewa
            // 
            this.lb_biaya_sewa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lb_biaya_sewa.AutoSize = true;
            this.lb_biaya_sewa.Location = new System.Drawing.Point(119, 0);
            this.lb_biaya_sewa.Name = "lb_biaya_sewa";
            this.lb_biaya_sewa.Size = new System.Drawing.Size(16, 28);
            this.lb_biaya_sewa.TabIndex = 15;
            this.lb_biaya_sewa.Text = "...";
            this.lb_biaya_sewa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_lama_sewa
            // 
            this.lb_lama_sewa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lb_lama_sewa.AutoSize = true;
            this.lb_lama_sewa.Location = new System.Drawing.Point(3, 0);
            this.lb_lama_sewa.Name = "lb_lama_sewa";
            this.lb_lama_sewa.Size = new System.Drawing.Size(16, 28);
            this.lb_lama_sewa.TabIndex = 14;
            this.lb_lama_sewa.Text = "...";
            this.lb_lama_sewa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtp_kembali
            // 
            this.dtp_kembali.CustomFormat = "dddd, d MMMM yyyy";
            this.dtp_kembali.Enabled = false;
            this.dtp_kembali.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_kembali.Location = new System.Drawing.Point(158, 130);
            this.dtp_kembali.Name = "dtp_kembali";
            this.dtp_kembali.Size = new System.Drawing.Size(200, 20);
            this.dtp_kembali.TabIndex = 4;
            // 
            // lb_total_sewa
            // 
            this.lb_total_sewa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lb_total_sewa.AutoSize = true;
            this.lb_total_sewa.Location = new System.Drawing.Point(158, 155);
            this.lb_total_sewa.Name = "lb_total_sewa";
            this.lb_total_sewa.Size = new System.Drawing.Size(16, 28);
            this.lb_total_sewa.TabIndex = 23;
            this.lb_total_sewa.Text = "...";
            this.lb_total_sewa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.57747F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.42254F));
            this.tableLayoutPanel5.Controls.Add(this.lb_telat, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.txt_denda, 1, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(155, 211);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(393, 28);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // lb_telat
            // 
            this.lb_telat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lb_telat.AutoSize = true;
            this.lb_telat.Location = new System.Drawing.Point(3, 0);
            this.lb_telat.Name = "lb_telat";
            this.lb_telat.Size = new System.Drawing.Size(16, 28);
            this.lb_telat.TabIndex = 32;
            this.lb_telat.Text = "...";
            this.lb_telat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_denda
            // 
            this.txt_denda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_denda.Location = new System.Drawing.Point(119, 3);
            this.txt_denda.Name = "txt_denda";
            this.txt_denda.Size = new System.Drawing.Size(271, 20);
            this.txt_denda.TabIndex = 0;
            this.txt_denda.TextChanged += new System.EventHandler(this.txt_denda_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 28);
            this.label3.TabIndex = 28;
            this.label3.Text = "Tgl. Pengem";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(83, 211);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 28);
            this.label8.TabIndex = 29;
            this.label8.Text = "Telat, Denda";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(86, 239);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 28);
            this.label9.TabIndex = 30;
            this.label9.Text = "Total Denda";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtp_pengem
            // 
            this.dtp_pengem.CustomFormat = "dddd, d MMMM yyyy";
            this.dtp_pengem.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_pengem.Location = new System.Drawing.Point(158, 186);
            this.dtp_pengem.Name = "dtp_pengem";
            this.dtp_pengem.Size = new System.Drawing.Size(200, 20);
            this.dtp_pengem.TabIndex = 31;
            this.dtp_pengem.ValueChanged += new System.EventHandler(this.dtp_pengem_ValueChanged);
            // 
            // btn_simpan
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.btn_simpan, 4);
            this.btn_simpan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_simpan.Location = new System.Drawing.Point(3, 285);
            this.btn_simpan.Name = "btn_simpan";
            this.btn_simpan.Size = new System.Drawing.Size(598, 22);
            this.btn_simpan.TabIndex = 0;
            this.btn_simpan.Text = "DIKEMBALIKAN";
            this.btn_simpan.UseVisualStyleBackColor = true;
            this.btn_simpan.Click += new System.EventHandler(this.btn_simpan_Click);
            // 
            // pengembalianFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 442);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "pengembalianFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PENGEMBALIAN";
            this.Load += new System.EventHandler(this.pengembalianFrm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sewa)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btn_simpan;
        private System.Windows.Forms.DataGridView dgv_sewa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lb_kd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtp_sewa;
        private System.Windows.Forms.DateTimePicker dtp_kembali;
        private System.Windows.Forms.Label lb_total_sewa;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lb_total_denda;
        private System.Windows.Forms.Label lb_telat;
        private System.Windows.Forms.DateTimePicker dtp_pengem;
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
        private System.Windows.Forms.Label lb_film;
        private System.Windows.Forms.Label lb_pel;
        private System.Windows.Forms.Label lb_biaya_sewa;
        private System.Windows.Forms.Label lb_lama_sewa;
        private System.Windows.Forms.TextBox txt_denda;
    }
}