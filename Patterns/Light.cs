using System;

namespace Patterns
{
    class Light : ILight
    {
        public bool On { get; set; }
        public double Effect { get; } = 20;

        public void Draw()
        {
            Console.Write(On ? "X" : "O");
        }
    }
}
