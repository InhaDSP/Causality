
namespace CausalityLibrary.Type
{
    public sealed class Cause
    {
        public SerialNumber SerialNumber
        { get; }

        public string Description
        { get; }

        public string Perceptron
        { get; }

        public readonly SerialNumber[] Next;
        public readonly double[] Thresholds;

        public Cause(SerialNumber serialNumber,
            string description, string perceptron,
            SerialNumber[] next, double[] thresholds)
        {
            SerialNumber = serialNumber;
            Description = description;
            Perceptron = perceptron;
            Next = next;
            Thresholds = thresholds;
        }
    }
}
