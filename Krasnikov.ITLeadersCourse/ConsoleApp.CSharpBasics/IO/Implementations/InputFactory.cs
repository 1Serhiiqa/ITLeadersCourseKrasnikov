using ConsoleApp.CSharpBasics.IO.Interfaces;
using System;

namespace ConsoleApp.CSharpBasics.IO.Implementations
{
    public class InputFactory : IInputFactory
    {

        public override IInput GetInputInstance(Type inputType)
        {
            switch (inputType)
            {
                case Type when inputType == typeof(ConsoleInput):
                    return new ConsoleInput();
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
