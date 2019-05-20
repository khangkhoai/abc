using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThucTapNhom
{
    class DBConnection
    {
        private static SqlConnection con = null;
        public static SqlConnection createDbconnection()
        {
            string strcon = @"Data Source=KHANG-PC;Initial Catalog=QLNhaHang;Integrated Security=True;Connection Timeout=30;Connection Lifetime=0;Min Pool Size=0;Max Pool Size=10;Pooling=true;";
            con = new SqlConnection(strcon);
            return con;
        }

        public static void openDbConnection()
        {
            con.Open();
        }
    }
}
