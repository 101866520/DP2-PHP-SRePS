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
    public partial class EditForm : Form
    
    {
        Dbms dbmsInstance = Dbms.dbmsInstance();
        Sales salesInstance = Sales.SalesInstance();
        Prediction predictionInstance = Prediction.PredictionInstance();
        public EditForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// this method retrieve data from edit form input fields
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
        /// update button
       /// is used to modify existing table;
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            Item item = RetreivingData();
            SqlConnection con = dbmsInstance.SettingUPConnectionWithDataBase();
            con.Open();
            string alterString = salesInstance.AlterDetails(item);
            SqlCommand cmd = new SqlCommand(alterString, con);
            object o = cmd.ExecuteNonQuery();
            MessageBox.Show(" :Record has been Updated");
            con.Close();
            this.Close();

        }
       
       
        /// <summary>
        /// Delete button for edit form
        /// will delete enitre row based on selection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            Item item = RetreivingData();

            SqlConnection con = dbmsInstance.SettingUPConnectionWithDataBase();
            con.Open();
            string deleteString = salesInstance.DeleteData(item);
            SqlCommand cmd = new SqlCommand(deleteString, con);
            object o = cmd.ExecuteNonQuery();
            MessageBox.Show(" :Record has been deleted");
            con.Close();
            this.Close();
        }

      
    }
}
