using System;
using System.Data;

namespace Penyewaan_Blueray.Class
{
    class pelangganServ : pelanggan
    {
        SQLServerdb dbServ = new SQLServerdb();

        public DataTable Tampil(String nama)
        {
            dbServ.Query = "select * from pelanggan where nama like'%"+nama+"%'";
            return dbServ.ExecQuery(dbServ.Query);
        }

        public DataTable TampilSewa(String nama)
        {
            dbServ.Query = "select * from pelanggan where nama like'%" + nama + "%' and kd not in(select kd_pel from sewa where tgl_pengembalian is null)";
            return dbServ.ExecQuery(dbServ.Query);
        }

        public int KodeGen()
        {
            dbServ.Query = "select (isnull(max(kd), 0)+1) as kode from pelanggan";
            return (int)dbServ.ExecQuery(dbServ.Query).Rows[0][0];
        }

        public void Tambah()
        {
            dbServ.Query = "insert into pelanggan (kd, nik, nama, alamat, telp) values (" + Kd + ",'" + Nik + "','" + Nama + "','" + Alamat + "','" + Telp + "')";
            if (!(dbServ.ExecNonQuery(dbServ.Query) > 0))
            {
                throw new Exception("Tambah data pelanggan gagal");
            }
        }

        public void Ubah()
        {
            dbServ.Query = "update pelanggan set nik='" + Nik + "', nama='" + Nama + "', alamat='" + Alamat + "', telp='" + Telp + "' where kd=" + Kd;
            if (!(dbServ.ExecNonQuery(dbServ.Query) > 0))
            {
                throw new Exception("Ubah data pelanggan gagal");
            }
        }

        public void Hapus(int kd)
        {
            dbServ.Query = "delete from pelanggan where kd=" + kd;
            if (!(dbServ.ExecNonQuery(dbServ.Query) > 0))
            {
                throw new Exception("Hapus data pelanggan gagal");
            }
        }
    }
}
