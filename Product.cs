using System;
using System.Collections.Generic;
namespace ShopCart
{
    class Product
    {
        //Backing Fields 
        private int productID;
        private string categoryName, categoryID, pCode, productName, pDesc, brand;
        private double mrp, discount, ourPrice;

        //Int property
        //public string ProductId { get { return productID; } set { productID = value; } }
        //Above used backing fields just for trial
        //String property

        public string ProductId { get; set; }
        public string CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public string Brand { get; set; }

        //Double property
        public string MRP { get; set; }
        public double Discount { get; set; }
        public double OurPrice { get; set; }



    }
}
