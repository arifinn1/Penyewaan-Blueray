using System;
using System.Data;

namespace Penyewaan_Blueray.Class
{
    class sewaServ : sewa
    {
        SQLServerdb dbServ = new SQLServerdb();

        public DataTable Tampil()
        {
            dbServ.Query = "select s.*, p.nama as nm_pel, f.judul from sewa s, pelanggan p, film f where s.kd_pel=p.kd and s.kd_film=f.kd order by s.tgl_sewa desc";
            return dbServ.ExecQuery(dbServ.Query);
        }

        public int KodeGen()
        {
            dbServ.Query = "select (isnull(max(kd), 0)+1) as kode from sewa";
            return (int)dbServ.ExecQuery(dbServ.Query).Rows[0][0];
        }

        public void SimpanSewa()
        {
            dbServ.Query = "insert into sewa (kd, kd_pel, kd_film, tgl_sewa, tgl_kembali, lama_sewa, biaya_sewa, total_sewa) " +
                "values (" + Kd + "," + Kd_Pel + "," + Kd_Film + ",'" + Tgl_Sewa.Date + "','" + Tgl_Kembali.Date + "'," + Lama_Sewa + "," + Biaya_Sewa + "," + Total_Sewa + ")";
            if (!(dbServ.ExecNonQuery(dbServ.Query) > 0))
            {
                throw new Exception("Tambah data sewa gagal");
            }
            else
            {
                int up_stok = dbServ.ExecNonQuery("update film set jml_disewa=jml_disewa+1 where kd=" + Kd_Film);
            }
        }

        public void UbahSewa()
        {
            dbServ.Query = "update sewa set kd_pel=" + Kd_Pel + ", kd_film=" + Kd_Film + ", tgl_sewa='" + Tgl_Sewa.Date + "', tgl_kembali='" + 
                Tgl_Kembali.Date + "', lama_sewa=" + Lama_Sewa + ", biaya_sewa=" + Biaya_Sewa + ", total_sewa=" + Total_Sewa + " where kd=" + Kd;
            if (!(dbServ.ExecNonQuery(dbServ.Query) > 0))
            {
                throw new Exception("Ubah data sewa gagal");
            }
        }

        public void SimpanPengem(Boolean baru)
        {
            dbServ.Query = "update sewa set tgl_pengembalian='" + Tgl_Pengembalian.Date + "', denda=" + Denda + ", keterlambatan=" + Keterlambatan + ", total_denda=" + Total_Denda + " where kd=" + Kd;
            if (!(dbServ.ExecNonQuery(dbServ.Query) > 0))
            {
                throw new Exception("Simpan data pengembalian gagal");
            }
            else
            {
                if (baru)
                {
                    int up_stok = dbServ.ExecNonQuery("update film set jml_disewa=jml_disewa-1 where kd=" + Kd_Film);
                }
            }
        }

        public void Hapus(int kd, int kd_film)
        {
            dbServ.Query = "delete from sewa where kd=" + kd;
            if (!(dbServ.ExecNonQuery(dbServ.Query) > 0))
            {
                throw new Exception("Hapus data sewa gagal");
            }
            else
            {
                int up_stok = dbServ.ExecNonQuery("update film set jml_disewa=jml_disewa-1 where kd=" + kd_film);
            }
        }
    }
}
