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
    public partial class RecordsUserControl : UserControl
    {
        Dbms dbmsInstance = Dbms.dbmsInstance();
        Sales salesInstance = Sales.SalesInstance();
        Utitility utitility = Utitility.UtitilityInstance();
        
        public RecordsUserControl()
        {
            InitializeComponent();
        }
        /// <summary>
        /// retireve data from form and add it to item object
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
        /// updates sales table 
        /// </summary>
        /// <param name="item"></param>
        public void UpdateSalesTable(Item item)
        {
            string insertString = null;
            String countstring = salesInstance.CheckingPrimaryKeyForDuplication(item);
            SqlConnection con = utitility.GetSqlConnection();
            con.Open();
            if(StockExist(con, countstring, item))
            {
                
                insertString = salesInstance.AlterDetails(item);
            }
            else
            {
                insertString = salesInstance.ADDProductDetails(item);
            }
            
            utitility.ExecuteingAQuery(insertString, item, con);
            con.Close();
        }

       

        /// <summary>

        /// this gets called when save button has been pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                MessageBox.Show("One or more input is missing or invalid");
            }
            else
            {
                Item item = RetreivingData();
                UpdateSalesTable(item);
                ClearAll();
                MessageBox.Show(" :Record has been inserted");
            }
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

        private void ClearAll()

        {
            ProductNOTxt.Clear();
            ProductNameTxt.Clear();
            ProductPriceTxt.Clear();
            ProductQuantityTxt.Clear();
            dateTimePicker2.Value = DateTime.Now;

        }

        private void ProductNoTxt_Validating(object sender, CancelEventArgs e)
        {
            utitility.Validation(errorProviderRecord, ProductNOTxt, @"\d");
        }

        private void productQuantityTxt_Vaidating(object sender, CancelEventArgs e)
        {
            utitility.Validation(errorProviderRecord, ProductQuantityTxt, @"\d");
        }

        private void productPriceTxt_Validating(object sender, CancelEventArgs e)
        {
            utitility.Validation(errorProviderRecord, ProductPriceTxt, @"\d{1,18}(.\d{3})?");
        }

        private void productNameTxt_Validating(object sender, CancelEventArgs e)
        {
            utitility.Validation(errorProviderRecord, ProductNameTxt, @"[A-Za-z\d\s-_]+");
        }
    }
}
