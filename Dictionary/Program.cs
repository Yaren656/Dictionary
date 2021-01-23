using System;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary <string, int,string> Products = new MyDictionary <string, int,string> ();
            Products.Add("Computers : ", 200, "adet");
            Products.Add("Cell Phones : " , 500,"adet");
            Products.Add("Televisions : ", 700,"adet");

            Console.WriteLine(Products.Count + " " + "adet farklı ürün bulunmaktadır.");
        }
    }
}
