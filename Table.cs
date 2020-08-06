using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopCart
{
   public static class Table
    {
        //Table Area
        static int tableWidth = 73;
       public static void PrintLine()
        {
            Console.WriteLine(new string('-', tableWidth));
        }
        public static void PrintRow(params string[] columns)
        {
            int width = (tableWidth - columns.Length) / columns.Length;
            string row = "|";

            foreach (string column in columns)
            {
                row += AlignCentre(column, width) + "|";
            }

            Console.WriteLine(row);
        }
        public static string AlignCentre(string text, int width)
        {
            text = text.Length > width ? text.Substring(0, width - 3) + "  " : text;

            if (string.IsNullOrEmpty(text))
            {
                return new string(' ', width);
            }
            else
            {
                return text.PadRight(width - (width - text.Length) / 2).PadLeft(width);
            }
        }

        
      public static string t = @"
             _______. __    __    ______   .______     ______     ___      .______     .___________.
            /       ||  |  |  |  /  __  \  |   _  \   /      |   /   \     |   _  \    |           |
           |   (----`|  |__|  | |  |  |  | |  |_)  | |  ,----'  /  ^  \    |  |_)  |   `---|  |----`
            \   \    |   __   | |  |  |  | |   ___/  |  |      /  /_\  \   |      /        |  |     
        .----)   |   |  |  |  | |  `--'  | |  |      |  `----./  _____  \  |  |\  \----.   |  |     
        |_______/    |__|  |__|  \______/  | _|       \______/__/     \__\ | _| `._____|   |__|     


                        ";
        //<end>
    }
}
