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
        /// used to update stock table
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public string UpdateStock(Item item)
        {
            string insertString = @"insert into stock(product_no, product_purchased_quantity,product_Name ) values ('" + item.ItemNo + "','" + item.ItemQuantity + "','" + item.ItemName + "')";
            return insertString;
        }
        /// <summary>
        /// this method is used to check if there is an item of same id already
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public String CheckingPrimaryKeyForDuplication(Item item)
        {
            String count = @"select Count(product_no) from stock where product_no = '" + item.ItemNo + "'";
            return count;
        }
        public String UpDateStockForExistingProduct(Item item)
        {
            string alterString = @"update stock set product_purchased_quantity= product_purchased_quantity + '" + item.ItemQuantity + "' where product_no = '" + item.ItemNo + "'";
            return alterString;
        }
        public string CheckingItemQuantity()
        {
            string returnString = "DELETE FROM stock WHERE product_purchased_quantity <=0";
            return returnString;
        }
    }

    
    
}
