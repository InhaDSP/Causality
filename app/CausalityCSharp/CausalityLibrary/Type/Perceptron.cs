using System;

namespace CausalityLibrary.Type
{
    [Serializable]
    public sealed class Perceptron
    {
        public SerialNumber SerialNumber
        { get; }

        public string Description
        { get; }

        public readonly SerialNumber[] Inputs;
        public readonly double[] Weights;

        public double Bias
        { get; }

        public Perceptron(SerialNumber serialNumber, string description,
            double bias, SerialNumber[] inputs, double[] weights)
        {
            SerialNumber = serialNumber;
            Description = description;
            Bias = bias;
            Inputs = inputs;
            Weights = weights;
        }

        // Don't instantiate with default constructor!
        private Perceptron() { }
    }
}
