namespace Penyewaan_Blueray.View
{
    partial class pilihPelangganFrm
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
            this.dgv_pelanggan = new System.Windows.Forms.DataGridView();
            this._kd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._nik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._nama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._alamat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._telp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_cari = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pelanggan)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.dgv_pelanggan, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txt_cari, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(459, 238);
            this.tableLayoutPanel1.TabIndex = 0;
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
            this.dgv_pelanggan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_pelanggan.Location = new System.Drawing.Point(0, 25);
            this.dgv_pelanggan.Margin = new System.Windows.Forms.Padding(0);
            this.dgv_pelanggan.Name = "dgv_pelanggan";
            this.dgv_pelanggan.ReadOnly = true;
            this.dgv_pelanggan.Size = new System.Drawing.Size(459, 213);
            this.dgv_pelanggan.TabIndex = 1;
            this.dgv_pelanggan.TabStop = false;
            this.dgv_pelanggan.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_pelanggan_CellDoubleClick);
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
            // txt_cari
            // 
            this.txt_cari.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_cari.Location = new System.Drawing.Point(3, 3);
            this.txt_cari.Name = "txt_cari";
            this.txt_cari.Size = new System.Drawing.Size(453, 20);
            this.txt_cari.TabIndex = 0;
            this.txt_cari.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cari_KeyPress);
            // 
            // pilihPelangganFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 238);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "pilihPelangganFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "pilihPelangganFrm";
            this.Load += new System.EventHandler(this.pilihPelangganFrm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pelanggan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txt_cari;
        private System.Windows.Forms.DataGridView dgv_pelanggan;
        private System.Windows.Forms.DataGridViewTextBoxColumn _kd;
        private System.Windows.Forms.DataGridViewTextBoxColumn _nik;
        private System.Windows.Forms.DataGridViewTextBoxColumn _nama;
        private System.Windows.Forms.DataGridViewTextBoxColumn _alamat;
        private System.Windows.Forms.DataGridViewTextBoxColumn _telp;
    }
}