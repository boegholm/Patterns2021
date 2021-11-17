using System;

namespace Patterns
{
    class RedLight : ILight
    {
        ILight DLight { get; }
        public RedLight(ILight light)
        {
            DLight = light;
        }
        public RedLight() : this(new Light())
        {
        }
        public bool On
        {
            get { return DLight.On; }
            set { DLight.On = value; }
        }

        public double Effect { get => DLight.Effect; }

        public void Draw()
        {
            var oldColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            DLight.Draw();
            Console.ForegroundColor = oldColor;
        }
    }
}
