using Project1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Coffee Vending Machine".PadLeft(70));
            Console.WriteLine("Hello! What would you like to have ?");
            Select s1 = new Select();
            s1.choose();
            Console.ReadLine();
        }
    }
}
