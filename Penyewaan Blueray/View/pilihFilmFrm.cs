using System;
using System.Windows.Forms;

namespace Penyewaan_Blueray.View
{
    public partial class pilihFilmFrm : Form
    {
        Class.filmServ film = new Class.filmServ();
        Form _frm;

        public pilihFilmFrm(Form frm)
        {
            _frm = frm;
            InitializeComponent();
        }

        private void pilihFilmFrm_Load(object sender, EventArgs e)
        {
            txt_cari.Text = "";
            dgv_film.DataSource = film.Tampil("");
        }

        private void txt_cari_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                dgv_film.DataSource = film.Tampil(txt_cari.Text.Trim());
            }
        }

        private void dgv_film_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                int jml_stok = Convert.ToInt32(dgv_film.Rows[e.RowIndex].Cells["_jml_stok"].Value);
                int jml_disewa = Convert.ToInt32(dgv_film.Rows[e.RowIndex].Cells["_jml_disewa"].Value);
                if ((jml_stok - jml_disewa) > 0)
                {
                    penyewaanFrm obj_sewa = (penyewaanFrm)_frm;
                    obj_sewa.sel_kd_film = Convert.ToInt32(dgv_film.Rows[e.RowIndex].Cells["_kd"].Value);
                    obj_sewa.lb_film.Text = dgv_film.Rows[e.RowIndex].Cells["_judul"].Value.ToString();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Sorry, We are out of stock");
                }
            }
        }
    }
}
