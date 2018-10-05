using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHP_SRePS
{
    //Report class, containing item name, total quantity, total sales, trend and avg sale
    public class ReportItem
    {
        private string medicineName;
        private int totalQuantity;
        private decimal totalSale;
        private decimal avgSale ;
        private decimal predictedSaleWeek;
        private decimal predictedSaleMonth;
        private string trend;

        public string ItemName
        {
            get
            {
                return medicineName;
            }
            set
            {
                medicineName = value;
            }
        }

        public decimal TotalSale
        {
            get
            {
                return totalSale;
            }
            set
            {
                totalSale = value;
            }
        }

        public decimal AvgSale
        {
            get
            {
                return avgSale;
            }
            set
            {
                avgSale = value;
            }
        }

        public decimal PredictedSaleWeek
        {
            get
            {
                return predictedSaleWeek;
            }
            set
            {
                predictedSaleWeek = value;
            }
        }

        public decimal PredictedSaleMonth
        {
            get
            {
                return predictedSaleMonth;
            }
            set
            {
                predictedSaleMonth = value;
            }
        }

        public int TotalQuantity
        {
            get
            {
                return totalQuantity;
            }
            set
            {
                totalQuantity = value;
            }
        }
        public string Trend
        {
            get
            {
                return trend;
            }
            set
            {
                trend = value;
            }
        }
    }
}
