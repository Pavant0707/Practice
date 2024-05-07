using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question
{
    //Manage a list of orders and group them by product category. Calculate the total sales for each category.
    internal class Product
    {
        public string productname {  get; set; }
        public int salesamount {  get; set; }
        public string category {  get; set; }
        public static List<Product> GetProducts()
        {
            List<Product> products = new List<Product>()
            {
                new Product{productname="Basket Ball",salesamount=1234,category="outdoor"},
                new Product{productname ="Rubey",salesamount=1234, category="outdoor"},
                new Product{productname="cric",salesamount=12345,category="indooor"}
            };
            return products;
        }
        static void Main(string[] args)
        {
            var a=(from vip in GetProducts() where vip.category=="outdoor" select vip).Sum(vip => vip.salesamount);
            Console.WriteLine("total sales amount is" + " " + a);
        }
    }
}
