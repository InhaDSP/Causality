using System.Collections.Generic;

namespace CausalityLibrary.Type
{
    public sealed class Option
    {
        public string SerialNumber
        { get; }

        public string Description
        { get; }

        public readonly string[] Actions;

        public bool IsMultiple
        { get; }

        public readonly List<string> ChosenActions = new List<string>();

        public Option(string serialNumber, string description,
            string[] actions, bool isMultiple)
        {
            SerialNumber = serialNumber;
            Description = description;
            Actions = actions;
            IsMultiple = isMultiple;
        }

        // Don't instantiate with default constructor!
        private Option() { }
    }
}
