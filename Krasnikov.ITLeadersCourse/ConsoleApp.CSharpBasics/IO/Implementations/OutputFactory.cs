using ConsoleApp.CSharpBasics.IO.Interfaces;
using System;

namespace ConsoleApp.CSharpBasics.IO.Implementations
{
    public class OutputFactory : IOutputFactory
    {
        public override IOutput GetOutputInstance(Type outputType)
        {
            switch (outputType)
            {
                case Type when outputType == typeof(ConsoleOutput):
                    return new ConsoleOutput();
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
