using System;

namespace Penyewaan_Blueray.Class
{
    class film
    {
        private int _kd;
        private String _judul;
        private DateTime _rilis;
        private String _produksi;
        private String _genre;
        private int _jml_stok;
        private int _jml_disewa;

        public film()
        {
            _kd = -1;
            _judul = String.Empty;
            _rilis = DateTime.Now;
            _produksi = String.Empty;
            _genre = String.Empty;
            _jml_stok = 0;
            _jml_disewa = 0;
        }

        public int Kd
        {
            get { return _kd;  }
            set { _kd = value; }
        }

        public String Judul
        {
            get { return _judul; }
            set { _judul = value; }
        }

        public DateTime Rilis
        {
            get { return _rilis; }
            set { _rilis = value; }
        }

        public String Produksi
        {
            get { return _produksi; }
            set { _produksi = value; }
        }

        public String Genre
        {
            get { return _genre; }
            set { _genre = value; }
        }

        public int Jml_Stok
        {
            get { return _jml_stok; }
            set { _jml_stok = value; }
        }

        public int Jml_Disewa
        {
            get { return _jml_disewa; }
            set { _jml_disewa = value; }
        }
    }
}
