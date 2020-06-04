
namespace CausalityLibrary.Type
{
    public sealed class CustomAction : Action
    {
        public string CustomValue { get; set; }

        public CustomAction(SerialNumber serialNumber, string description,
    string actorName, string defaultValue = null)
            : base(serialNumber, description, actorName, defaultValue)
        {
        }

        // Don't instantiate with default constructor!
        private CustomAction()
        { }
    }
}
