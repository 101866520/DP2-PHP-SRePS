using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHP_SRePS
{
    class Product
    {
        private static Product product = null;

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static Product ProductInstance()
        {
            if (product == null)
            {
                product = new Product();
            }
            return product;
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
        /// alter data from sale table
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public String AlterProductDetails(Item item)
        {
            string alterString = @"update product set product_name ='" + item.ItemName + "', product_price ='" + item.Price + "', product_purchased_date ='" + item.ItemPurchasedDate + "', product_purchased_quantity= product_purchased_quantity + '" + item.ItemQuantity + "' where product_no = '" + item.ItemNo + "'";
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
        /// this method is used to check if there is an item of same id already
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public String CheckingPrimaryKeyForDuplication(Item item)
        {
            String count = @"select Count(product_no) from product where product_no = '" + item.ItemNo + "'";
            return count;

        }
        public string CheckingItemQuantity()
        {
            string returnString = "DELETE FROM product WHERE product_purchased_quantity <= 0";
            return returnString;
        }

        /// <summary>
        /// returns everything about an item by matching item name
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public String GetProductDetails(Item item)
        {
            string viewString = @"select * from Product where product_no = '" + item.ItemNo + "'";
            return viewString;
        }

    }
}
