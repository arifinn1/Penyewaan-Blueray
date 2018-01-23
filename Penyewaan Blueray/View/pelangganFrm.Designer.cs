namespace Penyewaan_Blueray.View
{
    partial class pelangganFrm
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
            this.dgv_pelanggan = new System.Windows.Forms.DataGridView();
            this._kd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._nik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._nama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._alamat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._telp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_nik = new System.Windows.Forms.TextBox();
            this.txt_nama = new System.Windows.Forms.TextBox();
            this.txt_alamat = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_telp = new System.Windows.Forms.TextBox();
            this.lb_kd = new System.Windows.Forms.Label();
            this.txt_cari = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pelanggan)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.dgv_pelanggan, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.txt_nik, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.txt_nama, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.txt_alamat, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label4, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label5, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.txt_telp, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.lb_kd, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.txt_cari, 0, 8);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 10;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(530, 378);
            this.tableLayoutPanel1.TabIndex = 0;
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
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 192);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(530, 28);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // btn_simpan
            // 
            this.btn_simpan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_simpan.Location = new System.Drawing.Point(3, 3);
            this.btn_simpan.Name = "btn_simpan";
            this.btn_simpan.Size = new System.Drawing.Size(170, 22);
            this.btn_simpan.TabIndex = 0;
            this.btn_simpan.Text = "SIMPAN";
            this.btn_simpan.UseVisualStyleBackColor = true;
            this.btn_simpan.Click += new System.EventHandler(this.btn_simpan_Click);
            // 
            // btn_hapus
            // 
            this.btn_hapus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_hapus.Location = new System.Drawing.Point(179, 3);
            this.btn_hapus.Name = "btn_hapus";
            this.btn_hapus.Size = new System.Drawing.Size(170, 22);
            this.btn_hapus.TabIndex = 2;
            this.btn_hapus.Text = "HAPUS";
            this.btn_hapus.UseVisualStyleBackColor = true;
            this.btn_hapus.Click += new System.EventHandler(this.btn_hapus_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_clear.Location = new System.Drawing.Point(355, 3);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(172, 22);
            this.btn_clear.TabIndex = 3;
            this.btn_clear.Text = "CLEAR";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // dgv_pelanggan
            // 
            this.dgv_pelanggan.AllowUserToAddRows = false;
            this.dgv_pelanggan.AllowUserToDeleteRows = false;
            this.dgv_pelanggan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_pelanggan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_pelanggan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._kd,
            this._nik,
            this._nama,
            this._alamat,
            this._telp});
            this.tableLayoutPanel1.SetColumnSpan(this.dgv_pelanggan, 4);
            this.dgv_pelanggan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_pelanggan.Location = new System.Drawing.Point(0, 245);
            this.dgv_pelanggan.Margin = new System.Windows.Forms.Padding(0);
            this.dgv_pelanggan.Name = "dgv_pelanggan";
            this.dgv_pelanggan.ReadOnly = true;
            this.dgv_pelanggan.Size = new System.Drawing.Size(530, 133);
            this.dgv_pelanggan.TabIndex = 6;
            this.dgv_pelanggan.TabStop = false;
            this.dgv_pelanggan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_pelanggan_CellClick);
            // 
            // _kd
            // 
            this._kd.DataPropertyName = "kd";
            this._kd.HeaderText = "Kode";
            this._kd.Name = "_kd";
            this._kd.ReadOnly = true;
            this._kd.Width = 57;
            // 
            // _nik
            // 
            this._nik.DataPropertyName = "nik";
            this._nik.HeaderText = "NIK";
            this._nik.Name = "_nik";
            this._nik.ReadOnly = true;
            this._nik.Width = 50;
            // 
            // _nama
            // 
            this._nama.DataPropertyName = "nama";
            this._nama.HeaderText = "Nama";
            this._nama.Name = "_nama";
            this._nama.ReadOnly = true;
            this._nama.Width = 60;
            // 
            // _alamat
            // 
            this._alamat.DataPropertyName = "alamat";
            this._alamat.HeaderText = "Alamat";
            this._alamat.Name = "_alamat";
            this._alamat.ReadOnly = true;
            this._alamat.Width = 64;
            // 
            // _telp
            // 
            this._telp.DataPropertyName = "telp";
            this._telp.HeaderText = "Telp";
            this._telp.Name = "_telp";
            this._telp.ReadOnly = true;
            this._telp.Width = 53;
            // 
            // txt_nik
            // 
            this.txt_nik.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_nik.Location = new System.Drawing.Point(138, 46);
            this.txt_nik.Name = "txt_nik";
            this.txt_nik.Size = new System.Drawing.Size(336, 20);
            this.txt_nik.TabIndex = 0;
            // 
            // txt_nama
            // 
            this.txt_nama.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_nama.Location = new System.Drawing.Point(138, 74);
            this.txt_nama.Name = "txt_nama";
            this.txt_nama.Size = new System.Drawing.Size(336, 20);
            this.txt_nama.TabIndex = 1;
            // 
            // txt_alamat
            // 
            this.txt_alamat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_alamat.Location = new System.Drawing.Point(138, 102);
            this.txt_alamat.Multiline = true;
            this.txt_alamat.Name = "txt_alamat";
            this.txt_alamat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_alamat.Size = new System.Drawing.Size(336, 44);
            this.txt_alamat.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(53, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 28);
            this.label1.TabIndex = 7;
            this.label1.Text = "Kode";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(53, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 28);
            this.label2.TabIndex = 8;
            this.label2.Text = "NIK";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(53, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 28);
            this.label3.TabIndex = 9;
            this.label3.Text = "Nama";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(53, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 50);
            this.label4.TabIndex = 10;
            this.label4.Text = "Alamat";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(53, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 28);
            this.label5.TabIndex = 11;
            this.label5.Text = "Telp";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_telp
            // 
            this.txt_telp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_telp.Location = new System.Drawing.Point(138, 152);
            this.txt_telp.Name = "txt_telp";
            this.txt_telp.Size = new System.Drawing.Size(336, 20);
            this.txt_telp.TabIndex = 3;
            // 
            // lb_kd
            // 
            this.lb_kd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lb_kd.AutoSize = true;
            this.lb_kd.Location = new System.Drawing.Point(138, 15);
            this.lb_kd.Name = "lb_kd";
            this.lb_kd.Size = new System.Drawing.Size(16, 28);
            this.lb_kd.TabIndex = 13;
            this.lb_kd.Text = "...";
            this.lb_kd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_cari
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txt_cari, 4);
            this.txt_cari.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_cari.Location = new System.Drawing.Point(3, 223);
            this.txt_cari.Name = "txt_cari";
            this.txt_cari.Size = new System.Drawing.Size(524, 20);
            this.txt_cari.TabIndex = 5;
            this.txt_cari.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cari_KeyPress);
            // 
            // pelangganFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 378);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "pelangganFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PELANGGAN";
            this.Load += new System.EventHandler(this.pelangganFrm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pelanggan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btn_simpan;
        private System.Windows.Forms.Button btn_hapus;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.DataGridView dgv_pelanggan;
        private System.Windows.Forms.TextBox txt_nik;
        private System.Windows.Forms.TextBox txt_nama;
        private System.Windows.Forms.TextBox txt_alamat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_telp;
        private System.Windows.Forms.Label lb_kd;
        private System.Windows.Forms.DataGridViewTextBoxColumn _kd;
        private System.Windows.Forms.DataGridViewTextBoxColumn _nik;
        private System.Windows.Forms.DataGridViewTextBoxColumn _nama;
        private System.Windows.Forms.DataGridViewTextBoxColumn _alamat;
        private System.Windows.Forms.DataGridViewTextBoxColumn _telp;
        private System.Windows.Forms.TextBox txt_cari;
    }
}