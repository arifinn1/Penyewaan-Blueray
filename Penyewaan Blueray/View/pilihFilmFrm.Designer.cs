namespace Penyewaan_Blueray.View
{
    partial class pilihFilmFrm
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
            this.dgv_film = new System.Windows.Forms.DataGridView();
            this._jml_stok = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._jml_disewa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._kd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._judul = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._rilis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._produksi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._genre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_cari = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_film)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.dgv_film, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txt_cari, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(478, 192);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dgv_film
            // 
            this.dgv_film.AllowUserToAddRows = false;
            this.dgv_film.AllowUserToDeleteRows = false;
            this.dgv_film.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_film.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_film.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._jml_stok,
            this._jml_disewa,
            this._kd,
            this._judul,
            this._rilis,
            this._produksi,
            this._genre});
            this.dgv_film.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_film.Location = new System.Drawing.Point(0, 25);
            this.dgv_film.Margin = new System.Windows.Forms.Padding(0);
            this.dgv_film.Name = "dgv_film";
            this.dgv_film.ReadOnly = true;
            this.dgv_film.Size = new System.Drawing.Size(478, 167);
            this.dgv_film.TabIndex = 9;
            this.dgv_film.TabStop = false;
            this.dgv_film.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_film_CellDoubleClick);
            // 
            // _jml_stok
            // 
            this._jml_stok.DataPropertyName = "jml_stok";
            this._jml_stok.HeaderText = "Stok";
            this._jml_stok.Name = "_jml_stok";
            this._jml_stok.ReadOnly = true;
            this._jml_stok.Width = 54;
            // 
            // _jml_disewa
            // 
            this._jml_disewa.DataPropertyName = "jml_disewa";
            this._jml_disewa.HeaderText = "Disewa";
            this._jml_disewa.Name = "_jml_disewa";
            this._jml_disewa.ReadOnly = true;
            this._jml_disewa.Width = 67;
            // 
            // _kd
            // 
            this._kd.DataPropertyName = "kd";
            this._kd.HeaderText = "Kode";
            this._kd.Name = "_kd";
            this._kd.ReadOnly = true;
            this._kd.Visible = false;
            this._kd.Width = 57;
            // 
            // _judul
            // 
            this._judul.DataPropertyName = "judul";
            this._judul.HeaderText = "Judul";
            this._judul.Name = "_judul";
            this._judul.ReadOnly = true;
            this._judul.Width = 57;
            // 
            // _rilis
            // 
            this._rilis.DataPropertyName = "rilis";
            this._rilis.HeaderText = "Rilis";
            this._rilis.Name = "_rilis";
            this._rilis.ReadOnly = true;
            this._rilis.Width = 51;
            // 
            // _produksi
            // 
            this._produksi.DataPropertyName = "produksi";
            this._produksi.HeaderText = "Produksi";
            this._produksi.Name = "_produksi";
            this._produksi.ReadOnly = true;
            this._produksi.Width = 73;
            // 
            // _genre
            // 
            this._genre.DataPropertyName = "genre";
            this._genre.HeaderText = "Genre";
            this._genre.Name = "_genre";
            this._genre.ReadOnly = true;
            this._genre.Width = 61;
            // 
            // txt_cari
            // 
            this.txt_cari.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_cari.Location = new System.Drawing.Point(3, 3);
            this.txt_cari.Name = "txt_cari";
            this.txt_cari.Size = new System.Drawing.Size(472, 20);
            this.txt_cari.TabIndex = 0;
            this.txt_cari.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cari_KeyPress);
            // 
            // pilihFilmFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 192);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "pilihFilmFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "pilihFilmFrm";
            this.Load += new System.EventHandler(this.pilihFilmFrm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_film)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txt_cari;
        private System.Windows.Forms.DataGridView dgv_film;
        private System.Windows.Forms.DataGridViewTextBoxColumn _jml_stok;
        private System.Windows.Forms.DataGridViewTextBoxColumn _jml_disewa;
        private System.Windows.Forms.DataGridViewTextBoxColumn _kd;
        private System.Windows.Forms.DataGridViewTextBoxColumn _judul;
        private System.Windows.Forms.DataGridViewTextBoxColumn _rilis;
        private System.Windows.Forms.DataGridViewTextBoxColumn _produksi;
        private System.Windows.Forms.DataGridViewTextBoxColumn _genre;
    }
}