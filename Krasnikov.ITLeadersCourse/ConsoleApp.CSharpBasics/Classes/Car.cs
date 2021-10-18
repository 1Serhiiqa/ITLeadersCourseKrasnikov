namespace ConsoleApp.CSharpBasics.Classes
{
    public class Car
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Car()
        {
            name = "Incognito";
        }

        public Car(string name)
        {
            this.name = name;
        }

        public string GetIntroduction()
        {
            return $"Hi! My name is {name}";
        }

    }
}

//using ConsoleApp.CSharpBasics.Classes;
//using static ConsoleApp.CSharpBasics.IO.Output;
//public class Program
//{
//    public static void Main(string[] args)
//    {
//        Person firstPerson = new Person();

//        Out.WriteLine("First Person`s name is " + firstPerson.Name);
//        Out.WriteLine(firstPerson.GetIntroduction());

//        firstPerson.Name = "Bob";

//        Out.WriteLine("First Person`s name is " + firstPerson.Name);
//        Out.WriteLine(firstPerson.GetIntroduction());

//        Person secondPerson = new Person("Tom");

//        Out.WriteLine("Second Person`s name is " + secondPerson.Name);
//        Out.WriteLine(secondPerson.GetIntroduction());

//        Person[] personsArray =
//            {
//            new Person("Vera"),
//            new Person("Serhii"),
//            new Person("Yury")
//        };

//        foreach (var person in personsArray)
//        {
//            Out.WriteLine(person.GetIntroduction());
//        }
//    }
//}