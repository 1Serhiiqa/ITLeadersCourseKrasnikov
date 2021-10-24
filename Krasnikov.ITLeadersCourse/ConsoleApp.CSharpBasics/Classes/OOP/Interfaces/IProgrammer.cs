using ConsoleApp.CSharpBasics.Classes.OOP.Structs;

namespace ConsoleApp.CSharpBasics.Classes.OOP.Interfaces
{
    public interface IProgrammer : IEmployee
    {
        Task TakeTask(Task task);

        Task CloseTask(Task task);
    }
}
