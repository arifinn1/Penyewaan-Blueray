using System;
using System.Data;

namespace Penyewaan_Blueray.Class
{
    class filmServ : film
    {
        SQLServerdb dbServ = new SQLServerdb();

        public DataTable Tampil(String judul)
        {
            dbServ.Query = "select * from film where judul like'%" + judul + "%'";
            return dbServ.ExecQuery(dbServ.Query);
        }

        public int KodeGen()
        {
            dbServ.Query = "select (isnull(max(kd), 0)+1) as kode from film";
            return (int)dbServ.ExecQuery(dbServ.Query).Rows[0][0];
        }

        public void Tambah()
        {
            dbServ.Query = "insert into film (kd, judul, rilis, produksi, genre, jml_stok, jml_disewa) values (" + Kd + ",'" + Judul + "','" + Rilis.Date + "','" + Produksi + "','" + Genre + "'," + Jml_Stok + "," + Jml_Disewa + ")";
            if (!(dbServ.ExecNonQuery(dbServ.Query) > 0))
            {
                throw new Exception("Tambah data film gagal");
            }
        }

        public void Ubah()
        {
            dbServ.Query = "update film set judul='" + Judul + "', rilis='" + Rilis.Date + "', produksi='" + Produksi + "', genre='" + Genre + "', jml_stok=" + Jml_Stok + ", jml_disewa=" + Jml_Disewa + " where kd=" + Kd;
            if (!(dbServ.ExecNonQuery(dbServ.Query) > 0))
            {
                throw new Exception("Ubah data film gagal");
            }
        }

        public void Hapus(int kd)
        {
            dbServ.Query = "delete from film where kd=" + kd;
            if (!(dbServ.ExecNonQuery(dbServ.Query) > 0))
            {
                throw new Exception("Hapus data film gagal");
            }
        }
    }
}
