using LibPhilips;

namespace Patterns
{
    class PhilipsAdapter : ILight
    {
        PhilipsLight p = new PhilipsLight();

        bool on;
        public bool On
        {
            get
            {
                return on;
            }
            set
            {
                on = value;
                if (on)
                    p.TurnOn();
                else p.TurnOff();
            }
        }

        public double Effect { get; } = 30;

        public void Draw()
        {
            p.Draw();
        }
    }
}
