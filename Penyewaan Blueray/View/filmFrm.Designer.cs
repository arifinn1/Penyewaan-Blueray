namespace Penyewaan_Blueray.View
{
    partial class filmFrm
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
            this.dgv_film = new System.Windows.Forms.DataGridView();
            this._kd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._judul = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._rilis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._produksi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._genre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._jml_stok = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._jml_disewa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_judul = new System.Windows.Forms.TextBox();
            this.txt_produksi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_genre = new System.Windows.Forms.TextBox();
            this.lb_kd = new System.Windows.Forms.Label();
            this.txt_cari = new System.Windows.Forms.TextBox();
            this.dtp_rilis = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_stok = new System.Windows.Forms.TextBox();
            this.txt_disewa = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_film)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.dgv_film, 0, 11);
            this.tableLayoutPanel1.Controls.Add(this.txt_judul, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.txt_produksi, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label4, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label5, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.txt_genre, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.lb_kd, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.txt_cari, 0, 10);
            this.tableLayoutPanel1.Controls.Add(this.dtp_rilis, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.label6, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.label7, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.txt_stok, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.txt_disewa, 2, 7);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 12;
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
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(611, 405);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel2, 4);
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33444F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33444F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33112F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
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
            this.tableLayoutPanel2.Size = new System.Drawing.Size(611, 28);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // btn_simpan
            // 
            this.btn_simpan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_simpan.Location = new System.Drawing.Point(3, 3);
            this.btn_simpan.Name = "btn_simpan";
            this.btn_simpan.Size = new System.Drawing.Size(197, 22);
            this.btn_simpan.TabIndex = 0;
            this.btn_simpan.Text = "SIMPAN";
            this.btn_simpan.UseVisualStyleBackColor = true;
            this.btn_simpan.Click += new System.EventHandler(this.btn_simpan_Click);
            // 
            // btn_hapus
            // 
            this.btn_hapus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_hapus.Location = new System.Drawing.Point(206, 3);
            this.btn_hapus.Name = "btn_hapus";
            this.btn_hapus.Size = new System.Drawing.Size(197, 22);
            this.btn_hapus.TabIndex = 2;
            this.btn_hapus.Text = "HAPUS";
            this.btn_hapus.UseVisualStyleBackColor = true;
            this.btn_hapus.Click += new System.EventHandler(this.btn_hapus_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_clear.Location = new System.Drawing.Point(409, 3);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(199, 22);
            this.btn_clear.TabIndex = 3;
            this.btn_clear.Text = "CLEAR";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // dgv_film
            // 
            this.dgv_film.AllowUserToAddRows = false;
            this.dgv_film.AllowUserToDeleteRows = false;
            this.dgv_film.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_film.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_film.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._kd,
            this._judul,
            this._rilis,
            this._produksi,
            this._genre,
            this._jml_stok,
            this._jml_disewa});
            this.tableLayoutPanel1.SetColumnSpan(this.dgv_film, 4);
            this.dgv_film.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_film.Location = new System.Drawing.Point(0, 279);
            this.dgv_film.Margin = new System.Windows.Forms.Padding(0);
            this.dgv_film.Name = "dgv_film";
            this.dgv_film.ReadOnly = true;
            this.dgv_film.Size = new System.Drawing.Size(611, 126);
            this.dgv_film.TabIndex = 8;
            this.dgv_film.TabStop = false;
            this.dgv_film.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_film_CellClick);
            // 
            // _kd
            // 
            this._kd.DataPropertyName = "kd";
            this._kd.HeaderText = "Kode";
            this._kd.Name = "_kd";
            this._kd.ReadOnly = true;
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
            // txt_judul
            // 
            this.txt_judul.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_judul.Location = new System.Drawing.Point(155, 46);
            this.txt_judul.Name = "txt_judul";
            this.txt_judul.Size = new System.Drawing.Size(402, 20);
            this.txt_judul.TabIndex = 0;
            // 
            // txt_produksi
            // 
            this.txt_produksi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_produksi.Location = new System.Drawing.Point(155, 102);
            this.txt_produksi.Name = "txt_produksi";
            this.txt_produksi.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_produksi.Size = new System.Drawing.Size(402, 20);
            this.txt_produksi.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(53, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 28);
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
            this.label2.Size = new System.Drawing.Size(96, 28);
            this.label2.TabIndex = 8;
            this.label2.Text = "Judul";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(53, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 28);
            this.label3.TabIndex = 9;
            this.label3.Text = "Rilis";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(53, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 28);
            this.label4.TabIndex = 10;
            this.label4.Text = "Produksi";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(53, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 28);
            this.label5.TabIndex = 11;
            this.label5.Text = "Genre";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_genre
            // 
            this.txt_genre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_genre.Location = new System.Drawing.Point(155, 130);
            this.txt_genre.Name = "txt_genre";
            this.txt_genre.Size = new System.Drawing.Size(402, 20);
            this.txt_genre.TabIndex = 3;
            // 
            // lb_kd
            // 
            this.lb_kd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lb_kd.AutoSize = true;
            this.lb_kd.Location = new System.Drawing.Point(155, 15);
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
            this.txt_cari.Location = new System.Drawing.Point(3, 257);
            this.txt_cari.Name = "txt_cari";
            this.txt_cari.Size = new System.Drawing.Size(605, 20);
            this.txt_cari.TabIndex = 7;
            this.txt_cari.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cari_KeyPress);
            // 
            // dtp_rilis
            // 
            this.dtp_rilis.CustomFormat = "dddd, d MMMM yyyy";
            this.dtp_rilis.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_rilis.Location = new System.Drawing.Point(155, 74);
            this.dtp_rilis.Name = "dtp_rilis";
            this.dtp_rilis.Size = new System.Drawing.Size(200, 20);
            this.dtp_rilis.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(53, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 28);
            this.label6.TabIndex = 15;
            this.label6.Text = "Stok";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(53, 183);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 28);
            this.label7.TabIndex = 16;
            this.label7.Text = "Disewa";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_stok
            // 
            this.txt_stok.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_stok.Location = new System.Drawing.Point(155, 158);
            this.txt_stok.Name = "txt_stok";
            this.txt_stok.Size = new System.Drawing.Size(402, 20);
            this.txt_stok.TabIndex = 4;
            // 
            // txt_disewa
            // 
            this.txt_disewa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_disewa.Location = new System.Drawing.Point(155, 186);
            this.txt_disewa.Name = "txt_disewa";
            this.txt_disewa.ReadOnly = true;
            this.txt_disewa.Size = new System.Drawing.Size(402, 20);
            this.txt_disewa.TabIndex = 5;
            // 
            // filmFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 405);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "filmFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FILM";
            this.Load += new System.EventHandler(this.filmFrm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_film)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btn_simpan;
        private System.Windows.Forms.Button btn_hapus;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.DataGridView dgv_film;
        private System.Windows.Forms.TextBox txt_judul;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_genre;
        private System.Windows.Forms.Label lb_kd;
        private System.Windows.Forms.TextBox txt_cari;
        private System.Windows.Forms.TextBox txt_produksi;
        private System.Windows.Forms.DateTimePicker dtp_rilis;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_stok;
        private System.Windows.Forms.TextBox txt_disewa;
        private System.Windows.Forms.DataGridViewTextBoxColumn _kd;
        private System.Windows.Forms.DataGridViewTextBoxColumn _judul;
        private System.Windows.Forms.DataGridViewTextBoxColumn _rilis;
        private System.Windows.Forms.DataGridViewTextBoxColumn _produksi;
        private System.Windows.Forms.DataGridViewTextBoxColumn _genre;
        private System.Windows.Forms.DataGridViewTextBoxColumn _jml_stok;
        private System.Windows.Forms.DataGridViewTextBoxColumn _jml_disewa;
    }
}