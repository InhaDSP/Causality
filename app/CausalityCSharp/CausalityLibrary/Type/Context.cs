
namespace CausalityLibrary.Type
{
    public sealed class Context
    {
        public string SerialNumber
        { get; }

        public string CurrentScenario
        { get; set; }

        public string CurrentScene
        { get; set; }

        public string CurrentCaption
        { get; set; }

        public Context(string serialNumber)
        {
            SerialNumber = serialNumber;
        }
    }
}
