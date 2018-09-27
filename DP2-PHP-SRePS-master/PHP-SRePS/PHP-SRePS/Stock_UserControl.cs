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
    public partial class Stock_UserControl : UserControl
    {
        Dbms dbmsInstance = Dbms.dbmsInstance();
        Stock StockInstance = Stock.StockInstance();
        Utitility utitility = Utitility.UtitilityInstance();
        Product product = Product.ProductInstance();
        public Stock_UserControl()
        {
            InitializeComponent();
        }
        /// <summary>
        /// capture data from form text field and stores in item object
        /// </summary>
        /// <returns></returns>
        private Item RetreivingData()
        {
            Item item = new Item();
            item.ItemNo = Convert.ToInt32(ProductNOTxt.Text);
            item.ItemName = ProductNameTxt.Text;
            item.ItemPrice = Convert.ToDecimal(ProductPriceTxt.Text);
            item.ItemQuantity = Convert.ToInt32(ProductQuantityTxt.Text);
            item.ItemPurchasedDate = Convert.ToDateTime(dateTimePicker2.Value).ToString("MM/dd/yyyy");
            return item;

        }
        /// <summary>
        /// it check if stock exist or not 
        /// returns bool based on condition
        /// </summary>
        /// <param name="con">sqlconnection</param>
        /// <param name="countString"> string to perform querry</param>
        /// <param name="item"> item object</param>
        /// <returns></returns>
        private bool StockExist(SqlConnection con, string countString, Item item)
        {
            if (utitility.PrimaryKeyCount(item, con, countString) > 0)
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// it updates table 
        /// </summary>
        /// <param name="insertString"> string to update product table</param>
        /// <param name="stockString"> string to update stock table</param>
        /// <param name="item"></param>
        /// <param name="con"></param>
        public void UpdatingTable(String insertString, String stockString, Item item, SqlConnection con)
        {
            utitility.ExecuteingAQuery(insertString, item, con);            
            utitility.ExecuteingAQuery(stockString, item, con);
        }

        /// <summary>
        /// it updates both stock and Product table
        /// checkes if stock exist , if it does then alter product and stock table
        /// </summary>
        /// <param name="item"> item object </param>
        public void UpdateStockNProductTable(Item item)
        {
            String insertString = null;
            String stockString = null;
            string countString = StockInstance.CheckingPrimaryKeyForDuplication(item);
            SqlConnection con = utitility.GetSqlConnection();
            con.Open();        
            if (StockExist(con, countString, item))
            {
                MessageBox.Show(StockExist(con, countString, item).ToString());
;               insertString = product.AlterProductDetails(item);
                stockString = StockInstance.UpDateStockForExistingProduct(item);
                UpdatingTable(insertString,stockString, item, con);
            }
            else
            {
                MessageBox.Show(StockExist(con, countString, item).ToString());
                insertString = product.ADDProductDetails(item);
                stockString = StockInstance.UpdateStock(item);
                UpdatingTable(insertString, stockString, item, con);
            }
            con.Close();
        }

        /// <summary>
        /// save button class update stock and product table
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            Item item = RetreivingData();           
            UpdateStockNProductTable(item);
            ClearAll();
            MessageBox.Show(" :Data has been Saved");
        }

        /// <summary>
        /// clear form text fields
        /// </summary>
        private void ClearAll()
        {

            ProductNOTxt.Clear();

            ProductNameTxt.Clear();

            ProductPriceTxt.Clear();

            ProductQuantityTxt.Clear();
            dateTimePicker2.Value = DateTime.Now;
        }
        /// <summary>
        /// reset button 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Reset_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

    }
}
