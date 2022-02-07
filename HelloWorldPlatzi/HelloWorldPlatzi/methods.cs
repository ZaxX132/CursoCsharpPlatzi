using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorldPlatzi
{
    internal class methods
    {
        static void Main(string[] args)
        {
            Random rnd=new Random();
            Console.WriteLine("hello world, of random numbers!");
            Console.WriteLine($"{rnd.Next(1,10)}");
        }
    }
}
