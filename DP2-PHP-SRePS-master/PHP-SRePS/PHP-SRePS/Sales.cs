using System;


namespace PHP_SRePS
{
    //
    /// <summary>
    /// Sales. class
    /// will handle all the user inputs
    /// </summary>
    public class Sales
    {

        private static Sales sales = null;

        public Sales()
        {
        }

        public static Sales SalesInstance()
        {
            if (sales == null)
            {
                sales = new Sales();
            }
            return sales;
        }
  
    
        public String ADDProductDetails(Item item)
        {
           
            string insertString = @"insert into Product(product_no, product_Name, product_purchased_date, product_price, product_purchased_quantity) values ('" + item.ItemNo + "','" + item.ItemName + "','" + item.ItemPurchasedDate + "','" + item.ItemPrice + "','" + item.ItemQuantity + "')";
            return insertString;
        }

    }
}
