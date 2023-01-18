using System;
using System.Dynamic;

namespace exercise_inheritance_furniture
{
    public class Program
    {
        static void Main(string[] args)
        {
            //create an array  of objects in furniture type
            Furniture[] furnitures = new Furniture[5];
            //create program class object
            Program program = new Program();
            // call AddToStock(<furniture array>);
            program.AddToStock(furnitures);
            //call ShowStockDetails(<furniture array>);
            program.ShowStockDetails(furnitures);
            // call TotalStockValue(<furniture array>) and display output 
            program.TotalStockValue(furnitures);

        }
        public int AddToStock(Furniture[] items)
        {

            //accept the choice from user for type of furniture(BookShelf  or DiningTable)
            // and according to the choice create necessary sub class object and store data
            //continue the process up to the size of array
            int count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                Console.WriteLine("Enter Furniture " + (i + 1) + " details:");
                Console.WriteLine("1. BookShelf");
                Console.WriteLine("2. DiningTable");
                Console.Write("Enter your choice: ");
                int choice = int.Parse(Console.ReadLine());

                if (choice == 1)
                {
                    items[i] = new BookShelf();
                }
                else if (choice == 2)
                {
                    items[i] = new DiningTable();
                }
                else
                {
                    Console.WriteLine("Invalid choice.");
                    i--;
                    continue;
                }

                items[i].Accept();
                count++;
            }

            // return <size of array>;
            return count;
        }
        public double TotalStockValue(Furniture[] items)
        {
            double stockValue = default;
            //calculate total stock value i.e qty * price of each item
            for(int i = 0; i < items.Length; i++)
            {
                stockValue += items[i].Price * items[i].Qty;
            }
            return stockValue;
        }
        public int ShowStockDetails(Furniture[] items)
        {
            //call display method from all object to display the stock
            for (int i = 1; i < items.Length; i++)
            {
                Console.WriteLine("Furniture " + (i + 1) + " Details:");
                items[i].Display();
                Console.WriteLine();
            }
            //return <size of array>;
            return items.Length;
        }
    }
}
