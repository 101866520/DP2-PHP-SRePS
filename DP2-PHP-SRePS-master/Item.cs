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
        private string expiryDate;
        private float price;
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
            set{
                medicineName = value;
            }
        }
        /// <summary>
        ///property for geting and setting Item's ExpiryDate
        /// </summary>
        /// <value>The item expiry date.</value>
        public string ItemExpiryDate{
            get{
                return expiryDate;
                
            }set{
                expiryDate = value;
            }
        }
        /// <summary>
        /// Gets or sets the item price.s
        /// </summary>
        /// <value>The item price.</value>
        public float ItemPrice{
            get{
                return price;
            }
            set{
                price = value;
            }
        }
        /// <summary>
        /// Connecttos to the data base, 
        /// <see langword="static"/> method 
        /// can be called from any class , if needed
        /// </summary>
        public static void ConnecttoDataBase()
        {

        }
    }
}
