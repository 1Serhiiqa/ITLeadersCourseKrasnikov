using ConsoleApp.CSharpBasics.IO.Interfaces;
using System;

namespace ConsoleApp.CSharpBasics.IO.Implementations
{
    public class ConsoleOutput : IOutput
    {
        public void Write(object output = null)
        {
            Console.Write(output);
        }

        public void WriteLine(object output = null)
        {
            if (output == null)
            {
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine(output);
            }
        }
    }
}
