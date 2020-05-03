
namespace CausalityLibrary.Type
{
    public sealed class Cause
    {
        public string SerialNumber
        { get; }

        public string Description
        { get; }

        public string Perceptron
        { get; }

        public readonly string[] Next;
        public readonly double[] Thresholds;

        public Cause(string serialNumber,
            string description, string perceptron,
            string[] next, double[] thresholds)
        {
            SerialNumber = serialNumber;
            Description = description;
            Perceptron = perceptron;
            Next = next;
            Thresholds = thresholds;
        }
    }
}
