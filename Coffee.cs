using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Project1.Entities
{
    public class Coffee 
    {
        public int CoffeeCount;
        public int TotalCoffee;
        public int CoffeeLimit;
        public int WaterLimit ;
        public int MilkLimit;
        public int SugarLimit;
        public int EspressoCount;
        public int FlatWhiteCount;
        public int AmericanoCount;
        public int CappuccinoCount;
        public void addCoffee()
        {
            Console.WriteLine(" Press   1 for Espresso -\t 140 Rs\n\t 2 for Flat White -\t 80 Rs\n\t 3 for Americano -\t 160 Rs\n\t 4 for Cappuccino -\t 200 Rs");
            int choice = Convert.ToInt32(Console.ReadLine());
            if (CoffeeLimit <= 500 && WaterLimit <= 5000 && MilkLimit <= 1000 && SugarLimit <= 500)
            {
                switch (choice)
                {
                    case 1:
                        Console.Write("Enter Quantity : ");
                        int count1 = Convert.ToInt32(Console.ReadLine());
                        CoffeeLimit += 15 * count1;
                        WaterLimit += 50 * count1;
                        MilkLimit += 20 * count1;
                        SugarLimit += 5 * count1;
                        CoffeeCount += 140 * count1;
                        Console.WriteLine("Added Successfully");
                        TotalCoffee += count1;
                        EspressoCount += count1;
                        break;
                    case 2:
                        Console.Write("Enter Quantity : ");
                        int count2 = Convert.ToInt32(Console.ReadLine());
                        CoffeeLimit += 10 * count2;
                        WaterLimit += 20 * count2;
                        MilkLimit += 80 * count2;
                        SugarLimit += 10 * count2;
                        CoffeeCount += 80 * count2;
                        Console.WriteLine("Added Successfully");
                        TotalCoffee += count2;
                        FlatWhiteCount += count2;
                        break;
                    case 3:
                        Console.Write("Enter Quantity : ");
                        int count3 = Convert.ToInt32(Console.ReadLine());
                        CoffeeLimit += 20 * count3;
                        WaterLimit += 30 * count3;
                        MilkLimit += 5 * count3;
                        SugarLimit += 5 * count3;
                        CoffeeCount += 160 * count3;
                        Console.WriteLine("Added Successfully");
                        TotalCoffee += count3;
                        AmericanoCount += count3;
                        break;
                    case 4:
                        Console.Write("Enter Quantity : ");
                        int count4 = Convert.ToInt32(Console.ReadLine());
                        CoffeeLimit += 30 * count4;
                        WaterLimit += 15 * count4;
                        MilkLimit += 20 * count4;
                        SugarLimit += 10 * count4;
                        CoffeeCount += 200 * count4;
                        Console.WriteLine("Added Successfully");
                        TotalCoffee += count4;
                        CappuccinoCount += count4;
                        break;
                    default:
                        Console.WriteLine("Invalid Option !");
                        Console.WriteLine("press between 1 to 4");
                        addCoffee();
                        break;
                }
            }
            else
            {
                Console.WriteLine("Out of Stock");
            }
            
        }
    }
}
