using System;
using System.Data;

namespace abstraction
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Which object would you like to create (Recatangle, Cirlce, Trapezium)? please type your answer in lowercase");
            String input = Console.ReadLine();
            if (input.Equals("triangle" , StringComparison.InvariantCultureIgnoreCase))
            {
                Console.WriteLine("What is the width of the triangle?");
                double width = Double.Parse(Console.ReadLine());
                Console.WriteLine("What is the height of the tiangle?");
                double height = Double.Parse(Console.ReadLine());
                Console.WriteLine(height * width);
            }
            else if (input.Equals("circle" ,  StringComparison.InvariantCultureIgnoreCase))
            {
                Console.WriteLine("What is the readius?");
                double radius = Double.Parse(Console.ReadLine());
                Console.WriteLine(radius * 3.141);
            }
            else if (input.Equals("trapezium" , StringComparison.InvariantCultureIgnoreCase))
            {
                Console.WriteLine("what is the top base of the trapezium");
                double topBase = Double.Parse(Console.ReadLine());
                Console.WriteLine("what is the bottom base of the trapezium");
                double bottomBase = Double.Parse(Console.ReadLine());
                Console.WriteLine("what is the height of the trapezium");
                double height = Double.Parse(Console.ReadLine());
                Class1 trap = new Class1(topBase, bottomBase, height);
                Console.WriteLine(trap.calculateArea());
            }
            else
            {
                Console.WriteLine("Please enter either: triangle, circle, or trapezium");
            }

            Console.ReadKey();
        }
    }
}

