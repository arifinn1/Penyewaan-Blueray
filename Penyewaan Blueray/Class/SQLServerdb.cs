using System;
using System.Data.SqlClient;
using System.Data;

namespace Penyewaan_Blueray
{
    class SQLServerdb
    {
        String strCon = @"Data Source=ARIFIN-PC\SQLDEV; Initial Catalog=db_rental;User ID=sa;Password=arifin";
        SqlConnection sqlCon;
        SqlCommand sqlCom;
        SqlDataAdapter sqlDtAdp;
        public String Query;
        
        public SQLServerdb()
        {
            sqlCon = new SqlConnection(strCon);
            sqlCom = new SqlCommand();
            sqlDtAdp = new SqlDataAdapter();
        }

        ~SQLServerdb()
        {
            if (sqlCon != null)
            {
                switch (sqlCon.State)
                {
                    case ConnectionState.Connecting:
                    case ConnectionState.Executing:
                    case ConnectionState.Fetching:
                        sqlCon.Close();
                        sqlCon = null;
                        break;
                    default:
                        sqlCon = null;
                        break;
                }
            }
            sqlCom = null;
            sqlDtAdp = null;
        }

        public int ExecNonQuery(String query)
        {
            int ret = -1;

            try
            {
                sqlCon.Open();
                sqlCom.Connection = sqlCon;
                sqlCom.CommandText = query;
                ret = sqlCom.ExecuteNonQuery();
            }
            finally
            {
                sqlCon.Close();
            }

            return ret;
        }

        public DataTable ExecQuery(String query)
        {
            DataTable ret = null;

            try
            {
                sqlCon.Open();
                ret = new DataTable();
                sqlCom.Connection = sqlCon;
                sqlCom.CommandText = query;
                sqlDtAdp.SelectCommand = sqlCom;
                sqlDtAdp.Fill(ret);
            }
            finally
            {
                sqlCon.Close();
            }

            return ret;
        }
    }
}
