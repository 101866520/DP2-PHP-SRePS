using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHP_SRePS
{
    /// <summary>
    /// stock sales class used to perform queries on Product tables for selling products purposes
    /// it has been used by current_sales_user_control
    /// </summary>
    class StockSales
    {
        private static StockSales stockSales = null;


        public static StockSales StockSalesInstance()
        {
            if (stockSales == null)
            {
                stockSales = new StockSales();
            }
            return stockSales;
        }
        /// <summary>
        /// returns everything about an item by matching item name
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public String GetProductDetails(Item item)
        {
            string viewString = @"select * from Product where product_name = '" + item.ItemName + "'";
            return viewString;
        }

        /// <summary>
        /// will return list of product name from product table
        /// </summary>
        /// <returns></returns>
        public string GetProductNameForList()
        {
            string viewString = @"select product_name  from Product";
            return viewString;
        }
    }
}
