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
        /// <summary>
        /// Delete data from sale record
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public String DeleteData(Item item)
        {
            string deleteString = @"delete from sale where product_no ='" + item.ItemNo + "'";
            return deleteString;
        }

        /// <summary>
        /// alter data from sale table
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
          public String AlterDetails(Item item)
        {
            string alterString = @"update sale set product_name ='" + item.ItemName +"', product_price ='"+item.Price+"', product_purchased_date ='"+item.ItemPurchasedDate+"', product_purchased_quantity='"+item.ItemQuantity+"' where product_no = '"+item.ItemNo+"'"; 
            return alterString;
        }
        /// <summary>
        ///used to add item details to table
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public String ADDProductDetails(Item item)
        {
           
            string insertString = @"insert into sale(product_no, product_Name, product_purchased_date, product_price, product_purchased_quantity) values ('" + item.ItemNo + "','" + item.ItemName + "','" + item.ItemPurchasedDate + "','" + item.ItemPrice + "','" + item.ItemQuantity + "')";
            return insertString;
        }
        /// <summary>
        /// this method is used to check if there is an item of same id already
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public String CheckingPrimaryKeyForDuplication(Item item)
        {
            String count = @"select Count(product_no) from sale where product_no = '"+item.ItemNo +"'";
            return count;

            
        }
        /// <summary>
        ///  this method only used for alter details for current sale secrtion
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public String AlterDetailsForCurrentSale(Item item)
        {
            string alterString = @"update sale set product_name ='" + item.ItemName + "', product_price ='" + item.Price + "', product_purchased_date ='" + item.ItemPurchasedDate + "', product_purchased_quantity +='" + item.ItemQuantity + "' where product_no = '" + item.ItemNo + "'";
            return alterString;
        }

    }
}
