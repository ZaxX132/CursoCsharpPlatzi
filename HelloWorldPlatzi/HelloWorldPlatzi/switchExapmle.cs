﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorldPlatzi
{
    internal class switchExapmle
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the selected soda: ");
            string caseSwitch = Console.ReadLine();

            switch (caseSwitch)
            {
                case "cola":
                    Console.WriteLine("Cola soda - $2 USD");
                    break;
                case "lime":
                    Console.WriteLine("Lime soda - $1 USD");
                    break;
                case "orange":
                    Console.WriteLine("Orange soda - $1.5 USD");
                    break;
                case "apple":
                    Console.WriteLine("Apple soda - $1 USD");
                    break;
                default:
                    Console.WriteLine("ERROR: You did not select a soda or you entered an incorrect value.");
                    break;
            }
        }
}
}
