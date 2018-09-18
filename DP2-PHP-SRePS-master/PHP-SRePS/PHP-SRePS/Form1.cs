using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PHP_SRePS
{
    public partial class Form1 : Form
    {
        Dbms dbmsInstance = Dbms.dbmsInstance();
        Sales salesInstance = Sales.SalesInstance();
        Prediction predictionInstance = Prediction.PredictionInstance();

        public Form1()
        {
            InitializeComponent();
        }
        private Item RetreivingData()
        {
            Item item= new Item();
            item.ItemNo = Convert.ToInt32(ProductNOTxt.Text);
            item.ItemName = ProductNameTxt.Text;
            item.ItemPrice = Convert.ToDecimal(ProductPriceTxt.Text);
            item.ItemQuantity = Convert.ToInt32(ProductQuantityTxt.Text);
            item.ItemPurchasedDate = ProductDateTxt.Text;
            return item;
        } 
        
        //
        /// <summary>
        /// this method is used to retrieve data from database;
        /// </summary>
    
        private Item ItemWithValues(SqlDataReader reader)
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
        /// this method will be used to display data to form
        /// it setup connection, also reads data from database tables and stores them in item Object
        // item object is stored in a prediction class which has a list of items 
        // from there that list can be used to populate tables on windows form
        /// </summary>
      
        private void DisplayDataOnForm()
        {
             string viewString = predictionInstance.DisplayValues();
            SqlConnection con = dbmsInstance.SettingUPConnectionWithDataBase();
            con.Open();
            SqlCommand cmd = new SqlCommand(viewString, con);
           SqlDataReader reader = cmd.ExecuteReader();
             while (reader.Read())
             {
                predictionInstance.AddItem(ItemWithValues(reader));
             }
             reader.Close();
            con.Close();
            MessageBox.Show(" :Record has been retrieved");
        }
        //
        /// <summary>
        /// this gets called when submit button has been pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void submit_Click(object sender, EventArgs e)
        {
            Item item = RetreivingData();
                
            SqlConnection con = dbmsInstance.SettingUPConnectionWithDataBase();
            con.Open();
            string insertString = salesInstance.ADDProductDetails(item);
           
            SqlCommand cmd = new SqlCommand(insertString,con);
            object o = cmd.ExecuteNonQuery();
            MessageBox.Show(" :Record has been inserted");             
            con.Close();
        }

        private void view_Click(object sender, EventArgs e)
        {
            DisplayDataOnForm();
            predictionInstance.Disp();

        }
    }
}
