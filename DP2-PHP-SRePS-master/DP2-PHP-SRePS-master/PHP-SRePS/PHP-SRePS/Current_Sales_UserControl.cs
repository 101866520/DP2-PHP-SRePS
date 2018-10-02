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
    public partial class Current_Sales_UserControl : UserControl
    {
        Dbms dbmsInstance = Dbms.dbmsInstance();
        StockSales stockSales = StockSales.StockSalesInstance();
        Stock stock = Stock.StockInstance();
        Sales sales = Sales.SalesInstance();
        Utitility utitility = Utitility.UtitilityInstance();
        Product product = Product.ProductInstance();

        public Current_Sales_UserControl()
        {
            InitializeComponent();
            Init();
        }
        public void Init()
        {       
            PopulatingList(RetrievingDataFromDataBase());
        }

        private List<Item> RetrievingDataFromDataBase()
        {
            List<Item> ItemsList = new List<Item>();
            SqlConnection con = dbmsInstance.SettingUPConnectionWithDataBase();
            con.Open();
            string insertString = stockSales.GetProductNameForList();
            SqlCommand cmd = new SqlCommand(insertString, con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ItemsList.Add(ItemWithValues(reader));
            }
            reader.Close();
            con.Close();
            return ItemsList;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        private void RetrievingAllDataFromDataBase(Item item)
        {
            string viewString = stockSales.GetProductDetails(item);
            SqlConnection con = dbmsInstance.SettingUPConnectionWithDataBase();
            con.Open();
            SqlCommand cmd = new SqlCommand(viewString, con);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())

            {
                PushDataToTextBox(utitility.ItemWithAllValues(reader));
            }
            reader.Close();
            con.Close();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        private void PushDataToTextBox(Item item)
        {
            DateTime dateTime = DateTime.UtcNow.Date;
            ProductNameTxt.Text = item.ItemName;
            dateTimePicker1.Value = dateTime;
            ProductQuantityTxt.Text = item.ItemQuantity.ToString();
            ProductPriceTxt.Text = item.ItemPrice.ToString();
        }


        private void UpdatingSalesTable(Item item)
        {
            SqlConnection con = utitility.GetSqlConnection();
            Item _item = new Item();        
            String insertString2 = null;
            con.Open();
            string insertString = stockSales.GetProductDetails(item);
            //string countString = sales.CheckingPrimaryKeyForDuplication(_item);
            SqlCommand cmd = new SqlCommand(insertString, con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                _item = utitility.ItemWithAllValues(reader);
                _item.ItemQuantity = item.ItemQuantity;
                _item.ItemPurchasedDate = Convert.ToDateTime(dateTimePicker1.Value).ToString("MM/dd/yyyy");
            
            }
            reader.Close();
            try
           {
                if (PrimaryKeyCount(_item, con) > 0)
                {
                    insertString2 = sales.AlterDetailsForCurrentSale(_item);
                    utitility.ExecuteingAQuery(insertString2, _item, con);
                }
                else
                {
                    insertString2 = sales.ADDProductDetails(_item);
                    utitility.ExecuteingAQuery(insertString2, _item, con);
                }
               
            }catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            con.Close();
        }
        /// <summary>
        /// look for replacement in utility class
        /// </summary>
        /// <param name="_item"></param>
        /// <param name="con"></param>
        /// <returns></returns>
        private int PrimaryKeyCount(Item _item, SqlConnection con)
        {
            int count=0;
            string countString = sales.CheckingPrimaryKeyForDuplication(_item);
            SqlCommand countCommand = new SqlCommand(countString, con);
            count = (Int32)countCommand.ExecuteScalar();
            return count;
        }
       

        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        private void PopulatingList(List<Item> item)
        {
            currentsaleslistView.Items.Clear();

            for (int i = 0; i < item.Count; i++)
            {
                currentsaleslistView.Items.Add(item[i].ItemName);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="reader"></param>
        /// <returns></returns>
        private Item ItemWithValues(SqlDataReader reader)
        {
            Item tempItem = new Item();
          tempItem.ItemName = reader.GetValue(0).ToString();
            return tempItem;
       }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rent_sale_user_control_Click(object sender, EventArgs e)
        {
            Item tempItem = new Item();
            tempItem.ItemName = ProductNameTxt.Text;
            tempItem.ItemQuantity = Convert.ToInt32(ProductQuantityTxt.Text);
            string insertString = product.UpdateProductTable(tempItem);
            SqlConnection con = utitility.GetSqlConnection();
            con.Open();
            utitility.ExecuteingAQuery(insertString, tempItem, con);
            insertString = stock.UpdateStockTable(tempItem);
            utitility.ExecuteingAQuery(insertString, tempItem, con);
            UpdatingSalesTable(tempItem);        
            ClearAll();
            con.Close();
            panel1.Visible = false;
        }
        private void ClearAll()
        {
            ProductNameTxt.Clear();
            ProductPriceTxt.Clear();
            ProductQuantityTxt.Clear();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void currentsaleslistView_ItemActivate(object sender, EventArgs e)
        {
            Item tempItem = new Item();
            tempItem.ItemName = currentsaleslistView.SelectedItems[0].Text;
            panel1.Visible = true;
            RetrievingAllDataFromDataBase(tempItem);
        }
    }
}
