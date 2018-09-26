using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHP_SRePS
{
     /// <summary>
     /// this is stock class
     /// is used to connect to Stock and Product table 
     /// </summary>
    class Stock
    {
        private static Stock stock = null;

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static Stock StockInstance()
        {
            if (stock == null)
            {
                stock = new Stock();
            }
            return stock;
        }
        /// <summary>
        /// updates Product table 
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public string UpdateProductTable(Item item)
        {
            String alterString = @"update Product set product_purchased_quantity=  product_purchased_quantity - '" + item.ItemQuantity + "' where product_Name = '" + item.ItemName + "'";
            return alterString;
        }
        /// <summary>
        /// display all values from stock table 
        /// </summary>
        /// <returns></returns>
        public string DisplayValues()
        {
            string viewString = @"select * from stock";
            return viewString;
        }
        /// <summary>
        /// updates stock table
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public string UpdateStockTable(Item item)
        {
            string alterString = @"update stock set product_purchased_quantity= product_purchased_quantity - '" + item.ItemQuantity + "' where product_Name = '" + item.ItemName + "'";
            return alterString;
        }



        /// <summary>
        /// addinf details to product table
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public String ADDProductDetails(Item item)
        {
            
            string insertString = @"insert into product(product_no, product_Name, product_purchased_date, product_price, product_purchased_quantity) values ('" + item.ItemNo + "','" + item.ItemName + "','" + item.ItemPurchasedDate + "','" + item.ItemPrice + "','" + item.ItemQuantity + "')";
            return insertString;
        }
        /// <summary>
        /// used to update stock table
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public string UpdateStock(Item item)
        {
            string insertString = @"insert into stock(product_no, product_purchased_quantity,product_Name ) values ('" + item.ItemNo + "','" + item.ItemQuantity + "','" + item.ItemName + "')";
            return insertString;
        }
    }
    
    
}
