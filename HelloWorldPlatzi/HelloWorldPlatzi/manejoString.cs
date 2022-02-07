using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorldPlatzi
{
    internal class manejoString
    {
        static void Main(string[] args)
        {
            int height = 161;
            int age = 22;
            string name = "Franco Alva";
            string information = "The requested information is: \nUser name "+name+"\nUser age "+age+"\nUser height "+height;
            Console.WriteLine(information);
        }
    }
}
