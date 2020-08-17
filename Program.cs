using System;
using System.Collections.Generic;
using System.Threading;

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

                Console.WriteLine("1.Login & Shop");
                Console.WriteLine("2.View Cart");
                Console.WriteLine("3.Exit");
                Console.WriteLine("Enter Choice: ");
                string inp = Console.ReadLine();
                int inpc = Convert.ToInt32(inp);  //******* Type Casting here*****
                if (inpc == 1)
                {
                    var arrUser = new User[]
                    {
                        new User("asd","123"),
                        new User("patrickjohn@hotmail.com","321"),
                        //100 user exculding above 2
                    };

                login:
                    Console.WriteLine("Enter Username:");
                    var username = Console.ReadLine();
                    Console.WriteLine("Enter Password:");
                    var password = Console.ReadLine();
                    //Console.Clear();            //Console.Clear();

                    bool succes = false;    //bool check
                    foreach (User user in arrUser)
                    {
                        if (username == user.username && password == user.password)
                        {
                            //Console.ForegroundColor = ConsoleColor.Yellow;
                            //Console.WriteLine(Table.t);
                            //Console.ResetColor();

                            Console.WriteLine("\n");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Hello {0}\t\t\t\t\t\t\t Login Time: {1}", user.username, DateTime.Now);
                            Console.ResetColor();
                            succes = true;



                            string dash = new string('-', 40);
                            Product product1 = new Product()
                            {
                                CategoryId = "ANDR001",
                                ProductId = "11",
                                ProductCode = "SMGM31",
                                ProductName = "Samsung Galaxy M31",
                                ProductDescription = "Samsung Galaxy M31 with Quad Camera",
                                Brand = "Samsung Technologies",
                                MRP = "17000",
                                Discount = 5,
                                OurPrice = 16150,
                            };

                            Product product2 = new Product()
                            {
                                CategoryId = "ANDR002",
                                ProductId = "12",
                                ProductCode = "SMGS20",
                                ProductName = "Samsung Galaxy S20",
                                ProductDescription = "Samsung Galaxy S20 with Cinematic Camera",
                                Brand = "Samsung Technologies",
                                MRP = "80000",
                                Discount = 10,
                                OurPrice = 72000,
                            };

                            Product product3 = new Product()
                            {
                                CategoryId = "MONI001",
                                ProductId = "21",
                                ProductCode = "P021",
                                ProductName = "Samsung 21.5inch Monitor ",
                                ProductDescription = "Samsung 21.5inch Monitor With Bezeless Border",
                                Brand = "Samsung Technologies",
                                MRP = "7620",
                                Discount = 2,
                                OurPrice = 7468,

                            };

                            Product product4 = new Product()
                            {
                                CategoryId = "MONI002",
                                ProductId = "22",
                                ProductCode = "P022",
                                ProductName = "HP 19.5inch Monitor",
                                ProductDescription = "HP 19.5inch Monitor With Night Light Vision Mode",
                                Brand = "HP Technologies",
                                MRP = "7000",
                                Discount = 5,
                                OurPrice = 6650,
                            };

                            Product product5 = new Product()
                            {
                                CategoryId = "TV001",
                                ProductId = "31",
                                ProductCode = "P031",
                                ProductName = "Samsung 80 cm (32 inches) Wondertainment (Black)",
                                ProductDescription = "Samsung 80 cm (32 inches) Wondertainment Series HD Ready LED Smart",
                                Brand = "Samsung Technologies",
                                MRP = "20900",
                                Discount = 5,
                                OurPrice = 15999,
                            };

                            Product product6 = new Product()
                            {
                                CategoryId = "TV002",
                                ProductId = "32",
                                ProductCode = "P032",
                                ProductName = "Sony Bravia 101.6 cm (40 inches) (Titan Gray)",
                                ProductDescription = "Sony Bravia 101.6 cm (40 inches) Full HD LED TV",
                                Brand = "Sony Technologies",
                                MRP = "20900",
                                Discount = 5,
                                OurPrice = 15999,
                            };

                            Product product7 = new Product()
                            {

                                CategoryId = "WM001",
                                ProductId = "41",
                                ProductCode = "P041",
                                ProductName = "6.2 kg Fully-Automatic (Imperial Silver)",
                                ProductDescription = "6.2kg Fully-Automatic Washing Machine",
                                Brand = "Samsung Technologies",
                                MRP = "15900",
                                Discount = 16,
                                OurPrice = 13290,
                            };

                            Product product8 = new Product()
                            {
                                CategoryId = "WM002",
                                ProductId = "42",
                                ProductCode = "P042",
                                ProductName = "Whirlpool 7Kg 5* Semi-Automatic (Grey Dazzle)",
                                ProductDescription = "7Kg 5* Semi-Automatic Loading Washing Machine",
                                Brand = "Whirlpool",
                                MRP = "11250",
                                Discount = 17,
                                OurPrice = 9290,
                            };

                            Product product9 = new Product()
                            {
                                CategoryId = "FR001",
                                ProductId = "51",
                                ProductCode = "P051",
                                ProductName = "Samsung 192L 4* Inverter (Blooming Saffron Red)",
                                ProductDescription = "192L 4* Single Door Refrigerator",
                                Brand = "Samsung Technologies",
                                MRP = "21990",
                                Discount = 27,
                                OurPrice = 15990,
                            };

                            Product product10 = new Product()
                            {
                                CategoryId = "FR002",
                                ProductId = "52",
                                ProductCode = "P052",
                                ProductName = "Haier 195L 4 Star (Dazzle Steel)",
                                ProductDescription = "Haier 195 L 4 Star Direct-Cool Single-Door Refrigerator",
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
                            Table.PrintRow("ID", "Brand", "Name", "Description", "Mrp");
                            Table.PrintLine();
                            Table.PrintRow(product1.ProductId, product1.Brand, product1.ProductName, product1.ProductDescription, product1.MRP);
                            Table.PrintLine();
                            Table.PrintRow(product2.ProductId, product2.Brand, product2.ProductName, product2.ProductDescription, product2.MRP);
                            Table.PrintLine();
                            Table.PrintRow(product3.ProductId, product3.Brand, product3.ProductName, product3.ProductDescription, product3.MRP);
                            Table.PrintLine();
                            Table.PrintRow(product4.ProductId, product4.Brand, product4.ProductName, product4.ProductDescription, product4.MRP);
                            Table.PrintLine();
                            Table.PrintRow(product5.ProductId, product5.Brand, product5.ProductName, product5.ProductDescription, product5.MRP);
                            Table.PrintLine();
                            Table.PrintRow(product6.ProductId, product6.Brand, product6.ProductName, product6.ProductDescription, product6.MRP);
                            Table.PrintLine();
                            Table.PrintRow(product7.ProductId, product7.Brand, product7.ProductName, product7.ProductDescription, product7.MRP);
                            Table.PrintLine();
                            Table.PrintRow(product8.ProductId, product8.Brand, product8.ProductName, product8.ProductDescription, product8.MRP);
                            Table.PrintLine();
                            Table.PrintRow(product9.ProductId, product9.Brand, product9.ProductName, product9.ProductDescription, product9.MRP);
                            Table.PrintLine();
                            Table.PrintRow(product10.ProductId, product10.Brand, product10.ProductName, product10.ProductDescription, product10.MRP);
                            Table.PrintLine();
                            //<end>









                        }
                        if (!succes)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Try again !!!!");
                            Console.ResetColor();
                            goto login;
                        }
                    }



                }
                else if (inpc == 2)
                {

                }
                else if (inpc == 3)
                {
                    Console.WriteLine("\n");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("Thankyou For Visiting");
                    Console.ResetColor();
                    Thread.Sleep(1000);
                    System.Environment.Exit(0);

                }


                /*
                
                */
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Error:{0}", e.Message);
                Console.ResetColor();
            }
        }
    }
}
