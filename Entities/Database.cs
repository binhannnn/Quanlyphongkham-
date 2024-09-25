using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QUANLYPHONGKHAMTU.Entities
{
    class Database
    {
        SqlConnection sqlConn;
        SqlDataAdapter da;
        DataSet ds;
        SqlCommand sqlcmd;

        public Database()
        {
            string strCnn = "Data Source=DESKTOP-KE8KP90\\BINHAN;Initial Catalog=QUANLYPHONGKHAM;User ID=sa;Password=1";



            sqlConn = new SqlConnection(strCnn);
        }

        public DataTable Execute(string sqlStr)
        {
            da = new SqlDataAdapter(sqlStr, sqlConn);
            ds = new DataSet();
            da.Fill(ds);
            return ds.Tables[0];
        }

        public void ExecuteNonQuery(string sqlStr)
        {
            sqlcmd = new SqlCommand(sqlStr, sqlConn);
            sqlConn.Open();
            sqlcmd.ExecuteNonQuery();
            sqlConn.Close();
        }
    }
}
