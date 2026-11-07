using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {


            int x = 10;
            int y = 20;

            int age = 21;

            double height = 6.1; // Decimal number 

            bool isAlive = true; // True or False

            char grade = 'A'; // Single character

            String name = "Bulbul"; // String of characters




            Console.WriteLine(x);
            Console.WriteLine(y);

            Console.WriteLine("Hello! " + name);

            Console.WriteLine("Are you alive? : " + isAlive);

            Console.WriteLine("You age is: " + age);
            Console.WriteLine("Your height is: " + height);
            Console.WriteLine("Your grade is: " + grade);

            


            Console.ReadLine();
        }
    }
}