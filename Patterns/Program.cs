using LibPhilips;
using System;

namespace Patterns
{
    class Program
    {
        static void Main(string[] args)
        {

            var exp = new AddExpr
            {
                Lhs = new Value { Val = 10 },
                Rhs = new AddExpr
                {
                    Lhs = new Value { Val = 10 },
                    Rhs = new Value { Val = 5 }
                }
            };

            int result = exp.Accept(new CalcVisitor());
            Console.WriteLine(exp.Accept(new Print()));
            Console.WriteLine(result);
            //var ld = new LightDisplay(new KeyboardInputHandler());
            //ld.Run();
        }
    }
}
