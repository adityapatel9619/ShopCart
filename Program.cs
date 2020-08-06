using System;
using System.Collections.Generic;

namespace ShopCart
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
               
                Console.Title = "ShopCart.com";
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(Table.t);
                Console.ResetColor();

                string dash = new string('-', 40);
                Product product1 = new Product()
                {
                    CategoryId = "ANDR001",
                    ProductId = 11,
                    ProductCode = "SMGM31",
                    ProductName = "Samsung M31",
                    ProductDescription = "with Quad Camera",
                    Brand = "Samsung Tech",
                    MRP = "17000",
                    Discount = 5,
                    OurPrice = 16150,
                };

                Product product2 = new Product()
                {
                    CategoryId = "ANDR002",
                    ProductId = 12,
                    ProductCode = "SMGS20",
                    ProductName = "Samsung S20",
                    ProductDescription = "Cinematic Camera",
                    Brand = "Samsung Tech",
                    MRP = "80000",
                    Discount = 10,
                    OurPrice = 72000,
                };

                Product product3 = new Product()
                {
                    CategoryId = "MONI001",
                    ProductId = 21,
                    ProductCode = "P021",
                    ProductName = "21.5inch Monitor ",
                    ProductDescription = "Bezeless Border",
                    Brand = "Samsung Tech",
                    MRP = "7620",
                    Discount = 2,
                    OurPrice = 7468,

                };

                Product product4 = new Product()
                {
                    CategoryId = "MONI002",
                    ProductId = 22,
                    ProductCode = "P022",
                    ProductName = "19.5inch Monitor",
                    ProductDescription = "Night Light Mode",
                    Brand = "HP Technologies",
                    MRP = "7000",
                    Discount = 5,
                    OurPrice = 6650,
                };

                Product product5 = new Product()
                {
                    CategoryId = "TV001",
                    ProductId = 31,
                    ProductCode = "P031",
                    ProductName = "32 inches (Black)",
                    ProductDescription = "LED Smart TV",
                    Brand = "Samsung Tech",
                    MRP = "20900",
                    Discount = 5,
                    OurPrice = 15999,
                };

                Product product6 = new Product()
                {
                    CategoryId = "TV002",
                    ProductId = 32,
                    ProductCode = "P032",
                    ProductName = "40 inches(Gray)",
                    ProductDescription = "Full HD LED TV",
                    Brand = "Sony Technologies",
                    MRP = "20900",
                    Discount = 5,
                    OurPrice = 15999,
                };

                Product product7 = new Product()
                {

                    CategoryId = "WM001",
                    ProductId = 41,
                    ProductCode = "P041",
                    ProductName = "6.2kg Fully-At(Silver)    ",
                    ProductDescription = "Full Automatic WM",
                    Brand = "Samsung Tech",
                    MRP = "15900",
                    Discount = 16,
                    OurPrice = 13290,
                };

                Product product8 = new Product()
                {
                    CategoryId = "WM002",
                    ProductId = 42,
                    ProductCode = "P042",
                    ProductName = "7 Kg Star(Grey Dazzle)",
                    ProductDescription = "Semi-Automatic WM",
                    Brand = "Whirlpool",
                    MRP = "11250",
                    Discount = 17,
                    OurPrice = 9290,
                };

                Product product9 = new Product()
                {
                    CategoryId = "FR001",
                    ProductId = 51,
                    ProductCode = "P051",
                    ProductName = "192L 4 Star Inverter (Blooming Saffron Red)",
                    ProductDescription = "Single Door RF",
                    Brand = "Samsung Tech",
                    MRP = "21990",
                    Discount = 27,
                    OurPrice = 15990,
                };

                Product product10 = new Product()
                {
                    CategoryId = "FR002",
                    ProductId = 52,
                    ProductCode = "P052",
                    ProductName = "195L (Dazzle Steel)",
                    ProductDescription = "Single-Door RF",
                    Brand = "Haier Innovation",
                    MRP = "18400",
                    Discount = 30,
                    OurPrice = 12790,
                };

                List<Product> products = new List<Product>();
                products.Add(product1);
                products.Add(product2);
                products.Add(product3);
                products.Add(product4);
                products.Add(product5);
                products.Add(product6);
                products.Add(product7);
                products.Add(product8);
                products.Add(product9);
                products.Add(product10);


                //foreach (Product p in products)
                //{

                //    Console.Write("{0}\n{1}\n{2}\nRs.{3}\n{4}%\nRs.{5}", p.ProductName, p.ProductDescription, p.Brand, p.MRP, p.Discount, p.OurPrice);

                //}
               
                //Displaying the values in table
                Table.PrintLine();
                Table.PrintRow("Brand", "Name", "Description", "Mrp");
                Table.PrintLine();
                Table.PrintRow(product1.Brand, product1.ProductName, product1.ProductDescription, product1.MRP);
                Table.PrintLine();                                                                            
                Table.PrintRow(product2.Brand, product2.ProductName, product2.ProductDescription, product2.MRP);
                Table.PrintLine();                                                                            
                Table.PrintRow(product3.Brand, product3.ProductName, product3.ProductDescription, product3.MRP);
                Table.PrintLine();                                                                            
                Table.PrintRow(product4.Brand, product4.ProductName, product4.ProductDescription, product4.MRP);
                Table.PrintLine();
                Table.PrintRow(product5.Brand, product5.ProductName, product5.ProductDescription, product5.MRP);
                Table.PrintLine();
                Table.PrintRow(product6.Brand, product6.ProductName, product6.ProductDescription, product6.MRP);
                Table.PrintLine();
                Table.PrintRow(product7.Brand, product7.ProductName, product7.ProductDescription, product7.MRP);
                Table.PrintLine();
                Table.PrintRow(product8.Brand, product8.ProductName, product8.ProductDescription, product8.MRP);
                Table.PrintLine();
                Table.PrintRow(product9.Brand, product9.ProductName, product9.ProductDescription, product9.MRP);
                Table.PrintLine();
                Table.PrintRow(product10.Brand, product10.ProductName, product10.ProductDescription, product10.MRP);
                Table.PrintLine();
                //<end>

                Console.ReadKey();
            }
            catch (Exception e)
            {

                Console.WriteLine("Error:{0}",e.Message);
            }
        }
    }
}
