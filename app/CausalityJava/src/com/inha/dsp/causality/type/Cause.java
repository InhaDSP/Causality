package com.inha.dsp.causality.type;

public class Cause {
    private SerialNumber serialNumber;
    private String description;
    private SerialNumber perceptron;

    public SerialNumber getSerialNumber() {
        return serialNumber;
    }
    public String getDescription() {
        return description;
    }
    public SerialNumber getPerceptron() {
        return perceptron;
    }

    public final SerialNumber[] Next;
    public final double[] Thresholds;

    public Cause(SerialNumber sn, String desc, SerialNumber perc,
                 SerialNumber[] next, double[] thresh)
    {
        serialNumber = sn;
        description = desc;
        perceptron = perc;
        Next = next;
        Thresholds = thresh;
    }
}
