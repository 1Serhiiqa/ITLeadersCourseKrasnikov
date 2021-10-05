using ConsoleApp.CSharpBasics.IO.Implementations;
using ConsoleApp.CSharpBasics.IO.Interfaces;

namespace ConsoleApp.CSharpBasics.IO
{
    public class Input
    {
        private static IInput input;

        public static IInput In
        {
            get
            {
                if (input == null)
                {
                    input = new InputFactory().GetInputInstance(typeof(ConsoleInput));
                }

                return input;
            }
        }
    }
}
