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
        //

        /// <summary>

        /// this gets called when save button has been pressed

        /// </summary>

        /// <param name="sender"></param>

        /// <param name="e"></param>

        private void button1_Click(object sender, EventArgs e)
        {
            Item item = RetreivingData();
            string insertString = salesInstance.ADDProductDetails(item);
            utitility.ExecuteingAQuery(insertString, item);
            MessageBox.Show(" :Record has been inserted");
            ClearAll();
        }

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
    }
}
