using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace PHP_SRePS
{
    class Dbms
    {
        private static Dbms dbms = null;

        public static Dbms dbmsInstance()
        {
            if (dbms == null)
            {
                dbms = new Dbms();
            }
            return dbms;
        }
        public SqlConnection SettingUPConnectionWithDataBase()
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Charn\\Desktop\\DP2-PHP-SRePS-master\\PHP-SRePS\\PHP-SRePS\\Database1.mdf;Integrated Security=True");
            return con;
        }
    }
}
