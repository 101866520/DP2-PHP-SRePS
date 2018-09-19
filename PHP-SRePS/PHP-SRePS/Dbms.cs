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
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\USERS\\GOLDE\\DP2-PHP-SREPS-ADD-AND-EDIT-FORM\\DP2-PHP-SREPS-ADD-AND-EDIT-FORM\\PHP-SREPS\\PHP-SREPS\\DATABASE1.MDF;Integrated Security=True");
            return con;
        }
    }
}
