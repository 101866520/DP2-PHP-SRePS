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
using System.Configuration;
using System.Windows.Forms.DataVisualization.Charting;

namespace PHP_SRePS
{
    public partial class PreDiction_UserControl : UserControl
    {
        Dbms dbmsInstance = Dbms.dbmsInstance();
        Sales sales = Sales.SalesInstance();
        Prediction predictionInstance = Prediction.PredictionInstance();
        Utitility utitility = Utitility.UtitilityInstance();
        Item selectedItem = new Item();
        int dayBetween;
        public PreDiction_UserControl()
        {
            InitializeComponent();
            DisplayItemsInComboBox();
            UserControlComponentVisibility(false);
            chart1.Visible = false;
        }
       /// <summary>
       ///  geting list of items from sales table 
       /// to push to combox(spinner) 
       /// </summary>
       /// <returns></returns>
        private List<Item > GetItems()
        {
            List<Item> ItemsList = new List<Item>();
            Item tempItem = new Item();
            string viewString = sales.GetProductNames();
            SqlConnection con = utitility.GetSqlConnection();
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

        /// <summary>
        /// it removes duplicate strings from the list
        /// it add string values to first list called newList
        /// then check for duplicate strings and if exist then removes it 
        ///it also creates new list of distinct stings and stores in another list called 
        /// </summary>
        /// <returns></returns>
        private List<String> RefinedList()
        {
            List<Item> ItemsList = GetItems();
            List<String> newList = new  List<String>();
            List<String> distinctList = new List<String>();
            foreach (Item item in ItemsList)
            {
             newList.Add(item.ItemName);             
            }
            // checking for duplication and converting it distinct list
         return distinctList = newList.Distinct().ToList();
        }

        /// <summary>
        /// populating combobox for user to select an item to see sales graph
        /// </summary>
        /// <returns></returns>      
            private void DisplayItemsInComboBox()
        {
            foreach (String item in RefinedList())
            {
                comboBox1.Items.Add(item);

            }
        }
        //Retrieve all data from Sale table and return as an item list

        private List<Item> RetrievingDataFromDataBase(string name)
        {
            List<Item> itemList = new List<Item>();
            string startDate = Convert.ToDateTime(dateTimePicker1.Value).ToString("MM/dd/yyyy");
            string endDate = Convert.ToDateTime(dateTimePicker2.Value).ToString("MM/dd/yyyy");
            dayBetween = (int)Math.Abs((dateTimePicker2.Value.Subtract(dateTimePicker1.Value)).TotalDays) + 1;
            string viewString = predictionInstance.QueryforGivenNameAndDateRange(startDate, endDate, name);
            SqlConnection con = utitility.GetSqlConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand(viewString, con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                itemList.Add(utitility.ItemWithAllValues(reader));
            }
            reader.Close();
            con.Close();
            return itemList;
        }

        //get all the values for sale amount on the processed list 
        private decimal[] getAllSales(List<Item> itemList, int[] allDays)
        {
           decimal [] result = new decimal [allDays.Count()];
            for (int i = 0; i < allDays.Count(); i++)
            {
                if (allDays[i] <=itemList.Count())
                {
                    result[i] = itemList[i].ItemPrice * itemList[i].ItemQuantity;
                }
                else
                {
                    result[i] = 0;
                }
            }
           return result;
        }
        //get all the days within the day range (dayBetween is the day difference between the dates) 
        private int[] getAllDays()
        {
            int[] result = new int[dayBetween];
            for (int i = 0; i < dayBetween; i++)
            {
                result[i] = i + 1;
            }
            return result;
        }
        //Loading the chart
        private void Prediction_UserControl_Load(List<Item> populatedItem)
        {
            int[] x = getAllDays();
            decimal [] y = getAllSales(populatedItem, x);
           chart1.Series[0].LegendText = "Test";
            chart1.Series[0].ChartType = SeriesChartType.Line;
            chart1.Series[0].IsValueShownAsLabel = true;
            chart1.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
            chart1.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;
            chart1.Series[0].Points.DataBindXY(x, y);
        }
        //Click on the button, the program will collect the selected Item (DummyItem()) and populate all the data that has the same name within the date range

        private void button1_Click(object sender, EventArgs e)
        {
            //panel1.Visible = true;
            string selectedItem = comboBox1.GetItemText(comboBox1.SelectedItem);
            List<Item> populatedItem = RetrievingDataFromDataBase(selectedItem);
            Prediction_UserControl_Load(populatedItem); // for loading chart
            chart1.Visible = true;
            ///
        }
        /// <summary>
        /// this handles user control visibility for given Predcition user control
        /// chart visibility is not handle by this method
        /// </summary>
        /// <param name="changed"> boolean change visibility</param>
        private void UserControlComponentVisibility(bool changed)
        {
            dateTimePicker1.Visible = changed;
            dateTimePicker2.Visible = changed;
            label1.Visible = changed;
            button1.Visible = changed;          
        }
        /// <summary>
        /// raised event when user selects an item from combobox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UserControlComponentVisibility(true);                          
        }
    }
}
