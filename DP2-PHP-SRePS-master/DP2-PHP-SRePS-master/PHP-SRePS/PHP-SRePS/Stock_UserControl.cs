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
        private List<bool> validated = new List<bool>();
        public Stock_UserControl()
        {
            InitializeComponent();
            FormVisibility(false);
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
               insertString = product.AlterProductDetails(item);
                stockString = StockInstance.UpDateStockForExistingProduct(item);
                UpdatingTable(insertString,stockString, item, con);
            }
            else
            {
                insertString = product.ADDProductDetails(item);
                stockString = StockInstance.UpdateStock(item);
                UpdatingTable(insertString, stockString, item, con);
            }
            con.Close();
        }

        /// <summary>
        /// it will populate the table with pree-existing data from database
        ///
        /// </summary>
        /// <param name="item"></param>
        private void PopulatingTable(Item item)
        {
            DateTime dateTime = DateTime.UtcNow.Date;
            ProductNameTxt.Text = item.ItemName;
            dateTimePicker2.Value = dateTime;
            ProductQuantityTxt.Text = item.ItemQuantity.ToString();
            ProductPriceTxt.Text = item.ItemPrice.ToString();
            FormInputFieldBehaviour(true);
        }
        /// <summary>
        /// setting form fields to read only or not
        /// </summary>
        /// <param name="decision"></param>
        private void FormInputFieldBehaviour(bool decision)
        {
            ProductNameTxt.ReadOnly = decision;
            ProductNOTxt.ReadOnly = decision;

        }

        /// <summary>
        /// this will look for product in database
        /// </summary>
        /// <param name="item"></param>
        private void Searching(Item item)
        {
            SqlConnection con = utitility.GetSqlConnection();
            String countString = product.CheckingPrimaryKeyForDuplication(item);
            con.Open();
            if (StockExist(con, countString, item))
            {
                SearchForProduct(con, item);
            }
        }
        /// <summary>
        /// this will search the product in the database, if exist prefill the details of the table
        /// </summary>
        /// <param name="con"></param>
        /// <param name="item"></param>
        private void SearchForProduct(SqlConnection con, Item item)
        {
            String viewString = product.GetProductDetails(item);
            SqlCommand cmd = new SqlCommand(viewString, con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                PopulatingTable(utitility.ItemWithAllValues(reader));
            }
            reader.Close();
            con.Close();
        }
        private void FormVisibility(bool decison)
        {
            ProductNameTxt.Visible = decison;
            ProductPriceTxt.Visible = decison;
            ProductQuantityTxt.Visible = decison;
            dateTimePicker2.Visible = decison;
            button1.Visible = decison;
            Reset.Visible = decison;
            label2.Visible = decison;
            label3.Visible = decison;
            label4.Visible = decison;
            label5.Visible = decison;


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
            FormVisibility(false);
            searchButton.Visible = true;
            FormInputFieldBehaviour(false);
            ClearAll();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            validated.Clear();
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                if (validated.Contains(false))
                {
                    MessageBox.Show("Product no input is missing or invalid");
                }
                else
                {
                    Item item = new Item();
                    item.ItemNo = Convert.ToInt32(ProductNOTxt.Text);
                    Searching(item);
                    searchButton.Visible = false;
                    FormVisibility(true);
                }
                
            }
           
        }

        /// <summary>
        /// save button class update stock and product table
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
                validated.Clear();
                if (ValidateChildren(ValidationConstraints.Enabled))
                {
                    if (validated.Contains(false))
                    {
                    
                        MessageBox.Show("One or more input is missing or invalid");
                    }
                    else
                    {
                        Item item = RetreivingData();
                        UpdateStockNProductTable(item);
                        FormVisibility(false);
                        searchButton.Visible = true;
                        FormInputFieldBehaviour(false);
                        ClearAll();
                        MessageBox.Show(" :Data has been Saved");
                    }
                }
           
            
        }

        private void ProductNOTxt_Validating(object sender, CancelEventArgs e)
        {
            if (ProductNOTxt.Visible)
            {
                validated.Add(utitility.Validation(errorProviderStock, ProductNOTxt, @"\d"));
            }
          
        }

        private void ProductQuantityTxt_Validating(object sender, CancelEventArgs e)
        {
            if (ProductQuantityTxt.Visible)
            {
                validated.Add(utitility.Validation(errorProviderStock, ProductQuantityTxt, @"\d"));
            }
            
        }

        private void ProductPriceTxt_Validating(object sender, CancelEventArgs e)
        {
            if (ProductPriceTxt.Visible)
            {
                validated.Add(utitility.Validation(errorProviderStock, ProductPriceTxt, @"\d{1,18}(.\d{3})?"));
            }
            
        }

        private void ProductNameTxt_Validating(object sender, CancelEventArgs e)
        {
            if (ProductNameTxt.Visible)
            {
                validated.Add(utitility.Validation(errorProviderStock, ProductNameTxt, @"[A-Za-z\d\s-_]+"));
            }
            
        }
        
    }
}
