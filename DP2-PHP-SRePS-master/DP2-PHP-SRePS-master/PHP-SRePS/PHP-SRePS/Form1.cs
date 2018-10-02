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
        
        Sales salesInstance = Sales.SalesInstance();
        Prediction predictionInstance = Prediction.PredictionInstance();
        Current_Sales_UserControl current_Sales_UserControl = new Current_Sales_UserControl();
        HomeUserControl homeUserControl = new HomeUserControl();
        Stock_UserControl stock_UserControl = new Stock_UserControl();
        Report_UserControl report_UserControl = new Report_UserControl();
        PreDiction_UserControl preDiction_UserControl = new PreDiction_UserControl();
        RecordsUserControl recordsUserControl = new RecordsUserControl();

        public Form1()
        {
            InitializeComponent();
            Init();
        }
        private void Init()
        {
            scrolPanel.Height = home_button.Height;
            scrolPanel.Top = home_button.Top;
            user_control_container_panel.Controls.Add(homeUserControl);
            homeUserControl.BringToFront();
        }

        private void home_button_Click(object sender, EventArgs e)
        {
            Init();
            homeUserControl.Updates();
        }

        private void current_sales_button_Click(object sender, EventArgs e)
        {
            scrolPanel.Height = current_sales_button.Height;
            scrolPanel.Top = current_sales_button.Top;
            user_control_container_panel.Controls.Add(current_Sales_UserControl);
            current_Sales_UserControl.BringToFront();
            current_Sales_UserControl.Init();
           
                 
        }

        private void stock_button_Click(object sender, EventArgs e)
        {
            scrolPanel.Height =stock_button.Height;
            scrolPanel.Top = stock_button.Top;
            user_control_container_panel.Controls.Add(stock_UserControl);
            stock_UserControl.BringToFront();



        }

        private void reports_button_Click(object sender, EventArgs e)
        {
            scrolPanel.Height = reports_button.Height;
            scrolPanel.Top = reports_button.Top;
            user_control_container_panel.Controls.Add(report_UserControl);
            report_UserControl.BringToFront();
            
        }

        private void previously_sold_record_button_Click(object sender, EventArgs e)
        {
            scrolPanel.Height = previously_sold_record_button.Height;
            scrolPanel.Top = previously_sold_record_button.Top;
            user_control_container_panel.Controls.Add(recordsUserControl);
            recordsUserControl.BringToFront();
        }

        private void prediction_button_Click(object sender, EventArgs e)
        {
            scrolPanel.Height = prediction_button.Height;
            scrolPanel.Top = prediction_button.Top;
            user_control_container_panel.Controls.Add(preDiction_UserControl);
            preDiction_UserControl.BringToFront();
        }
    }
}
