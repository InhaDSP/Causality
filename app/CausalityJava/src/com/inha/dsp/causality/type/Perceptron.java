package com.inha.dsp.causality.type;

import java.io.Serializable;

public class Perceptron implements Serializable {
    private SerialNumber serialNumber;
    private String description;
    private double bias;

    public SerialNumber getSerialNumber() {
        return serialNumber;
    }
    public String getDescription() {
        return description;
    }
    public double getBias(){
        return bias;
    }

    public final SerialNumber[] Inputs;
    public final double[] Weights;

    public Perceptron(SerialNumber sn, String desc, double bi,
        SerialNumber[] inputs, double[] weights)
    {
        serialNumber = sn;
        description = desc;
        bias = bi;
        Inputs = inputs;
        Weights = weights;
    }

    // Don't instantiate with default constructor!
    Perceptron() {
        Inputs = null;
        Weights = null;
    }
}
