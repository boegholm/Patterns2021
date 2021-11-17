namespace Patterns
{
    class DefaultLightCommand : ICommand
    {
        public LightDisplay LightDisplay { get; set; }

        public DefaultLightCommand(LightDisplay lightDisplay)
        {
            LightDisplay = lightDisplay;
        }

        public void Execute()
        {
            LightDisplay.LightFactory = new LightDisplay.DefaultLightFactory();
        }
    }
}
