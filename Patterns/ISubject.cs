namespace Patterns
{
    interface ISubject
    {
        void RegisterObserver(IObserver observer);
        void UnregisterObserver(IObserver observer);
    }
}
