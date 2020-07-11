using System;

namespace CausalityLibrary.Type
{
    [Serializable]
    public class Action
    {
        public SerialNumber SerialNumber
        { get; }

        public string Description
        { get; }

        public string DefaultValue
        { get; }

        public string ActorName
        { get; }

        public bool IsPerformed
        { get; set; }

        public Action(SerialNumber serialNumber, string description,
            string actorName, string defaultValue = null)
        {
            SerialNumber = serialNumber;
            Description = description;
            DefaultValue = defaultValue;
            ActorName = actorName;
            IsPerformed = false;
        }

        // Don't instantiate with default constructor!
        internal Action() { }
    }
}
