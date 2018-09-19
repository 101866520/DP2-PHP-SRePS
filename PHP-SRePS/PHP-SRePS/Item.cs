using System;
namespace PHP_SRePS
{
    /// <summary>
    ///this Item. class
    /// will have all details realated items
    ///
    /// </summary>
    public class Item
    {
        private string medicineName;
        private int quantity;
        private decimal price;
        private int itemNo;
        private string date;

      

        public Item()
        {
        }

        /// <summary>
        /// property for geting and setting Item's Name
        /// </summary>
        /// <value>The name of the item.</value>
        public string ItemName{
            get{
                return medicineName;
            }
            set
            {
                medicineName = value;
            }
        }
       
        public decimal Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }

        /// <summary>
        /// Gets or sets the item price.s
        /// </summary>
        /// <value>The item price.</value>
        public decimal ItemPrice{
            get{
                return price;
            }
            set
            {
                price = value;
            }
        }
        public int ItemNo
        {
            get
            {
                return itemNo;
            }
            set
            {
                itemNo = value;
            }
        }
        public int ItemQuantity
        {
            get
            {
                return quantity;
            }
            set
            {
                quantity = value;
            }
        }
        public string ItemPurchasedDate
        {
            get
            {
                return date;
            }
            set
            {
                date = value;
            }
        }
        
    }
}
