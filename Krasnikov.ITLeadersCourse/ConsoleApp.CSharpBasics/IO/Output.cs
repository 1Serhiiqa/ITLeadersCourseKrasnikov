using ConsoleApp.CSharpBasics.IO.Implementations;
using ConsoleApp.CSharpBasics.IO.Interfaces;

namespace ConsoleApp.CSharpBasics.IO
{
    public class Output
    {
        private static IOutput output;

        public static IOutput Out
        {
            get
            {
                if (output == null)
                {
                    output = new OutputFactory().GetOutputInstance(typeof(ConsoleOutput));
                }

                return output;
            }
        }
    }
}
