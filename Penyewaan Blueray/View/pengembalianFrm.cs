using System;
using System.Windows.Forms;

namespace Penyewaan_Blueray.View
{
    public partial class pengembalianFrm : Form
    {
        Class.sewaServ sw = new Class.sewaServ();
        int sel_kode, sel_film, sel_denda, sel_keter, sel_total;
        Boolean baru;

        public pengembalianFrm()
        {
            InitializeComponent();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void dgv_sewa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                sel_kode = Convert.ToInt32(dgv_sewa.Rows[e.RowIndex].Cells["_kd"].Value);
                sel_film = Convert.ToInt32(dgv_sewa.Rows[e.RowIndex].Cells["_kd_film"].Value);
                lb_kd.Text = sel_kode.ToString();
                lb_pel.Text = dgv_sewa.Rows[e.RowIndex].Cells["_nm_pel"].Value.ToString();
                lb_film.Text = dgv_sewa.Rows[e.RowIndex].Cells["_judul"].Value.ToString();
                dtp_sewa.Value = Convert.ToDateTime(dgv_sewa.Rows[e.RowIndex].Cells["_tgl_sewa"].Value.ToString()); ;
                lb_lama_sewa.Text = dgv_sewa.Rows[e.RowIndex].Cells["_lama_sewa"].Value.ToString() + " hari";
                int by_sewa = Convert.ToInt32(dgv_sewa.Rows[e.RowIndex].Cells["_biaya_sewa"].Value);
                lb_biaya_sewa.Text = "Rp " + by_sewa.ToString("N");
                dtp_kembali.Value = Convert.ToDateTime(dgv_sewa.Rows[e.RowIndex].Cells["_tgl_kembali"].Value.ToString());
                int t_sewa = Convert.ToInt32(dgv_sewa.Rows[e.RowIndex].Cells["_total_sewa"].Value.ToString());
                lb_total_sewa.Text = "Rp " + t_sewa.ToString("N");

                if (dgv_sewa.Rows[e.RowIndex].Cells["_tgl_pengembalian"].Value.ToString() != "")
                {
                    baru = false;
                    dtp_pengem.Value = Convert.ToDateTime(dgv_sewa.Rows[e.RowIndex].Cells["_tgl_pengembalian"].Value.ToString());
                    txt_denda.Text = dgv_sewa.Rows[e.RowIndex].Cells["_denda"].Value.ToString();
                }
                else
                {
                    baru = true;
                    dtp_pengem.Value = DateTime.Now;
                    txt_denda.Text = "";
                }

                HitungTelat();
            }
        }

        private void dtp_pengem_ValueChanged(object sender, EventArgs e)
        {
            HitungTelat();
        }

        private void txt_denda_TextChanged(object sender, EventArgs e)
        {
            HitungTelat();
        }

        private void btn_simpan_Click(object sender, EventArgs e)
        {
            if (sel_kode > -1)
            {
                if (sel_keter == 0 || (sel_keter > 0 && sel_denda > 0))
                {
                    sw.Kd = sel_kode;
                    sw.Kd_Film = sel_film;
                    sw.Tgl_Pengembalian = dtp_pengem.Value;
                    sw.Denda = sel_denda;
                    sw.Keterlambatan = sel_keter;
                    sw.Total_Denda = sel_total;
                    sw.SimpanPengem(baru);

                    MessageBox.Show("Pengembalian berhasil", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                }
                else
                {
                    MessageBox.Show("Isi denda perhari", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        void HitungTelat()
        {
            sel_denda = txt_denda.Text.Trim() != "" ? Convert.ToInt32(txt_denda.Text.Trim()) : 0;
            sel_keter = ((TimeSpan) (dtp_pengem.Value - dtp_kembali.Value)).Days;
            sel_keter = sel_keter < 0 ? 0 : sel_keter;
            sel_total = sel_denda * sel_keter;

            lb_telat.Text = sel_keter.ToString() + " hari";
            lb_total_denda.Text = "Rp " + sel_total.ToString("N");
        }

        public void Clear()
        {
            baru = true;
            sel_kode = -1;
            sel_film = -1;
            sel_denda = 0;
            sel_total = 0;
            lb_kd.Text = "...";
            lb_pel.Text = "...";
            lb_film.Text = "...";
            dtp_sewa.Value = DateTime.Now;
            lb_lama_sewa.Text = "...";
            lb_biaya_sewa.Text = "...";
            dtp_kembali.Value = DateTime.Now;
            lb_total_sewa.Text = "...";
            dtp_pengem.Value = DateTime.Now;
            lb_telat.Text = "...";
            txt_denda.Text = "";
            lb_total_denda.Text = "...";

            dgv_sewa.DataSource = sw.Tampil();
        }

        private void pengembalianFrm_Load(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
