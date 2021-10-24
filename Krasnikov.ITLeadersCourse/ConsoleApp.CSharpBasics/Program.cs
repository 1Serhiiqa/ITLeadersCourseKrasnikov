using ConsoleApp.CSharpBasics.Classes.OOP.Enums;
using ConsoleApp.CSharpBasics.Classes.OOP.Implementations;
using ConsoleApp.CSharpBasics.Classes.OOP.Structs;

namespace ConsoleApp.CSharpBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            var age = new Person(Sex.Man, new DateOfBirth(1995, 10, 22)).Age;
        }
    }
}

