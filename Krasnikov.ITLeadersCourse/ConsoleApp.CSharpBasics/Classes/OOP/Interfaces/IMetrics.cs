using ConsoleApp.CSharpBasics.Classes.OOP.Structs;

namespace ConsoleApp.CSharpBasics.Classes.OOP.Interfaces
{
    public interface IMetrics
    {
        DateOfBirth DateOfBirth { get; set; }

        ushort Age { get; }

        string Name { get; set; }
    }
}
