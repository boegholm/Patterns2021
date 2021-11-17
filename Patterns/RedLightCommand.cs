namespace Patterns
{
    class RedLightCommand : ICommand
    {
        public LightDisplay LightDisplay { get; set; }

        public RedLightCommand(LightDisplay lightDisplay)
        {
            LightDisplay = lightDisplay;
        }

        public void Execute()
        {
            LightDisplay.LightFactory = new RedLightFactory();
        }
    }
}
