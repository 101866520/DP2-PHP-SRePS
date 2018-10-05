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
        private List<Item> GetItems()
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
        private int[] getAllDays(List<Item> itemList)
        {
            int[] result = new int[itemList.Count()];
            for (int i = 0; i < itemList.Count(); i++)
            {
                result[i] = i + 1;
            }
            return result;
        }
        private void GenerateTrendLine(Tuple<decimal, decimal> line, List<Item> itemList)
        {
            DataPoint[] points = new DataPoint[2];
            double x1 = 1, x2 = itemList.Count();

            //y = aX + b
            double y1 = Convert.ToDouble(line.Item1) * x1 + Convert.ToDouble(line.Item2);
            double y2 = Convert.ToDouble(line.Item1) * x2 + Convert.ToDouble(line.Item2);
            points[0] = new DataPoint(x1, y1);
            points[1] = new DataPoint(x2, y2);

            chart1.Series.Add("Trend");
            chart1.Series["Trend"].Points.Add(points[0]);
            chart1.Series["Trend"].Points.Add(points[1]);
            chart1.Series["Trend"].BorderWidth = 3;
            chart1.Series["Trend"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
        }

        private void GenerateAvgLine(List<Item> itemList)
        {
            double x1 = 1, x2 = itemList.Count();
            double y = Convert.ToDouble(predictionInstance.AvgSale(itemList));
            DataPoint[] points = new DataPoint[2];
            points[0] = new DataPoint(x1, y);
            points[1] = new DataPoint(x2, y);

            chart1.Series.Add("Average");
            chart1.Series["Average"].Color = Color.Black;
            chart1.Series["Average"].Points.Add(points[0]);
            chart1.Series["Average"].Points.Add(points[1]);
            chart1.Series["Average"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chart1.Series["Average"].BorderDashStyle = ChartDashStyle.Dash;
            
        }

        //Loading the chart
        private void Prediction_UserControl_Load(List<Item> populatedItem)
        {
            chart1.Series.Clear();
            int[] x = getAllDays(populatedItem);
            decimal [] y = getAllSales(populatedItem, x);
            chart1.Series.Add("Sale");
            chart1.Series["Sale"].ChartType = SeriesChartType.Line;
            chart1.Series["Sale"].BorderWidth = 2;
            chart1.Series["Sale"].IsValueShownAsLabel = true;
            chart1.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
            chart1.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;
            chart1.Series["Sale"].Points.DataBindXY(x, y);

            GenerateTrendLine(predictionInstance.TrendLine(populatedItem), populatedItem);
            GenerateAvgLine(populatedItem);
        }

        //Click on the button, the program will collect the selected Item (DummyItem()) and populate all the data that has the same name within the date range

        private void button1_Click(object sender, EventArgs e)
        {
            //panel1.Visible = true;
            string selectedItem = comboBox1.GetItemText(comboBox1.SelectedItem);
            List<Item> populatedItem = RetrievingDataFromDataBase(selectedItem);
            Prediction_UserControl_Load(populatedItem); // for loading chart
            chart1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            PopulateGridView(predictionInstance.GenerateReport(populatedItem), DataTable());
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

        private void PopulateGridView(List<ReportItem> reportList, DataTable dataTable)
        {
            for (int i = 0; i < reportList.Count; i++)
            {
                dataTable.Rows.Add(reportList[i].ItemName, reportList[i].TotalSale, reportList[i].TotalQuantity, reportList[i].AvgSale, reportList[i].PredictedSaleWeek, reportList[i].PredictedSaleMonth, reportList[i].Trend);
            }
            dataGridView1.DataSource = dataTable;
        }

        private DataTable DataTable()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Product Name");
            dataTable.Columns.Add("Total Sale");
            dataTable.Columns.Add("Total Quantity Sold");
            dataTable.Columns.Add("Average Sale");
            dataTable.Columns.Add("Predicted Sale (Week)");
            dataTable.Columns.Add("Predicted Sale (Month)");
            dataTable.Columns.Add("Trend");

            return dataTable;
        }

        private void SwitchViews()
        {
            string text1 = "Table View";
            string text2 = "Graph View";
            if (button2.Text == text2)
            {
                //if (!chart1.Visible)
                //{
                    chart1.Visible = true;
                    dataGridView1.Visible = false;
                //}

                button2.Text = text1;
            }
            else if (button2.Text == text1)
            {
                chart1.Visible = false;
                dataGridView1.Visible = true;
                button2.Text = text2;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SwitchViews();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            utitility.DownloadingDataAsATextFile(dataGridView1, "Predictions");
        }
    }
}
