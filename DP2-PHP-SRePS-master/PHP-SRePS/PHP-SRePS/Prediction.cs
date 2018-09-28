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

        public Tuple<decimal, decimal> RegressionLine(List<Item> itemList)
        {
            decimal a, b,
                totalDay = 0,
                totalDaySqr = 0,
                totalSale = 0,
                totalSaleDay = 0;

            /*formula:
             a = ((total y)*(total sqr(x)) - (total x)*(total xy)) / (size*(total sqr(x)) - sqr(total x))
             b = (size*(total xy) - (total x)*(total y)) / (size*(total sqr(x)) - sqr(total x))
             x = day, y = sale
             */

            //Total the numbers
            int i = 0, n = itemList.Count;
            foreach (Item item in itemList)
            {
                i += 1;
                totalDay += i;
                totalDaySqr += i * i;
                totalSale += item.ItemQuantity * item.ItemPrice;
                totalSaleDay += i * item.ItemQuantity * item.ItemPrice;
            }

            //Calculate line: Y = aX + b
            a = (totalDay * totalDaySqr - totalDay * totalSaleDay) / (n * totalDaySqr - totalDay * totalDay);
            b = (n * totalSaleDay - totalDay * totalSale) / (n * totalDaySqr - totalDay * totalDay);

            return Tuple.Create(a, b);
        }

        public string TrendDetect(Tuple<decimal, decimal> line)
        {
            string result;
            if (line.Item1 > 0) { result = "UP"; }
            else if (line.Item1 < 0) { result = "Down"; }
            else if (line.Item1 == 0) { result = "Stable"; }
            else { result = "NaH"; };

            return result;
        }

        public decimal AverageSale(List<Item> itemList)
        {
            decimal result,
                totalSale = 0;

            foreach (Item item in itemList)
            {
                totalSale += item.ItemQuantity * item.ItemPrice;
            }
            result = totalSale / itemList.Count;

            return result;
        }

        public decimal SalePrediction(List<Item> itemList, int duration)
        {
            decimal avg = AverageSale(itemList);
            Tuple<decimal, decimal> line = RegressionLine(itemList);

            /*problem: avg = line.Item1 * avgDay + line.Item2. Find avgDay*/
            decimal avgDay = (avg - line.Item2) / line.Item1;
            decimal newDay = avgDay + duration;
            decimal result = line.Item1 * newDay + line.Item2;

            return result;
        }
    }
}
