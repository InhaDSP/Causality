﻿using System;

namespace CausalityLibrary.Type
{
    [Serializable]
    public sealed class Cause
    {
        public SerialNumber SerialNumber
        { get; }

        public string Description
        { get; }

        public SerialNumber Perceptron
        { get; }

        public readonly SerialNumber[] Next;
        public readonly double[] Thresholds;

        public Cause(SerialNumber serialNumber,
            string description, SerialNumber perceptron,
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
