
using System;
using System.Collections.Generic;
using System.Text;


namespace exercise_inheritance_furniture
{
    //child of furniture
    public class DiningTable : Furniture
    {
        //Add  NoOfLegs  property
        private int _NoOfLegs;
        public int NoOfLegs { get { return _NoOfLegs; } set { _NoOfLegs = value; } }
        //overrride the Accept method to read NoOfLegs property also
        public override void Accept()
        {
            
            base.Accept();
            Console.WriteLine("give the value for height :");
            NoOfLegs = Convert.ToInt32(Console.ReadLine());
        }
        //override the Display method to include the display of NoOfLegs property also
        public override void Display()
        {
            //code to display height width ,price,qty and color
            base.Display();
            Console.WriteLine($"The value for No of Legs given is {NoOfLegs}");
        }
    }
}


















































/**
* @author Anilkumar.S
*
* @date - 8/24/2020 2:27:28 PM 
*/
