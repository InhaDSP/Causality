using System;

namespace CausalityLibrary.Type
{
    [Serializable]
    public sealed class Scene
    {
        public SerialNumber SerialNumber
        { get; }

        public string Description
        { get; }

        public SerialNumber Caption
        { get; }

        public bool HasCause
        { get; }

        public SerialNumber Cause
        { get; }

        public bool Displayed
        { get; set; }

        public Scene(SerialNumber serialNumber,
            string description, SerialNumber caption,
            bool displayed = false)
        {
            SerialNumber = serialNumber;
            Description = description;
            Caption = caption;
            Displayed = displayed;
        }
        public Scene(SerialNumber serialNumber,
            string description, SerialNumber caption,
            SerialNumber cause, bool displayed = false)
        {
            SerialNumber = serialNumber;
            Description = description;
            Caption = caption;
            Cause = cause;
            HasCause = true;
            Displayed = displayed;
        }

        // Don't instantiate with default constructor!
        private Scene() { }
    }
}
