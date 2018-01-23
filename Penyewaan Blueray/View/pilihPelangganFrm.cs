using System;
using System.Windows.Forms;

namespace Penyewaan_Blueray.View
{
    public partial class pilihPelangganFrm : Form
    {
        Class.pelangganServ plgn = new Class.pelangganServ();
        Form _frm;

        public pilihPelangganFrm(Form frm)
        {
            _frm = frm;
            InitializeComponent();
        }

        private void pilihPelangganFrm_Load(object sender, EventArgs e)
        {
            txt_cari.Text = "";
            dgv_pelanggan.DataSource = plgn.TampilSewa("");
        }

        private void txt_cari_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                dgv_pelanggan.DataSource = plgn.TampilSewa(txt_cari.Text.Trim());
            }
        }

        private void dgv_pelanggan_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                penyewaanFrm obj_sewa = (penyewaanFrm)_frm;
                obj_sewa.sel_kd_pel = Convert.ToInt32(dgv_pelanggan.Rows[e.RowIndex].Cells["_kd"].Value);
                obj_sewa.lb_pelanggan.Text = dgv_pelanggan.Rows[e.RowIndex].Cells["_nama"].Value.ToString();
                this.Close();
            }
        }
    }
}
