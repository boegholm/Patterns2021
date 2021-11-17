namespace Patterns
{
    class GLightFactory<T> : ILightFactory where T : ILight, new()
    {
        public ILight CreateLight() => new T();
    }
}
