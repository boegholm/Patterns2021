using LibOsramLight;

namespace Patterns
{
    class OsramAdapter : ILight
    {
        OsramLight o = new OsramLight();
        public bool On
        {
            get
            {
                return o.Intensity != OsramLight.LightIntensity.Off;
            }
            set
            {
                if (value) o.Intensity = OsramLight.LightIntensity.High;
                else o.Intensity = OsramLight.LightIntensity.Off;
            }
        }

        public double Effect { get; } = 40;

        public void Draw()
        {
            o.Draw();
        }
    }
}
