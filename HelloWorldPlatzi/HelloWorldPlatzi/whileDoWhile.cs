using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorldPlatzi
{
    internal class whileDoWhile
    {
        static void Main(string[] args)
        {
            bool continueSoftwareExecution = false;
            int wish = 0;
           /* while (continueSoftwareExecution==true)
            {
                Console.WriteLine("do you wish to keep the software running?, write 1 if yes,0 if no");
                wish=int.Parse(Console.ReadLine());
                if (wish == 1)
                {
                    Console.WriteLine("hello World! The software will keep running");
                }
                else if (wish == 0)
                {
                    Console.WriteLine("This is the last time the software is running");
                    continueSoftwareExecution = false;
                }
                else
                    Console.WriteLine("Invalid input,try again");
            }*/

            do
            {
                Console.WriteLine("do you wish to keep the software running?, write 1 if yes,0 if no");
                wish = int.Parse(Console.ReadLine());
                if (wish == 1)
                {
                    Console.WriteLine("hello World! The software will keep running");
                }
                else if (wish == 0)
                {
                    Console.WriteLine("This is the last time the software is running");
                    continueSoftwareExecution = false;
                }
                else
                    Console.WriteLine("Invalid input,try again");
            } while (continueSoftwareExecution == true);
        }
    }
}
