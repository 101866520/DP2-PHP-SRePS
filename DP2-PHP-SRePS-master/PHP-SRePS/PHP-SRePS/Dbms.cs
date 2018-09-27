using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace PHP_SRePS
{
    /// <summary>
    /// this classhas only been used to  setup connection to Database
    /// </summary>
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
        /// <summary>
        /// settign up connection with database
        /// </summary>
        /// <returns></returns>
        public SqlConnection SettingUPConnectionWithDataBase()
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Charn\\Desktop\\DP2-PHP-SRePS-master\\PHP-SRePS\\PHP-SRePS\\Database1.mdf;Integrated Security=True");
            return con;
        }
    }
}
