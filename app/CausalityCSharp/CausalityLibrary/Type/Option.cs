using System;
using System.Collections.Generic;

namespace CausalityLibrary.Type
{
    [Serializable]
    public sealed class Option
    {
        public SerialNumber SerialNumber
        { get; }

        public string Description
        { get; }

        public readonly SerialNumber[] Actions;

        public bool IsMultiple
        { get; }

        public readonly List<SerialNumber> ChosenActions = new List<SerialNumber>();

        public Option(SerialNumber serialNumber, string description,
            SerialNumber[] actions, bool isMultiple)
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
