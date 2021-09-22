
using System;

namespace CausalityLibrary.Type
{
    [Serializable]
    public sealed class Role
    {
        public SerialNumber SerialNumber
        { get; }

        public string Description
        { get; }

        public string Name
        { get; }

        public PositionEnum Position
        { get; }

        public string Voice
        { get; }

        public Role(SerialNumber serialNumber, string description,
            string name, PositionEnum position, string voice)
        {
            SerialNumber = serialNumber;
            Description = description;
            Name = name;
            Position = position;
            Voice = voice;
        }

        // Don't instantiate with default constructor!
        private Role() { }
    }
}
