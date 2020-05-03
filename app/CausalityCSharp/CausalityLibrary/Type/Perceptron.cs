using System.Collections.Generic;

namespace CausalityLibrary.Type
{
    public sealed class Perceptron
    {
        public string SerialNumber
        { get; }

        public string Description
        { get; }

        public readonly string[] Inputs;
        public readonly double[] Weights;

        public double Bias
        { get; }

        public Perceptron(string serialNumber, string description,
            double bias, string[] inputs, double[] weights)
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
