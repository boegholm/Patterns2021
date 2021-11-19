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
                Lhs = new IntExpr { Val = 10 },
                Rhs = new AddExpr
                {
                    Lhs = new IntExpr { Val = 10 },
                    Rhs = new IntExpr { Val = 5 }
                }
            };

            int result = exp.Accept(new CalcVisitor());
            Console.WriteLine(exp.Accept(new PrintVisitor()));
            Console.WriteLine(result);
            //var ld = new LightDisplay(new KeyboardInputHandler());
            //ld.Run();
        }
    }
}
