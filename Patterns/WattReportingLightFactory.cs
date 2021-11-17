namespace Patterns
{
    class WattReportingLightFactory : ILightFactory
    {
        ILightFactory l;

        public WattReportingLightFactory(ILightFactory l, IObserver observer)
        {
            this.l = l;
            Observer = observer;
        }

        public IObserver Observer { get; }

        public ILight CreateLight()
        {
            var light= new WattReportingLight(l.CreateLight());
            light.RegisterObserver(Observer);
            return light;
        }
    }
}
