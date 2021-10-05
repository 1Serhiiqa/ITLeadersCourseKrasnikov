using System;

namespace ConsoleApp.CSharpBasics.IO.Interfaces
{
    public abstract class IOutputFactory
    {
        public abstract IOutput GetOutputInstance(Type outputType);
    }
}
