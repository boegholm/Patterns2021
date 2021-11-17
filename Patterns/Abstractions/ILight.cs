namespace Patterns
{
    interface ILight
    {
        bool On { get; set; }
        void Draw();
        double Effect { get; }
    }
}
