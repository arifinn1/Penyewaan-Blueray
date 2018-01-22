using System;

namespace Penyewaan_Blueray.Class
{
    class pelanggan
    {
        private int _kd;
        private String _nik;
        private String _nama;
        private String _alamat;
        private String _telp;

        public pelanggan()
        {
            _kd = -1;
            _nik = String.Empty;
            _nama = String.Empty;
            _alamat = String.Empty;
            _telp = String.Empty;
        }

        public int Kd
        {
            get { return _kd; }
            set { _kd = value; }
        }

        public String Nik
        {
            get { return _nik; }
            set { _nik = value; }
        }

        public String Nama
        {
            get { return _nama; }
            set { _nama = value; }
        }

        public String Alamat
        {
            get { return _alamat; }
            set { _alamat = value; }
        }

        public String Telp
        {
            get { return _telp; }
            set { _telp = value; }
        }
    }
}
