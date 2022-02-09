using System;

namespace restaurant10TablesReservationSistem
{
    /* 
     * 1. Validar si es usuario existente o si se debe registrar
     * 2. El programa debe ser capaz de darle la bienvenida a un usuario existente si en efecto existe
     * 3. El programa debe repetirse hasta que se registren las 10 personas
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] userNames = new string[10] {"","", "", "", "", "", "", "", "", "" };
            int arrayCurrentIndex = 0;
            int index = 0;
            bool registerUser = true;
            string user = "";
            while (arrayCurrentIndex<10)
            {
                Console.WriteLine("Are you a registered user? Write true, or write false to register");
                registerUser=bool.Parse(Console.ReadLine());
                
                if (registerUser)
                {
                    Console.WriteLine("Please enter your username");
                    user = Console.ReadLine();
                    index=Array.IndexOf(userNames, user);
                    if (index == -1)
                    {
                        Console.WriteLine("User not found, try again or register");
                    }
                    else
                    {
                        Console.WriteLine("Welcome {0}, it's a pleasure to serve you", userNames[index]);
                    }
                }
                else if(registerUser==false)
                {
                    Console.WriteLine("Please write and remebmer your User Name");
                    userNames[arrayCurrentIndex]=Console.ReadLine();
                    Console.WriteLine("Your user has been save succesfully\n" + "your username is " + userNames[arrayCurrentIndex]);
                    arrayCurrentIndex++;
                }

            }
            Console.WriteLine("We are full, sorry\n These are the guests to the dinner: ");
            foreach (string users in userNames)
            {
                Console.WriteLine("\n" + users);
            }
            Environment.Exit(0);

        }
    }
}
