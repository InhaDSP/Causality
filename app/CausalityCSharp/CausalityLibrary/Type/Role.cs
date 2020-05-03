
namespace CausalityLibrary.Type
{
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

        public Role(SerialNumber serialNumber, string description,
            string name, PositionEnum position)
        {
            SerialNumber = serialNumber;
            Description = description;
            Name = name;
            Position = position;
        }

        // Don't instantiate with default constructor!
        private Role() { }
    }
}
