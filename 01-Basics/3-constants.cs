using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {

           
            double pi2 = 3.14159;

            pi2 = 420; // now the value of pi is 420


            // if you dont want to change the value of pi, you can use the const keyword

            const double pi = 3.14159;

            //pi = 30; // this will give an error because pi is a constant and cannot be changed

            Console.WriteLine("The value of pi is: " + pi);



            Console.ReadLine();
        }
    }
}