using System;

namespace ConsoleApp.CSharpBasics.IO.Interfaces
{
    public abstract class IInputFactory
    {
        public abstract IInput GetInputInstance(Type outputType);
    }
}
