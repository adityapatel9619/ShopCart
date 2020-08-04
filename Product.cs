using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopCart
{
    class Product
    {
        private int productID ;
        private string categoryName, categoryID, pCode ,productName, pDesc, brand;
        private double mrp, discount, ourPrice;

        //Int property
        public int ProductId { get { return productID; } set { productID = value; } }

        //String property
        public string CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public string Brand { get; set; }

        //Double property
        public double MRP { get; set; }
        public double Discount { get; set; }
        public double OurPrice { get; set; }


       
    }
}
