using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Text.RegularExpressions;

namespace PHP_SRePS
{
    /// <summary>
    /// utility class used to reduce deuplication code
    /// provide methods to connect to data base and execuse querries
    /// </summary>
    class Utitility
    {
        private static Utitility utitility = null;
        Dbms dbmsInstance = Dbms.dbmsInstance();

        public static Utitility UtitilityInstance()
        {
            if (utitility == null)
            {
                utitility = new Utitility();
            }
            return utitility;
        }
        /// <summary>
        /// reads all values from reader stores in an item
        /// </summary>
        /// <param name="reader"></param>
        /// <returns></returns>
        public Item ItemWithAllValues(SqlDataReader reader)

        {
            Item tempItem = new Item();
            tempItem.ItemNo = Convert.ToInt32(reader.GetValue(0).ToString());
            tempItem.ItemName = reader.GetValue(1).ToString();
            tempItem.ItemPurchasedDate = reader.GetValue(2).ToString();
            tempItem.ItemPrice = Convert.ToDecimal(reader.GetValue(3).ToString());
            tempItem.ItemQuantity = Convert.ToInt32(reader.GetValue(4).ToString());

            return tempItem;
        }
        /// <summary>
        /// executes passed query
        /// </summary>
        /// <returns></returns>
        public SqlConnection GetSqlConnection()
        {
            SqlConnection con = dbmsInstance.SettingUPConnectionWithDataBase();
            return con;
        }
        /// <summary>
        /// execute given querry
        /// </summary>
        /// <param name="insertString"></param>
        /// <param name="item"></param>
        public void ExecuteingAQuery(String insertString, Item item, SqlConnection con)
        {
            SqlCommand cmd = new SqlCommand(insertString, con);
            object o = cmd.ExecuteNonQuery();

        }
    
        /// <summary>
        /// this method is used to download data to textfile
        /// </summary>
        /// <param name="dataGridview"></param>
        public void DownloadingDataAsATextFile(DataGridView dataGridview)
        {
            TextWriter writer = new StreamWriter(@"C:\Users\Charn\Desktop\Reports.txt");          
;            for (int i =0; i<dataGridview.RowCount; i++)
            {
                for (int j=0; j<dataGridview.Columns.Count; j++)
                {
                    writer.Write( dataGridview.Rows[i].Cells[j].Value.ToString() + "\t\t" +"|");
                }
                writer.WriteLine("");
                writer.WriteLine("-----------------------------------------------------------------------------------------------------");
            }
            writer.WriteLine(" Format of the file Columns are  following");
            writer.Write("(1)Product Id followed by (2)Product Name followed by (3)Purchase Date, followed by (4)Price and followed by (5)Purchased Quanitty");
            writer.Close();
            MessageBox.Show("Reports file has been saved on Desktop");

        }
        /// <summary>
        /// this checks for primary key duplication
        /// </summary>
        /// <param name="_item"></param>
        /// <param name="con"></param>
        /// <returns></returns>
        public int PrimaryKeyCount(Item _item, SqlConnection con, string countString)
        {
            int count = 0;
            SqlCommand countCommand = new SqlCommand(countString, con);
            count = (Int32)countCommand.ExecuteScalar();
            return count;
        }
        public bool Validation(ErrorProvider error, TextBox textbox, string pattern)
        {
            if (string.IsNullOrWhiteSpace(textbox.Text))
            {
                error.SetError(textbox, "This field is required");
                return false;
            }
            else if (!Regex.IsMatch(textbox.Text, pattern))
            {
                error.SetError(textbox, "Incorrect input type");
                return false;
            }
            else
            {
                error.SetError(textbox, "");
                return true;
            }

        }

    }

}
