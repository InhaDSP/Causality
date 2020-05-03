using System.Collections.Generic;

namespace CausalityLibrary.Type
{
    public sealed class Scenario
    {
        string SerialNumber
        { get; }

        public string Description
        { get; }

        public bool Displayed
        { get; set; }

        public readonly string[] Scenes;

        public Scenario(string serialNumber, string description,
             string[] scenes, bool displayed = false)
        {
            SerialNumber = serialNumber;
            Description = description;
            Scenes = scenes;
            Displayed = displayed;
        }
    }
}
