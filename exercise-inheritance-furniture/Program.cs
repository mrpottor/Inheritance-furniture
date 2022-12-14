using System;
using System.Dynamic;

namespace exercise_inheritance_furniture
{
   public class Program
    {
        static void Main(string[] args)
        {
            //create an array  of objects in furniture type
            //create program class object
            // call AddToStock(<furniture array>);
            //call ShowStockDetails(<furniture array>);
            // call TotalStockValue(<furniture array>) and display output 
             
            
        }
       public int AddToStock(Furniture []items) {

            //accept the choice from user for type of furniture(BookShelf  or DiningTable)
            // and according to the choice create necessary sub class object and store data
            //continue the process up to the size of array

            // return <size of array>;
            return 0;
        }
     public   double TotalStockValue(Furniture []items)
        {
            double stockValue=default;
            //calculate total stock value i.e qty * price of each item
            return stockValue;
        }
        public   int ShowStockDetails(Furniture[] items)
        {
            //call display method from all object to display the stock 
           //return <size of array>;
           return 0;    
        }
    }
}
