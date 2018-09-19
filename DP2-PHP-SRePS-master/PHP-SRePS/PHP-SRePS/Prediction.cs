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
            string viewString = @"select * from Product where product_purchased_date between '" + startDate + "'and'" + endDate +"'" ;
            return viewString;
        }
    }
}
