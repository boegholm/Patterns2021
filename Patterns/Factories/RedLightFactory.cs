namespace Patterns
{
    class RedLightFactory : ILightFactory
    {
        public ILight CreateLight() => new RedLight();
    }
}
