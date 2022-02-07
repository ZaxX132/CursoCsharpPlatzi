using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorldPlatzi
{
    internal class listExampleClass
    {
        static void Main(string[] args)
        {
            List <string> tacoShoppingList = new List<string>();
            tacoShoppingList.Add("cinco tacos de suadero");
            tacoShoppingList.Add("cuatro tacos de Tripa");
            tacoShoppingList.Add("cinco tacos de pastor");
            tacoShoppingList.Add("cuatro coca colas");

            for (int i = 0; i < tacoShoppingList.Count; i++)
            {
                Console.WriteLine(tacoShoppingList[i]);
            }
            tacoShoppingList.RemoveAt(0);
            for (int i = 0; i < tacoShoppingList.Count; i++)
            {
                Console.WriteLine(tacoShoppingList[i]);
            }
            //tacoShoppingList.Remove("cinco tacos de suadero");
        }
    }
}
