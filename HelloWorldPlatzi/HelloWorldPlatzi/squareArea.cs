using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorldPlatzi
{
    class squareArea
    {
        static void Main(string[] args)
        {
            //rectangle area calculation
            Console.WriteLine("pls enter the side A of the rectangle, you can use decimals");
            float sideA = float.Parse(Console.ReadLine());
            Console.WriteLine("pls enter the side B of the rectangle, you can use decimals");
            float sideB = float.Parse(Console.ReadLine());

            //rectangule area formula is a*b
            float area=sideA * sideB;
            

            Console.WriteLine("The rectangle area is: "+area);
        }
    }
}
