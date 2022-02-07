using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorldPlatzi
{
    internal class ifStatement
    {
        static void Main(string[] args)
        {
            int anyValue = 14;
            string message = "";

            if (anyValue == 7)
            {
                message = "OMG, it's a miracle anyValue is 7";
            }
            else if (anyValue == 14)
            {
                message = "OMG, it's a double miracle anyValue is 14";
            }
            else
            {
                message = "puff, the value wasn't 7";
            }
            Console.WriteLine($"the anser is {message}");
        }
    }
}
