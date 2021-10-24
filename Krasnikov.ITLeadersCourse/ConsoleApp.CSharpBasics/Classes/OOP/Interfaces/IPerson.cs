using ConsoleApp.CSharpBasics.Classes.OOP.Enums;

namespace ConsoleApp.CSharpBasics.Classes.OOP.Interfaces
{
    public interface IPerson : IMetrics
    {
        Sex Sex { get; }
    }
}
