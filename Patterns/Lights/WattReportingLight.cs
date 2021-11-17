using System.Collections.Generic;
using System.Threading;

namespace Patterns
{
    class WattReportingLight : ILight, ISubject
    {
        static object l = new object();
        ILight DLight;
        Timer t;
        public WattReportingLight(ILight dLight)
        {
            DLight = dLight;
            t = new Timer((o) =>
              {
                  foreach (var item in _observers)
                  {
                      if (On)
                      {
                          lock (l)
                          {
                              item.Update(Effect / (60.0 * 60));
                          }
                      }
                  }
              });
            
            t.Change(1000, 1000);
        }

        public bool On
        {
            get { return DLight.On; }
            set { DLight.On = value; }
        }

        public double Effect { get => DLight.Effect; }

        public void Draw()
        {
            DLight.Draw();
        }
        List<IObserver> _observers = new List<IObserver>();
        public void RegisterObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void UnregisterObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }
    }
}
