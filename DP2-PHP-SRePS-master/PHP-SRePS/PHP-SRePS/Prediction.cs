using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Configuration;

namespace PHP_SRePS
{
    /// <summary>
    /// Prediction. class will predict 
    /// predict sales on monthly and weekly basis
    /// will also let user download sales and edit information 
    /// if needed
    /// </summary>
    public class Prediction
    {
 
        private static Prediction prediction = null;
        public Prediction()
        {
        }
        public static Prediction PredictionInstance()
        {
            if (prediction == null)
            {
                prediction = new Prediction();
            }
            return prediction;
        }

        public string QueryforGivenNameAndDateRange(string startDate, string endDate, String name)
        {
            string viewString = @"select * from sale where product_name ='" + name + "' and product_purchased_date between '" + startDate + "'and'" + endDate + "'";
            return viewString;
        }


        public  string DisplayValues(string startDate, string endDate)
        {
            string viewString = @"select * from sale where product_purchased_date between '" + startDate + "'and'" + endDate +"'" ;
            return viewString;
        }

        private decimal TotalSale(List<Item> itemList)
        {
            decimal result = 0;

            foreach (Item item in itemList)
            {
                result += item.ItemQuantity * item.ItemPrice;
            }

            return result;
        }

        private int TotalQuantity(List<Item> itemList)
        {
            int result = 0;

            foreach (Item item in itemList)
            {
                result += item.ItemQuantity;
            }

            return result;
        }

        public Tuple<decimal, decimal> TrendLine(List<Item> itemList)
        {
            decimal a = 0, b = 0, totalDay = 0, totalDaySale = 0, totalDaySqr = 0;
            int i = 0, n = itemList.Count;

            decimal totalSale = TotalSale(itemList);
            foreach (Item item in itemList)
            {
                i += 1;
                totalDay += i;
                totalDaySale += i * item.ItemQuantity * item.ItemPrice;
                totalDaySqr += i * i;
            }

            //Y = aX + b
            a = (n * totalDaySale - totalDay * totalSale) / (n * totalDaySqr - totalDay * totalDay);
            b = (totalSale * totalDaySqr - totalDay * totalDaySale) / (n * totalDaySqr - totalDay * totalDay);

            return Tuple.Create<decimal, decimal>(a, b);
        }

        public decimal AvgSale(List<Item> itemList)
        {
            decimal totalSale = 0, result;

            foreach (Item item in itemList)
            {
                totalSale += item.ItemQuantity * item.ItemPrice;
            }

            result = totalSale / itemList.Count;
            return result;
        }

        public decimal PredictingSale(List<Item> itemList, Tuple<decimal, decimal> tline, int duration)
        {
            decimal avg = AvgSale(itemList);
            decimal a = tline.Item1, b = tline.Item2;

            //Y = aX + b. Find X
            decimal dayPoint = (avg - b) / a;

            dayPoint += duration;

            //Y = aX + b. Find Y
            decimal result;
            if (duration <= 7)
            {
                result = a * dayPoint + b;
            }
            else
            {
                result = a * dayPoint/7 + b;
            }

            return result;
        }

        public List<ReportItem> GenerateReport(List<Item> itemList)
        {
            List<ReportItem> reportList = new List<ReportItem>();
            List<ReportItem> distinctList = new List<ReportItem>();
            foreach (Item item in itemList)
            {
                ReportItem report = new ReportItem();
                report.ItemName = item.ItemName;
                report.TotalQuantity = TotalQuantity(itemList);
                report.TotalSale = Math.Round(TotalSale(itemList),3);
                report.AvgSale = Math.Round(AvgSale(itemList),3);
                Tuple<decimal, decimal> temp = TrendLine(itemList);
                report.PredictedSaleWeek = Math.Round(PredictingSale(itemList, temp, 7),3);
                report.PredictedSaleMonth = Math.Round(PredictingSale(itemList, temp, 30),3);
                if (temp.Item1 > 0)
                {
                    report.Trend = "Up";
                }
                else if (temp.Item1 < 0)
                {
                    report.Trend = "Down";
                }
                else
                {
                    report.Trend = "Neutral";
                }

                reportList.Add(report);
            }

            return distinctList = reportList.GroupBy(elem => new { elem.ItemName, elem.TotalQuantity, elem.TotalSale, elem.AvgSale }).Select(group => group.First()).ToList();
        }
    }
}
