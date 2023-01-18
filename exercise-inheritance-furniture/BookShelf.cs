
using System;
using System.Collections.Generic;
using System.Text;


namespace exercise_inheritance_furniture
{
    //child of Furniture
    public class BookShelf : Furniture
    {
        //Add  NoOfShelves  property
        private int _NoOfShelves;
        public int NoOfShelves { get { return _NoOfShelves; } set { _NoOfShelves = value; } }

        //overrride the Accept method to read NoOfShelves property also
        public override void Accept()
        {
            //code to accept height,width ,color,price and qty using base
            base.Accept();
            Console.WriteLine("give the value for height :");
            NoOfShelves = Convert.ToInt32(Console.ReadLine());
        }
        //override the Display method to include the display of NoOfShelves property also
        public override void Display()
        {
            //code to display height width ,price,qty and color using base
            base.Display();
            Console.WriteLine($"The value for No of Legs given is {NoOfShelves}");
        }

    }
}

















































/**
* @author Anilkumar.S
*
* @date - 8/24/2020 2:28:32 PM 
*/
