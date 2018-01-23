using System;
using System.Windows.Forms;

namespace Penyewaan_Blueray.View
{
    public partial class penyewaanFrm : Form
    {
        Class.sewaServ sw = new Class.sewaServ();
        public int sel_kode, sel_kd_pel, sel_kd_film, sel_lama, sel_biaya, sel_total;
        String sel_pengem;

        public penyewaanFrm()
        {
            InitializeComponent();
        }

        public void Clear()
        {
            sel_kode = -1;
            sel_kd_pel = -1;
            sel_kd_film = -1;
            sel_total = 0;
            sel_pengem = "";
            lb_kd.Text = "...";
            lb_pelanggan.Text = "...";
            lb_film.Text = "...";
            dtp_sewa.Value = DateTime.Now;
            txt_lama.Text = "";
            txt_biaya.Text = "";
            dtp_kembali.Value = DateTime.Now;
            lb_total.Text = "...";
            btn_pelanggan.Enabled = true;
            btn_film.Enabled = true;
            txt_lama.ReadOnly = false;
            txt_biaya.ReadOnly = false;

            dgv_sewa.DataSource = sw.Tampil();
        }

        void HitungTotal()
        {
            sel_lama = txt_lama.Text.Trim() != "" ? Convert.ToInt32(txt_lama.Text.Trim()) : 0;
            sel_biaya = txt_biaya.Text.Trim() != "" ? Convert.ToInt32(txt_biaya.Text.Trim()) : 0;
            sel_total = sel_lama * sel_biaya;

            lb_total.Text = "Rp " + sel_total.ToString("N");
            dtp_kembali.Value = DateTime.Now.AddDays(sel_lama);
        }

        private void penyewaanFrm_Load(object sender, EventArgs e)
        {
            Clear();
        }

        private void txt_lama_TextChanged(object sender, EventArgs e)
        {
            HitungTotal();
        }

        private void dgv_sewa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                sel_kode = Convert.ToInt32(dgv_sewa.Rows[e.RowIndex].Cells["_kd"].Value);
                sel_kd_pel = Convert.ToInt32(dgv_sewa.Rows[e.RowIndex].Cells["_kd_pel"].Value);
                sel_kd_film = Convert.ToInt32(dgv_sewa.Rows[e.RowIndex].Cells["_kd_film"].Value);
                sel_total = Convert.ToInt32(dgv_sewa.Rows[e.RowIndex].Cells["_total_sewa"].Value);
                sel_pengem = dgv_sewa.Rows[e.RowIndex].Cells["_tgl_pengembalian"].Value.ToString();
                lb_kd.Text = sel_kode.ToString();
                lb_pelanggan.Text = dgv_sewa.Rows[e.RowIndex].Cells["_nm_pel"].Value.ToString();
                lb_film.Text = dgv_sewa.Rows[e.RowIndex].Cells["_judul"].Value.ToString();
                dtp_sewa.Value = Convert.ToDateTime(dgv_sewa.Rows[e.RowIndex].Cells["_tgl_sewa"].Value.ToString());
                txt_lama.Text = dgv_sewa.Rows[e.RowIndex].Cells["_lama_sewa"].Value.ToString();
                txt_biaya.Text = dgv_sewa.Rows[e.RowIndex].Cells["_biaya_sewa"].Value.ToString();
                dtp_kembali.Value = Convert.ToDateTime(dgv_sewa.Rows[e.RowIndex].Cells["_tgl_kembali"].Value.ToString());
                btn_pelanggan.Enabled = false;
                btn_film.Enabled = false;
            }
        }

        private void btn_hapus_Click(object sender, EventArgs e)
        {
            if (sel_kode > -1)
            {
                if (sel_pengem == "")
                {
                    if (MessageBox.Show("Hapus data sewa tersebut?", "Konfimasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        sw.Hapus(sel_kode, sel_kd_film);
                        MessageBox.Show("Hapus data sewa berhasil", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Clear();
                    }
                }
                else
                { 
                    MessageBox.Show("Keping Film telah dikembalikan", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void txt_biaya_TextChanged(object sender, EventArgs e)
        {
            HitungTotal();
        }

        private void btn_simpan_Click(object sender, EventArgs e)
        {
            if (txt_lama.Text.Trim() != "" && txt_biaya.Text.Trim() != "" && sel_kd_pel>-1 && sel_kd_film>-1 && sel_lama > 0 && sel_biaya > 0)
            {
                if (sel_kode > -1 && sel_pengem != "")
                {
                    MessageBox.Show("Keping Film telah dikembalikan", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                { 
                    sw.Kd_Pel = sel_kd_pel;
                    sw.Kd_Film = sel_kd_film;
                    sw.Tgl_Sewa = DateTime.Now;
                    sw.Tgl_Kembali = DateTime.Now.AddDays(sel_lama);
                    sw.Lama_Sewa = sel_lama;
                    sw.Biaya_Sewa = sel_biaya;
                    sw.Total_Sewa = sel_total;

                    if (sel_kode == -1)
                    {
                        sw.Kd = sw.KodeGen();
                        sw.SimpanSewa();
                        MessageBox.Show("Tambah data sewa berhasil", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Clear();
                    }
                    else if (MessageBox.Show("Ubah data sewa tersebut?", "Konfimasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        sw.Kd = sel_kode;
                        sw.UbahSewa();
                        MessageBox.Show("Ubah data sewa berhasil", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Clear();
                    }
                }
            }
            else
            {
                MessageBox.Show("Lengkapi data kembali", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btn_pelanggan_Click(object sender, EventArgs e)
        {
            pilihPelangganFrm ppel = new pilihPelangganFrm(this);
            ppel.ShowDialog();
        }

        private void btn_film_Click(object sender, EventArgs e)
        {
            pilihFilmFrm pfilm = new pilihFilmFrm(this);
            pfilm.ShowDialog();
        }
    }
}
