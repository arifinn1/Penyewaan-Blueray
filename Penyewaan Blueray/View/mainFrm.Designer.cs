namespace Penyewaan_Blueray.View
{
    partial class mainFrm
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
            this.btn_film = new System.Windows.Forms.Button();
            this.btn_pengem = new System.Windows.Forms.Button();
            this.btn_pelanggan = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_penye = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.00062F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.00063F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.99812F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.00063F));
            this.tableLayoutPanel1.Controls.Add(this.btn_film, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_pengem, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_pelanggan, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.btn_penye, 2, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(567, 157);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btn_film
            // 
            this.btn_film.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_film.Location = new System.Drawing.Point(144, 84);
            this.btn_film.Name = "btn_film";
            this.btn_film.Size = new System.Drawing.Size(135, 29);
            this.btn_film.TabIndex = 0;
            this.btn_film.Text = "FILM";
            this.btn_film.UseVisualStyleBackColor = true;
            this.btn_film.Click += new System.EventHandler(this.btn_film_Click);
            // 
            // btn_pengem
            // 
            this.btn_pengem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_pengem.Location = new System.Drawing.Point(426, 84);
            this.btn_pengem.Name = "btn_pengem";
            this.btn_pengem.Size = new System.Drawing.Size(138, 29);
            this.btn_pengem.TabIndex = 1;
            this.btn_pengem.Text = "PENGEMBALIAN";
            this.btn_pengem.UseVisualStyleBackColor = true;
            this.btn_pengem.Click += new System.EventHandler(this.btn_pengem_Click);
            // 
            // btn_pelanggan
            // 
            this.btn_pelanggan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_pelanggan.Location = new System.Drawing.Point(3, 84);
            this.btn_pelanggan.Name = "btn_pelanggan";
            this.btn_pelanggan.Size = new System.Drawing.Size(135, 29);
            this.btn_pelanggan.TabIndex = 2;
            this.btn_pelanggan.Text = "PELANGGAN";
            this.btn_pelanggan.UseVisualStyleBackColor = true;
            this.btn_pelanggan.Click += new System.EventHandler(this.btn_pelanggan_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label1, 4);
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Milkshake", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(561, 81);
            this.label1.TabIndex = 3;
            this.label1.Text = "Rental BlueRay";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(426, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "by Arifin";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label3, 3);
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(144, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(420, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "2110167053 - D4 TI LJ PJJ 2016";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btn_penye
            // 
            this.btn_penye.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_penye.Location = new System.Drawing.Point(285, 84);
            this.btn_penye.Name = "btn_penye";
            this.btn_penye.Size = new System.Drawing.Size(135, 29);
            this.btn_penye.TabIndex = 6;
            this.btn_penye.Text = "PENYEWAAN";
            this.btn_penye.UseVisualStyleBackColor = true;
            this.btn_penye.Click += new System.EventHandler(this.btn_penye_Click);
            // 
            // mainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(567, 157);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "mainFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MENU UTAMA";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btn_film;
        private System.Windows.Forms.Button btn_pengem;
        private System.Windows.Forms.Button btn_pelanggan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_penye;
    }
}