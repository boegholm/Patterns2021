using LibPhilips;
using System;

namespace Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            var ld = new LightDisplay(new KeyboardInputHandler());
            ld.Run();
        }
    }
}
