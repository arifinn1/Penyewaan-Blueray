using System;

namespace Penyewaan_Blueray.Class
{
    class sewa
    {
        private int _kd;
        private int _kd_pel;
        private int _kd_film;
        private DateTime _tgl_sewa;
        private DateTime _tgl_kembali;
        private int _lama_sewa;
        private int _biaya_sewa;
        private int _total_sewa;
        private DateTime _tgl_pengembalian;
        private int _denda;
        private int _keterlambatan;
        private int _total_denda;

        public sewa()
        {
            _kd = -1;
            _kd_pel = -1;
            _kd_film = -1;
            _tgl_sewa = DateTime.Now;
            _tgl_kembali = DateTime.Now;
            _lama_sewa = 0;
            _biaya_sewa = 0;
            _total_sewa = 0;
            _tgl_pengembalian = DateTime.Now;
            _denda = 0;
            _keterlambatan = 0;
            _total_denda = 0;
        }

        public int Kd
        {
            get { return _kd; }
            set { _kd = value; }
        }

        public int Kd_Pel
        {
            get { return _kd_pel; }
            set { _kd_pel = value; }
        }

        public int Kd_Film
        {
            get { return _kd_film; }
            set { _kd_film = value; }
        }

        public DateTime Tgl_Sewa
        {
            get { return _tgl_sewa; }
            set { _tgl_sewa = value; }
        }

        public DateTime Tgl_Kembali
        {
            get { return _tgl_kembali; }
            set { _tgl_kembali = value; }
        }

        public int Lama_Sewa
        {
            get { return _lama_sewa; }
            set { _lama_sewa = value; }
        }

        public int Biaya_Sewa
        {
            get { return _biaya_sewa; }
            set { _biaya_sewa = value; }
        }

        public int Total_Sewa
        {
            get { return _total_sewa; }
            set { _total_sewa = value; }
        }

        public DateTime Tgl_Pengembalian
        {
            get { return _tgl_pengembalian; }
            set { _tgl_pengembalian = value; }
        }

        public int Denda
        {
            get { return _denda; }
            set { _denda = value; }
        }

        public int Keterlambatan
        {
            get { return _keterlambatan; }
            set { _keterlambatan = value; }
        }

        public int Total_Denda
        {
            get { return _total_denda; }
            set { _total_denda = value; }
        }
    }
}
