using ConsoleApp.CSharpBasics.IO.Interfaces;
using System;

namespace ConsoleApp.CSharpBasics.IO.Implementations
{
    public class ConsoleInput : IInput
    {
        public string ReadLine()
        {
            return Console.ReadLine();
        }
    }
}
