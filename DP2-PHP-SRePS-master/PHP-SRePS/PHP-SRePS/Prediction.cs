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
        List<Item> ItemsList = new List<Item>();

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

        public void AddItem(Item item)
        {
            ItemsList.Add(item);

        }
        public List<Item> GetItems
        {
            get
            {
                return ItemsList;
            }
        }
        //
        // this is just a temp method for testing purposes
        // will be removed once proper gui is ready to go
        public void Disp()
        {
            string tempstring = "";
            for(int i =0; i<ItemsList.Count; i++)
            {
                tempstring += "Product no:-"+ ItemsList[i].ItemNo +" ,Product Name:- " + ItemsList[i].ItemName + " ,Product Purchase Date:- " + ItemsList[i].ItemPurchasedDate + " ,Product Price:- " +ItemsList[i].ItemPrice +" ,Product Quantity:- "+ ItemsList[i].ItemQuantity + "\n";
            }
            MessageBox.Show(tempstring);
        }
        public  string DisplayValues()
        {
            string startDate = "2018/09/10";
            string endDate ="2018/09/12";
            string viewString = @"select * from Product where product_purchased_date between '" + startDate + "'and'" + endDate +"'" ;
            return viewString;
        }
    }
}
