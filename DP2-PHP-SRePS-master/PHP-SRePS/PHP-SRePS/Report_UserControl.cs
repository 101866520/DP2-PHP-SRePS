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
    public partial class Report_UserControl : UserControl
    {
        Dbms dbmsInstance = Dbms.dbmsInstance();
        Prediction predictionInstance = Prediction.PredictionInstance();
        Utitility utitility = Utitility.UtitilityInstance();
        public Report_UserControl()
        {
            InitializeComponent();
        }
        /// <summary>
        /// display buttton to display table with values
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            PopulatingGridView(RetrievingDataFromDataBase(), DataTable());
            download_reports_button.Visible = true;
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
                ItemsList.Add(utitility.ItemWithAllValues(reader));
            }
            reader.Close();
            con.Close();
            return ItemsList;
        }
        //
        /// <summary>
        ///  this method will be used to display data to form
        ///  it creats table and populates it with list of items
        /// </summary>
        /// <param name="item"></param>
        /// 
        private DataTable DataTable()
        {
            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("Product ID");

            dataTable.Columns.Add("Product Name");

            dataTable.Columns.Add("Purchased Date");

            dataTable.Columns.Add("Product Price");

            dataTable.Columns.Add("Purchased Qunatity");
            return dataTable;
        }
        /// <summary>
        ///  populating grid view with table data
        /// </summary>
        /// <param name="item"></param>
        /// <param name="dataTable"></param>
        private void PopulatingGridView(List<Item> item, DataTable dataTable)

        {
            for (int i = 0; i < item.Count; i++)

            {
                dataTable.Rows.Add(item[i].ItemNo, item[i].ItemName, item[i].ItemPurchasedDate, item[i].ItemPrice, item[i].ItemQuantity);
            }
            dataGridview.DataSource = dataTable;
        }
        /// <summary>
        /// download button let user download text file with displayed data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void download_reports_button_Click(object sender, EventArgs e)
        {
            utitility.DownloadingDataAsATextFile(dataGridview);
            download_reports_button.Visible = false;
        }
        /// <summary>
        /// this method is called when cell contents double clicked 
        /// open up new form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridview_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            EditForm editForm = new EditForm();

            DataGridViewRow rows = this.dataGridview.Rows[e.RowIndex];

            editForm.ProductNOTxt.Text = rows.Cells["Product ID"].Value.ToString();

            editForm.ProductNameTxt.Text = rows.Cells["Product Name"].Value.ToString();

            editForm.ProductPriceTxt.Text = rows.Cells["Product Price"].Value.ToString();

            editForm.ProductQuantityTxt.Text = rows.Cells["Purchased Qunatity"].Value.ToString();

            editForm.dateTimePicker2.Value = Convert.ToDateTime(rows.Cells["Purchased Date"].Value.ToString());
            download_reports_button.Visible = false;
            editForm.Show();
        }
    }
}
