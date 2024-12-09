using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.Entities
{
    public class Select
    {
        public int total;
        public int amount;
        int choice2;
        Coffee coffee = new Coffee();
        Chips chips = new Chips();
        public void choose()
        {
            Console.WriteLine("press 1 for Coffee , 2 for Chips , 3 to See Ingrediant & 4 to Exit");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    coffee.addCoffee();
                    Console.WriteLine("\n press 1 to add more items \n 2 to generate Bill");
                    choice2 = Convert.ToInt32(Console.ReadLine());
                    switch (choice2)
                    {
                        case 1:
                            choose();
                            break;
                        case 2:
                            Console.WriteLine("Item name".PadRight(20) + "Quantity".PadRight(15) + "Amount");
                            if (coffee.EspressoCount > 0)
                            {
                                Console.WriteLine("Espresso".PadRight(22)+ $"{coffee.EspressoCount}".PadRight(10)+"x".PadRight(4) +"140");
                            }
                            if (coffee.FlatWhiteCount > 0)
                            {
                                Console.WriteLine("Flat White".PadRight(22)+ $"{coffee.FlatWhiteCount}".PadRight(10)+"x".PadRight(4)+"80");
                            }
                            if (coffee.AmericanoCount > 0)
                            {
                                Console.WriteLine("Americano".PadRight(22)+ $"{coffee.AmericanoCount}".PadRight(10) + "x".PadRight(4) + "160");
                            }
                            if (coffee.CappuccinoCount > 0)
                            {
                                Console.WriteLine("Cappuccino".PadRight(22) + $"{coffee.CappuccinoCount}".PadRight(10) + "x".PadRight(4) + "200");
                            }
                            if (chips.TomatoCount > 0)
                            {
                                Console.Write("Tomato Chips".PadRight(22) + $"{chips.TomatoCount}".PadRight(10) + "x".PadRight(4) + "815");
                            }
                            if (chips.OnionCount > 0)
                            {
                                Console.Write("Onion Chips".PadRight(22) + $"{chips.OnionCount}".PadRight(10) + "x".PadRight(4) + "20");
                            }
                            Console.WriteLine();
                            total = coffee.CoffeeCount + chips.ChipsCount;
                            Console.WriteLine($"Total amount \t\t\t {total} Rs");
                            Console.WriteLine("\n press 1 to pay the amount or 2 to Exit");
                            int choice1 = Convert.ToInt32(Console.ReadLine());
                            switch (choice1)
                            {
                                case 1:
                                    Console.Write($"Pay {total} Rs : ");
                                    amount = Convert.ToInt32(Console.ReadLine());
                                    if (amount != total)
                                    {
                                        Console.WriteLine("pay the exact amount ");
                                        goto case 1;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Thank you! Visit again.");
                                    }
                                    Console.WriteLine();
                                    choose();
                                    break;
                                case 2:
                                    System.Environment.Exit(0);
                                    break;
                                default:
                                    Console.WriteLine("Invalid Option");
                                    break;

                            }
                            break;
                    }
                    break;
                case 2:
                    chips.addChips();
                    Console.WriteLine("\n press 1 to add more more items \n 2 to generate Bill");
                    choice2 = Convert.ToInt32(Console.ReadLine());
                    switch (choice2)
                    {
                        case 1:
                            choose();
                            break;
                        case 2:
                            Console.WriteLine("Item name".PadRight(20) + "Quantity".PadRight(15) + "Amount");
                            if (coffee.EspressoCount > 0)
                            {
                                Console.WriteLine("Espresso".PadRight(22) + $"{coffee.EspressoCount}".PadRight(10) + "x".PadRight(4) + "140");
                            }
                            if (coffee.FlatWhiteCount > 0)
                            {
                                Console.WriteLine("Flat White".PadRight(22) + $"{coffee.FlatWhiteCount}".PadRight(10) + "x".PadRight(4) + "80");
                            }
                            if (coffee.AmericanoCount > 0)
                            {
                                Console.WriteLine("Americano".PadRight(22) + $"{coffee.AmericanoCount}".PadRight(10) + "x".PadRight(4) + "160");
                            }
                            if (coffee.CappuccinoCount > 0)
                            {
                                Console.WriteLine("Cappuccino".PadRight(22) + $"{coffee.CappuccinoCount}".PadRight(10) + "x".PadRight(4) + "200");
                            }
                            if (chips.TomatoCount > 0)
                            {
                                Console.WriteLine("Tomato Chips".PadRight(22) + $"{chips.TomatoCount}".PadRight(10) + "x".PadRight(4) + "815");
                            }
                            if (chips.OnionCount > 0)
                            {
                                Console.WriteLine("Onion Chips".PadRight(22) + $"{chips.OnionCount}".PadRight(10) + "x".PadRight(4) + "20");
                            }
                            Console.WriteLine();
                            total = coffee.CoffeeCount + chips.ChipsCount;
                            Console.WriteLine($"Total amount \t\t\t {total} Rs");
                            Console.WriteLine("\n press 1 to pay the amount or 2 to Exit");
                            int choice1 = Convert.ToInt32(Console.ReadLine());
                            switch (choice1)
                            {
                                case 1:
                                    Console.Write($"Pay {total} Rs : ");
                                    amount = Convert.ToInt32(Console.ReadLine());
                                    if (amount != total)
                                    {
                                        Console.WriteLine("pay the exact amount ");
                                        goto case 1;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Thank you! Visit again.");
                                    }
                                    Console.WriteLine();
                                    choose();
                                    break;
                                case 2:
                                    System.Environment.Exit(0);
                                    break;
                                default:
                                    Console.WriteLine("Invalid Option");
                                    break;
                            }
                            break;
                    }
                    break;
                case 3:
                    Console.WriteLine("Ingrediants in Machine");
                    Console.WriteLine($"Coffee : {500 - coffee.CoffeeLimit}gm");
                    Console.WriteLine($"Water : {5000 - coffee.WaterLimit}l ");
                    Console.WriteLine($"Milk : {1000 - coffee.MilkLimit}l");
                    Console.WriteLine($"Sugar : {500 - coffee.SugarLimit}gm");
                    Console.WriteLine($"Tomato Chips : {chips.TomatoChips} packets");
                    Console.WriteLine($"Onion Chips : {chips.OnionChips} packets");
                    Console.WriteLine();
                    choose();
                    break;
                case 4:
                    System.Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid option");
                    Console.WriteLine("press between 1 to 4");
                    choose();
                    break;
            }
        }
    }
}
