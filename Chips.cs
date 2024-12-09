using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.Entities
{
    public class Chips
    {
        public int ChipsCount;
        public int TotalChips;
        public int ChipsLimit;
        public int TomatoChips = 10;
        public int OnionChips = 10;
        public int TomatoCount;
        public int OnionCount;
        
        public void addChips()
        {
            Console.WriteLine(" press   1 for Tomato Chips -\t 15 Rs\n\t 2 for Onion Chips-\t 20 Rs");
            int choice = Convert.ToInt32(Console.ReadLine());
            if (ChipsLimit <= 20)
            {
                switch (choice)
                {
                    case 1:
                        Console.Write("Enter Quantity : ");
                        int count1 = Convert.ToInt32(Console.ReadLine());
                        if (count1 <= TomatoChips)
                        {
                            TomatoChips -= count1;
                            ChipsLimit += count1;
                            ChipsCount += 15 * count1;
                            Console.WriteLine("Added Successfully");
                            TotalChips += count1;
                            TomatoCount += count1;
                        }
                        else
                        {
                            Console.WriteLine("Out of Range");
                            Console.WriteLine($"There are only {TomatoChips} available");
                            goto case 1;
                        }
                        break;
                    case 2:
                        Console.Write("Enter Quantity : ");
                        int count2 = Convert.ToInt32(Console.ReadLine());
                        if (count2 <= OnionChips)
                        {
                            OnionChips -= count2;
                            ChipsLimit += count2;
                            ChipsCount += 20 * count2;
                            Console.WriteLine("Added Successfully");
                            TotalChips += count2;
                            OnionCount += count2;
                        }
                        else
                        {
                            Console.WriteLine("Out of Range");
                            Console.WriteLine($"There are only {OnionChips} available");
                            goto case 2;
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid option");
                        Console.WriteLine("press either 1 or 2");
                        addChips();
                        break;
                }
            }
            else
            {
                Console.WriteLine("out of stock");
            }
        }
    }
}
