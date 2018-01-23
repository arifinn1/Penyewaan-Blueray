using System;
using System.Windows.Forms;

namespace Penyewaan_Blueray.View
{
    public partial class mainFrm : Form
    {
        pelangganFrm plgn = new pelangganFrm();
        filmFrm film = new filmFrm();
        penyewaanFrm pnye = new penyewaanFrm();
        pengembalianFrm peng = new pengembalianFrm();

        public mainFrm()
        {
            InitializeComponent();
        }

        private void btn_pelanggan_Click(object sender, EventArgs e)
        {
            plgn.ShowDialog();
        }

        private void btn_film_Click(object sender, EventArgs e)
        {
            film.ShowDialog();
        }

        private void btn_penye_Click(object sender, EventArgs e)
        {
            pnye.ShowDialog();
        }

        private void btn_pengem_Click(object sender, EventArgs e)
        {
            peng.ShowDialog();
        }
    }
}
