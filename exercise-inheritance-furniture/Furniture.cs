
using System;
using System.Collections.Generic;
using System.Text;
namespace exercise_inheritance_furniture
{
    public class Furniture
    {
        //Add below mentioned Properties 
        //Height(int),Width(int),Color(string),Price(double),Qty(int)
        private int _Height, _Width, _Qty;
        private double _Price;
        private string _Color;
        public int Height { get { return _Height; } set { _Height = value; } }
        public int Width { get { return _Width; } set { _Width = value; } }
        public int Qty { get { return _Qty; } set { _Qty = value; } }
        public double Price { get { return _Price; } set { _Price = value; } }
        public string Color { get { return _Color; } set { _Color = value; } }
        /* public Furniture(int Height, int Width, string Color, double Price, int Qry )
         {
             this.Height = Height;
             this.Width = Width;
             this.Colour = Color;
             this.Price = Price;
             this.Qty = Qry;
         }*/
        public virtual void Accept()
        {
            //code to accept height,width ,color,price and qty
            Console.WriteLine("give the value for height :");
            Height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Give the value for width :");
            Width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Give the value for Color :");
            Color = Console.ReadLine();
            Console.WriteLine("Give the value for Price :");
            Price = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Give the vlue for quantity");
            Qty = Convert.ToInt32(Console.ReadLine());

        }
        public virtual void Display()
        {
            //code to display height width ,price,qty and color
            Console.WriteLine($"the value for Height given is {Height}");
            Console.WriteLine($"The value for Width given is {Width}");
            Console.WriteLine($"The value for Color given is {Color}");
            Console.WriteLine($"The value for Price given is {Price}");
            Console.WriteLine($"The value for Quantity given is {Qty}");
        }
    }
}






























/**
* @author Anilkumar.S
*
* @date - 8/24/2020 2:24:45 PM 
*/
