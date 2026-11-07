using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {



            Console.WriteLine("Hello World");
            Console.WriteLine("This is my first program"); // write line does hit enter at the end of the line
            Console.Write("Bulbul"); // Does not hit enter at the end of the line
            Console.Beep(); // make a Beep sound

            // TO remove all garbange at the end of the program

            Console.ReadLine(); // wait for user input before closing the console window


        }
    }
}