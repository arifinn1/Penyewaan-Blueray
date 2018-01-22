using System;
using System.Windows.Forms;

namespace Penyewaan_Blueray.View
{
    public partial class pelangganFrm : Form
    {
        Class.pelangganServ plgn = new Class.pelangganServ();
        int sel_kode;

        public pelangganFrm()
        {
            InitializeComponent();
        }

        public void Clear()
        {
            sel_kode = -1;
            lb_kd.Text = "...";
            txt_nik.Text = "";
            txt_nama.Text = "";
            txt_alamat.Text = "";
            txt_telp.Text = "";
            txt_nik.Focus();

            dgv_pelanggan.DataSource = plgn.Tampil("");
        }

        private void pelangganFrm_Load(object sender, EventArgs e)
        {
            Clear();
        }

        private void txt_cari_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                dgv_pelanggan.DataSource = plgn.Tampil(txt_cari.Text.Trim());
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void dgv_pelanggan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                sel_kode = Convert.ToInt16(dgv_pelanggan.Rows[e.RowIndex].Cells[0].Value);
                lb_kd.Text = dgv_pelanggan.Rows[e.RowIndex].Cells[0].Value.ToString();
                txt_nik.Text = dgv_pelanggan.Rows[e.RowIndex].Cells[1].Value.ToString();
                txt_nama.Text = dgv_pelanggan.Rows[e.RowIndex].Cells[2].Value.ToString();
                txt_alamat.Text = dgv_pelanggan.Rows[e.RowIndex].Cells[3].Value.ToString();
                txt_telp.Text = dgv_pelanggan.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
        }

        private void btn_simpan_Click(object sender, EventArgs e)
        {
            if(txt_nik.Text.Trim() != "" && txt_nama.Text.Trim() != "" && txt_alamat.Text.Trim() != "" && txt_telp.Text.Trim() != "")
            {
                plgn.Nik = txt_nik.Text.Trim();
                plgn.Nama = txt_nama.Text.Trim();
                plgn.Alamat = txt_alamat.Text.Trim();
                plgn.Telp = txt_telp.Text.Trim();

                if (sel_kode == -1)
                {
                    plgn.Kd = plgn.KodeGen();
                    plgn.Tambah();
                    MessageBox.Show("Tambah data pelanggan berhasil", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                }
                else if (MessageBox.Show("Ubah data pelanggan tersebut?", "Konfimasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    plgn.Kd = sel_kode;
                    plgn.Ubah();
                    MessageBox.Show("Ubah data pelanggan berhasil", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                if (MessageBox.Show("Hapus data pelanggan tersebut?", "Konfimasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    plgn.Hapus(sel_kode);
                    MessageBox.Show("Hapus data pelanggan berhasil", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                }
            }
        }
    }
}
