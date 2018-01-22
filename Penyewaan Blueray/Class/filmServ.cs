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
    }
}
