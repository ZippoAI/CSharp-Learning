using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {

            // Type casting: Converting a value to a different data type
            //               Useful when when you want to convert a value from one type to another,
            //                such as converting an integer to a double or a string to an integer. 


            double a = 3.14;

            int b = (int)a; // Explicit type casting from double to int

            // Another way to convert a double to an int is by using the Convert class

            int c = Convert.ToInt32(a); // Using Convert class to convert double to int

            Console.WriteLine("The value of a is: " + a);
            Console.WriteLine("The value of b is: " + b);
            Console.WriteLine("The value of c is: " + c);

            // To know the type of a variable, you can use the GetType() method

            Console.WriteLine("Type of a: " + a.GetType());
            Console.WriteLine("Type of b: " + b.GetType());
            Console.WriteLine("Type of c: " + c.GetType());


            // int to double conversion

            int x = 10;

            double y = (double)x + 0.1;

            Console.WriteLine("The value of x is: " + x);
            Console.WriteLine("The value of y is: " + y);


            // int to string conversion

            int num = 42;


            String str = num.ToString();

            String anotherStr = num.ToString(); 


            Console.WriteLine("The value of str is: " + str);
            Console.WriteLine("The data type of str is: " + str.GetType());
            Console.WriteLine("The data type of anotherStr is: " + anotherStr.GetType());






            Console.ReadLine();
        }
    }
}