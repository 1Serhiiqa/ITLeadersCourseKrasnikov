using System;

namespace ConsoleApp.CSharpBasics
{
    class Program

    {
        static void Main(string[] args)
        {
            Console.Write("Input the positive integer: ");
            double x = Convert.ToDouble(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine($"The square root is: {Sqrt(double x)");




            //try
            //{
            //public static double Sqrt(double d);             
            //}

            //catch (OperationWithNegativeOrInvalidSymbols ex)
            //{
            //    Console.WriteLine($"Exception: {ex.Message} {Environment.NewLine} {ex.StackTrace}");
            //    }

            //finally
            //{
            //    Console.WriteLine("Good bye!");
            //}
        }
    }
}

//1.Wiht help of exceptions write a program that takes a positive integer from the console and prints 
//   the square root of this integer. If the input is negative or invalid print 
//   "Invalid Number" in the console. In all cases print "Good Bye".