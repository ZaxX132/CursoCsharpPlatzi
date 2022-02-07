using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorldPlatzi
{
    internal class logicalOperatorExample
    {
        static void Main(string[] args)
        {
            /*
            bool value1=true;
            bool value2=false;
            bool value3=false;
            &&, ||, |
            bool result = value1 && value2 && value3;
            Console.WriteLine("the result of the logical AND is: "+result);
            bool result2 = value1 || value2 || value3;
            Console.WriteLine("the result of the logical or is: " + result2);
            bool result3 = !value1;
            Console.WriteLine("the result of the logical or is: " + result3);*/

            int value1=3;
            int value2=18;

            Console.WriteLine("the values are" + value1+" and "+value2);
            bool result0 = value1 == value2;
            Console.WriteLine("the result of the comparation == is: " + result0);
            bool result1 = value1 != value2;
            Console.WriteLine("the result of the comparation != is: " + result1);
            bool result2 = value1 > value2;
            Console.WriteLine("the result of the comparation > is: " + result2);
            bool result3 = value1 < value2;
            Console.WriteLine("the result of the comparation < is: " + result3);
            bool result4 = value1 >= value2;
            Console.WriteLine("the result of the comparation >= is: " + result4);
            bool result5 = value1 <= value2;
            Console.WriteLine("the result of the comparation <= is: " + result5);

            /*== igual a
            != diferente de
            > Mayor que
            < Menor que
            >= Mayor o igual que
            <= Menor o igual que
            */
        }

    }
}
