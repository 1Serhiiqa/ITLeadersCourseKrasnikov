using System;

namespace ConsoleApp.CSharpBasics
{

    public class Program
    {
        public static void Main(string[] args)
        {
            int x = 4;
            int y = 0;

            int z/* = x / y*/;

            //try
            //{
            //    z = x / y;
            //}

            //catch
            //{
            //    Console.WriteLine("Exception. Operation of devision by zero is forbidden!");
            //}

            //finally
            //{
            //    Console.WriteLine("Program was finished successfully!");
            //}


            //try
            //{
            //    z = x / y;
            //}

            //catch (DivideByZeroException)
            //{
            //    Console.WriteLine("Exception. Operation of devision by zero is forbidden!");
            //}

            //finally
            //{
            //    Console.WriteLine("Program was finished successfully!");
            //}


            //try
            //{
            //    z = x / y;
            //}

            //catch (ApplicationException ex)
            //{
            //    Console.WriteLine($"Exception: {ex.Message} {Environment.NewLine} {ex.StackTrace}");
            //}

            //finally
            //{
            //    Console.WriteLine("Program was finished successfully!");
            //}


            var intArray = new int[] { 1, 3, 4 };

            //for (int i = 0; i < intArray.Length; i++)
            //{
            //    var result = intArray[i] / (intArray.Length - i - 1);
            //    Console.WriteLine($"Result: {result}");
            //}


            //try
            //{
            //    for (int i = 0; i < intArray.Length;i++)
            //    {
            //        var result = intArray[i] / (intArray.Length - i - 1);
            //        Console.WriteLine($"Result: {result}");
            //    }
            //}
            //catch (DivideByZeroException ex)
            //{
            //    Console.WriteLine($"Exception: {ex.Message} {Environment.NewLine} {ex.StackTrace}");
            //}


            try
            {
                for (int i = 0; i < intArray.Length;)
                {
                    var result = intArray[++i] / (intArray.Length - i);
                    Console.WriteLine($"Result: {result}");
                }
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Exception: {ex.Message} {Environment.NewLine} {ex.StackTrace}");
            }

            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine($"Exception: {ex.Message} {Environment.NewLine} {ex.StackTrace}");
            }

            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message} {Environment.NewLine} {ex.StackTrace}");
            }

            finally
            {
                Console.WriteLine($"Unpredictable exception.");
            }
        }
    }
}





