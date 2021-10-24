using System.Threading.Tasks;

namespace ConsoleApp.CSharpBasics.Classes.OOP.Interfaces
{
    public interface IManager : IEmployee
    {
        (int created, int inProgress, int closed) AnalyzeTeamWork(Task[] tasks);

        Task ReassignTask(Task task, ulong assigneeId);
    }
}
