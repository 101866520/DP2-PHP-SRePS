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
        /// <summary>
        /// retireve data from form and add it to item object
        /// </summary>
        /// <returns></returns>
        private Item RetreivingData()
        {
            Item item= new Item();
            item.ItemNo = Convert.ToInt32(ProductNOTxt.Text);
            item.ItemName = ProductNameTxt.Text;
            item.ItemPrice = Convert.ToDecimal(ProductPriceTxt.Text);
            item.ItemQuantity = Convert.ToInt32(ProductQuantityTxt.Text);
            item.ItemPurchasedDate = Convert.ToDateTime(dateTimePicker2.Value).ToString("MM/dd/yyyy");
            return item;
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
            dataTable.Columns.Add("Purchased Date");
            dataTable.Columns.Add("Product Price");
            dataTable.Columns.Add("Purchased Qunatity");
            for (int i = 0; i < item.Count; i++)
            {
                dataTable.Rows.Add(item[i].ItemNo, item[i].ItemName, item[i].ItemPurchasedDate, item[i].ItemPrice, item[i].ItemQuantity);
               
            }
            dataGridview.DataSource = dataTable;
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
        ///
        /// it setup connection, also reads data from database tables and stores them in List of Item
        /// and returns that list
        /// </summary>
     
        private List<Item> RetrievingDataFromDataBase()
        {
            List<Item> ItemsList = new List<Item>();
            string startDate = Convert.ToDateTime(dateTimePicker3.Value).ToString("MM/dd/yyyy");
            string endDate = Convert.ToDateTime(dateTimePicker1.Value).ToString("MM/dd/yyyy");
            string viewString = predictionInstance.DisplayValues(startDate, endDate);
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
            ClearAll();
        }

        private void view_Click(object sender, EventArgs e)
        {    
            PopulatingGridView(RetrievingDataFromDataBase());
        }
        //
        // unable to push date datepicker
        private void dataGridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                EditForm editForm = new EditForm();
                DataGridViewRow rows = this.dataGridview.Rows[e.RowIndex];
                editForm.ProductNOTxt.Text= rows.Cells["Product ID"].Value.ToString();
                editForm.ProductNameTxt.Text = rows.Cells["Product Name"].Value.ToString();
                editForm.ProductPriceTxt.Text= rows.Cells["Product Price"].Value.ToString();
                editForm.ProductQuantityTxt.Text= rows.Cells["Purchased Qunatity"].Value.ToString();
                editForm.dateTimePicker2.Value =Convert.ToDateTime(rows.Cells["Purchased Date"].Value.ToString());
                editForm.Show();                
               
            }
            
        }
        
        private void ClearAll()
        {
            ProductNOTxt.Clear();
            ProductNameTxt.Clear();
            ProductPriceTxt.Clear();
            ProductQuantityTxt.Clear();
            dateTimePicker2.Value = DateTime.Now;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

      

    }
}
