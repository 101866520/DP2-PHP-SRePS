using System;
using System.Collections.Generic;
using System.Windows.Forms;
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

        public  string DisplayValues(string startDate, string endDate)
        {
            string viewString = @"select * from sale where product_purchased_date between '" + startDate + "'and'" + endDate +"'" ;
            return viewString;
        }

        public Tuple<decimal, decimal> TrendLine(List<Item> itemList)
        {
            decimal a = 0, b = 0, totalDay = 0, totalSale = 0, totalDaySale = 0, totalDaySqr = 0;
            int i = 0, n = itemList.Count;

            foreach (Item item in itemList)
            {
                i += 1;
                totalDay += i;
                totalSale += item.ItemQuantity * item.ItemPrice;
                totalDaySale += i * item.ItemQuantity * item.ItemPrice;
                totalDaySqr += i * i;
            }

            //Y = aX + b
            a = (n*totalDaySale - totalDay*totalSale) / (n * totalDaySqr - totalDay * totalDay);
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
            decimal result = a * dayPoint + b;

            return result;
        }
    }
}
