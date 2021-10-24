namespace ConsoleApp.CSharpBasics.Classes.OOP.Interfaces
{
    public interface IEmployee : IPerson
    {
        ulong Id { get; }

        EmployeeRoles Role { get; set; }
    }
}
