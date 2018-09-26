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
        public Stock_UserControl()
        {
            InitializeComponent();
        }

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

        // utiilty class can replace some part of this function
        private void button1_Click(object sender, EventArgs e)
        {
            Item item = RetreivingData();
            string insertString = StockInstance.ADDProductDetails(item);
              utitility.ExecuteingAQuery(insertString, item);
              insertString = StockInstance.UpdateStock(item);
              utitility.ExecuteingAQuery(insertString, item);
            MessageBox.Show(" :Data has been Saved");
            ClearAll();
        }
        /// <summary>
        /// 
        /// </summary>
        private void ClearAll()
        {

            ProductNOTxt.Clear();

            ProductNameTxt.Clear();

            ProductPriceTxt.Clear();

            ProductQuantityTxt.Clear();
            dateTimePicker2.Value = DateTime.Now;
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

    }
}
