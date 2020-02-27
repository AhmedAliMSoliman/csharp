using System;

namespace csharp_development
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var a = "My string";
            Console.WriteLine(a);

            //Read data from console
            var data_from_console = Console.ReadLine();
            Console.WriteLine("You Entered: ");
            Console.WriteLine(data_from_console);


            Console.WriteLine("------------Chalange------------");

            Console.WriteLine("What is your name?");
            var user_name = Console.ReadLine();
            Console.WriteLine("What is your age?");
            var user_age = Console.ReadLine();
            Console.WriteLine("What is your month birth?");
            var user_month_birth = Console.ReadLine();

            Console.WriteLine("Your name is: {0}", user_name);
            Console.WriteLine("Your age is: {0}", user_age);
            Console.WriteLine("Your month is: {0}", user_month_birth);


        }
    }
}
