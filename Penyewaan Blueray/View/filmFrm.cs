using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Penyewaan_Blueray.View
{
    public partial class filmFrm : Form
    {
        Class.filmServ flm = new Class.filmServ();
        int sel_kode;

        public filmFrm()
        {
            InitializeComponent();
        }

        public void Clear()
        {
            sel_kode = -1;
            lb_kd.Text = "...";
            txt_judul.Text = "";
            dtp_rilis.Value = DateTime.Now;
            txt_produksi.Text = "";
            txt_genre.Text = "";
            txt_stok.Text = "";
            txt_disewa.Text = "0";
            txt_cari.Text = "";
            txt_judul.Focus();

            dgv_film.DataSource = flm.Tampil("");
        }

        private void filmFrm_Load(object sender, EventArgs e)
        {
            Clear();
        }

        private void txt_cari_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                dgv_film.DataSource = flm.Tampil(txt_cari.Text.Trim());
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void dgv_film_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                sel_kode = Convert.ToInt32(dgv_film.Rows[e.RowIndex].Cells["_kd"].Value);
                lb_kd.Text = dgv_film.Rows[e.RowIndex].Cells["_kd"].Value.ToString();
                txt_judul.Text = dgv_film.Rows[e.RowIndex].Cells["_judul"].Value.ToString();
                dtp_rilis.Value = Convert.ToDateTime(dgv_film.Rows[e.RowIndex].Cells[2].Value.ToString());
                txt_produksi.Text = dgv_film.Rows[e.RowIndex].Cells["_produksi"].Value.ToString();
                txt_genre.Text = dgv_film.Rows[e.RowIndex].Cells["_genre"].Value.ToString();
                txt_stok.Text = dgv_film.Rows[e.RowIndex].Cells["_jml_stok"].Value.ToString();
                txt_disewa.Text = dgv_film.Rows[e.RowIndex].Cells["_jml_disewa"].Value.ToString();
            }
        }

        private void btn_simpan_Click(object sender, EventArgs e)
        {
            if(txt_judul.Text.Trim() != "" && txt_produksi.Text.Trim() != "" && txt_genre.Text.Trim() != "" && txt_stok.Text.Trim() != "" && txt_disewa.Text.Trim() != "")
            {
                flm.Judul = txt_judul.Text.Trim();
                flm.Rilis = dtp_rilis.Value;
                flm.Produksi = txt_produksi.Text.Trim();
                flm.Genre = txt_genre.Text.Trim();
                flm.Jml_Stok = Convert.ToInt32(txt_stok.Text.Trim());
                flm.Jml_Disewa = Convert.ToInt32(txt_disewa.Text.Trim());

                if (sel_kode == -1)
                {
                    flm.Kd = flm.KodeGen();
                    flm.Tambah();
                    MessageBox.Show("Tambah data film berhasil", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                }
                else if (MessageBox.Show("Ubah data film tersebut?", "Konfimasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    flm.Kd = sel_kode;
                    flm.Ubah();
                    MessageBox.Show("Ubah data film berhasil", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                }
            }
            else
            {
                MessageBox.Show("Lengkapi data kembali", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_hapus_Click(object sender, EventArgs e)
        {
            if (sel_kode > -1)
            {
                if (MessageBox.Show("Hapus data film tersebut?", "Konfimasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    flm.Hapus(sel_kode);
                    MessageBox.Show("Hapus data film berhasil", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                }
            }
        }
    }
}
