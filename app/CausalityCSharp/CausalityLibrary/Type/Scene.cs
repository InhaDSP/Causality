
namespace CausalityLibrary.Type
{
    public sealed class Scene
    {
        public string SerialNumber
        { get; }

        public string Description
        { get; }

        public string Caption
        { get; }

        public bool HasCause
        { get; }

        public string Cause
        { get; }

        public bool Displayed
        { get; set; }

        public Scene(string serialNumber,
            string description, string caption,
            bool displayed = false)
        {
            SerialNumber = serialNumber;
            Description = description;
            Caption = caption;
            Displayed = displayed;
        }
        public Scene(string serialNumber,
            string description, string caption,
            string cause, bool displayed = false)
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
