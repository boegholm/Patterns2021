namespace Patterns
{
    class GLightFactoryCommand<T> : ICommand where T : ILight, new()
    {
        LightDisplay ld;

        public GLightFactoryCommand(LightDisplay ld)
        {
            this.ld = ld;
        }
        public void Execute() => ld.LightFactory = new GLightFactory<T>();
    }
}
