
namespace CausalityLibrary.Type
{
    public sealed class Action
    {
        public SerialNumber SerialNumber
        { get; }

        public string Description
        { get; }

        public string Value
        { get; }

        public string ActorName
        { get; }

        public bool IsPerformed
        { get; set; }

        public Action(SerialNumber serialNumber, string description,
            string actorName, string value, bool isPerformed = false)
        {
            SerialNumber = serialNumber;
            Description = description;
            Value = value;
            ActorName = actorName;
            IsPerformed = isPerformed;
        }

        public Action(SerialNumber serialNumber, string description,
            string actorName, bool isPerformed = false)
        {
            SerialNumber = serialNumber;
            Description = description;
            Value = string.Empty;
            ActorName = actorName;
            IsPerformed = isPerformed;
        }

        // Don't instantiate with default constructor!
        private Action() { }
    }
}
