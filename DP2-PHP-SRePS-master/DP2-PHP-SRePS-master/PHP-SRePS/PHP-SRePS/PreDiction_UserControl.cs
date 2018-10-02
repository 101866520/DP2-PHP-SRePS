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
        Prediction predictionInstance = Prediction.PredictionInstance();
        Utitility utitility = Utitility.UtitilityInstance();

        Item selectedItem = new Item();
        int dayBetween;

        //Dummy item, to put select item here
        private Item DummyItem()
        {
            Item item = new Item();
            item.ItemName = "Paracetamol";

            return item;
        }

        public PreDiction_UserControl()
        {
            InitializeComponent();
        }

        //Retrieve all data from Sale table and return as an item list
        private List<Item> RetrievingDataFromDataBase()
        {
            List<Item> ItemsList = new List<Item>();
            string startDate = Convert.ToDateTime(dateTimePicker1.Value).ToString("MM/dd/yyyy");
            string endDate = Convert.ToDateTime(dateTimePicker2.Value).ToString("MM/dd/yyyy");
            dayBetween = (int)Math.Abs((dateTimePicker2.Value.Subtract(dateTimePicker1.Value)).TotalDays)+1;
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

        //After collecting the item list from the database, select only the ones with a matching name and put it into a new list, then return to this function
        private List<Item> PopulateItemForPrediction(List<Item> ogdata, Item ogitem)
        {
            List<Item> result = new List<Item>();
            //finding all item with the same item no
            for (int i = 0; i < ogdata.Count; i++)
            {
                if (ogdata[i].ItemName == ogitem.ItemName)
                {
                    result.Add(ogdata[i]);
                }
            }
            return result;
        }
        
        //get all the values for sale amount on the processed list 
        private decimal[] getAllSales(List<Item> itemList, int[] allDays)
        {
            decimal[] result = new decimal[allDays.Count()];
            for (int i = 0; i < allDays.Count(); i++)
            {
                if (allDays[i] != 0)
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
            for (int i = 0; i < dayBetween; i++ )
            {
                result[i] = i+1;
            }

            return result;
        }

        //Loading the chart
        private void Prediction_UserControl_Load(List<Item> populatedItem)
        {
            int[] x = getAllDays(); 

            decimal[] y = getAllSales(populatedItem, x);

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
            panel1.Visible = true;
            selectedItem = DummyItem();
            List<Item> populatedItem = PopulateItemForPrediction(RetrievingDataFromDataBase(), selectedItem);
            Prediction_UserControl_Load(populatedItem); // for loading chart
        }
    }
}
