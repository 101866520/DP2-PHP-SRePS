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
        private List<bool> validated = new List<bool>();
        public RecordsUserControl()
        {
            InitializeComponent();
            FormVisibility(false);
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
        /// it will populate the table with pree-existing data from database
        ///
        /// </summary>
        /// <param name="item"></param>
        private void PopulatingTable( Item item)
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
            String countString = salesInstance.CheckingPrimaryKeyForDuplication(item);
            con.Open();
            if (utitility.StockExist(con, countString, item))
            {
                SeachForProduct(con, item);
            }
        }
        /// <summary>
        /// this will search the product in the database, if exist prefill the details of the table
        /// </summary>
        /// <param name="con"></param>
        /// <param name="item"></param>
        private void SeachForProduct(SqlConnection con,Item item)
        {
            String viewString = salesInstance.GetProductDetails(item);          
            SqlCommand cmd = new SqlCommand(viewString, con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                PopulatingTable(utitility.ItemWithAllValues(reader));
            }
            reader.Close();
            con.Close();
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
            if(utitility.StockExist(con, countstring, item))
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
                    UpdateSalesTable(item);
                    ClearAll();
                    FormVisibility(false);
                    searchButton.Visible = true;
                    FormInputFieldBehaviour(false);
                    MessageBox.Show(" :Record has been inserted");
                }
            }
            
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

        private void ClearAll()

        {
            ProductNOTxt.Clear();
            ProductNameTxt.Clear();
            ProductPriceTxt.Clear();
            ProductQuantityTxt.Clear();
            dateTimePicker2.Value = DateTime.Now;
        }

        private void  FormVisibility(bool decison)
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

        private void searchButton_Click(object sender, EventArgs e)
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
                    Item item = new Item();
                    item.ItemNo = Convert.ToInt32(ProductNOTxt.Text);
                    Searching(item);
                    searchButton.Visible = false;
                    FormVisibility(true);
                }

            }
        }

        private void ProductNOTxt_Validating(object sender, CancelEventArgs e)
        {
            if (ProductNOTxt.Visible)
            {
                validated.Add(utitility.Validation(errorProviderRecord, ProductNOTxt, @"\d"));
            }

        }

        private void ProductQuantityTxt_Validating(object sender, CancelEventArgs e)
        {
            if (ProductQuantityTxt.Visible)
            {
                validated.Add(utitility.Validation(errorProviderRecord, ProductQuantityTxt, @"\d"));
            }

        }

        private void ProductPriceTxt_Validating(object sender, CancelEventArgs e)
        {
            if (ProductPriceTxt.Visible)
            {
                validated.Add(utitility.Validation(errorProviderRecord, ProductPriceTxt, @"\d{1,18}(.\d{3})?"));
            }

        }

        private void ProductNameTxt_Validating(object sender, CancelEventArgs e)
        {
            if (ProductNameTxt.Visible)
            {
                validated.Add(utitility.Validation(errorProviderRecord, ProductNameTxt, @"[A-Za-z\d\s-_]+"));
            }

        }
    }
}
