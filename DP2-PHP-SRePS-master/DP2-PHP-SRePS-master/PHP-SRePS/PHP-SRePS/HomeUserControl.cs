using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PHP_SRePS
{
    public partial class HomeUserControl : UserControl
    {
        Dbms dbmsInstance = Dbms.dbmsInstance();
        Stock stockInstance = Stock.StockInstance();
        Utitility utitility = Utitility.UtitilityInstance();
        Product product = Product.ProductInstance();
        public HomeUserControl()
        {
            InitializeComponent();
            Updates();
        }

        public void Updates()
        {
            UpdatingDataBase();
            PopulatingGridView(RetrievingDataFromDataBase());
            
        }
        //

        /// <summary>

        ///  this method will be used to display data to form

        ///  it creats table and populates it with list of items

        /// </summary>

        /// <param name="item"></param>

        private void PopulatingGridView(List<Item> item)

        {

            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("Product ID");
            dataTable.Columns.Add("Product Name");
            dataTable.Columns.Add("Qunatity Left");

            for (int i = 0; i < item.Count; i++)

            {

                dataTable.Rows.Add(item[i].ItemNo, item[i].ItemName ,item[i].ItemQuantity);
                

            }
        
            home_user_control_data_grid_view.DataSource = dataTable;
            RowColourChange(home_user_control_data_grid_view);
           

        }
        //
        // was using below Method to changed color of the grid depend upon a value
        private void RowColourChange(DataGridView home_user_control_data_grid_view )
        {
           
           
              foreach(DataGridViewRow row in home_user_control_data_grid_view.Rows)
             {
                if (Convert.ToInt32(row.Cells[2].Value) < 10)
              {
                    
                    row.DefaultCellStyle.BackColor = Color.Yellow;
                    row.DefaultCellStyle.SelectionBackColor = Color.Yellow;
              }
              if(Convert.ToInt32(row.Cells[2].Value) < 3)
                {
                    row.DefaultCellStyle.BackColor = Color.Red;
                    row.DefaultCellStyle.SelectionBackColor = Color.Red;
                }
                
            }
        }
        /// <summary>

        ///

        /// it setup connection, also reads data from database tables and stores them in List of Item

        /// and returns that list

        /// </summary>



        private List<Item> RetrievingDataFromDataBase()

        {

            List<Item> ItemsList = new List<Item>();

            string viewString = stockInstance.DisplayValues();
       
            SqlConnection con = dbmsInstance.SettingUPConnectionWithDataBase();

            con.Open();

            SqlCommand cmd = new SqlCommand(viewString, con);

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())

            {

                ItemsList.Add(ItemWithValues(reader));

            }

            reader.Close();

            con.Close();

            return ItemsList;

        }
        private Item ItemWithValues(SqlDataReader reader)

        {

            Item tempItem = new Item();

            tempItem.ItemNo = Convert.ToInt32(reader.GetValue(0).ToString());
            tempItem.ItemName = reader.GetValue(1).ToString();
            tempItem.ItemQuantity = Convert.ToInt32(reader.GetValue(2).ToString());

            return tempItem;

        }

        
        private void UpdatingDataBase()
        {
            Item item = null;
            SqlConnection con = utitility.GetSqlConnection();
            con.Open();
            UpdatingProductTable(item, con);
            UpdatinSTockTable(item, con);
            con.Close();
            

        }
        private void UpdatingProductTable(Item item, SqlConnection con)
        {
            String insertString = product.CheckingItemQuantity();
            utitility.ExecuteingAQuery(insertString, item, con);
        }
        private void UpdatinSTockTable(Item item, SqlConnection con)
        {
            String insertString = stockInstance.CheckingItemQuantity();
            utitility.ExecuteingAQuery(insertString, item, con);
        }

    }
}
