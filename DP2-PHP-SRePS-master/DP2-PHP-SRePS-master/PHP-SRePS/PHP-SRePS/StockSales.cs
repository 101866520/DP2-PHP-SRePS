using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHP_SRePS
{
    /// <summary>
    /// stock sales class used to perform queries on Product tables
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
        public String GetProductDetails(Item item)
        {
            string viewString = @"select * from Product where product_name = '" + item.ItemName + "'";
            return viewString;
        }


        public string GetProductNameForList()
        {
            string viewString = @"select product_name  from Product";
            return viewString;
        }
    }
}
