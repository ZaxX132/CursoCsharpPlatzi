using System;

namespace HelloWorldPlatzi
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1;
            int number2;
            int result;
            Console.WriteLine("What's your name? Please Write your full name");
            String fullUserName = Console.ReadLine();
            Console.WriteLine("Hello " + fullUserName + " ,Welcome to platzi");
            Console.WriteLine("Please input the first number");
            number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please input the second number");
            number2 = int.Parse(Console.ReadLine());
            result = number1 * number2;
            Console.WriteLine("The result is: "+ result);
        }
    }
}
