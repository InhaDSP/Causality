namespace CausalityLibrary.Type
{
    public sealed class Scenario
    {
        public SerialNumber SerialNumber
        { get; }

        public string Description
        { get; }

        public bool Displayed
        { get; set; }

        public readonly SerialNumber[] Scenes;

        public Scenario(SerialNumber serialNumber, string description,
             SerialNumber[] scenes, bool displayed = false)
        {
            SerialNumber = serialNumber;
            Description = description;
            Scenes = scenes;
            Displayed = displayed;
        }
    }
}
