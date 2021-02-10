package com.inha.dsp.causality.type;

public class Scenario {
    private SerialNumber serialNumber;
    private String description;

    public SerialNumber getSerialNumber() {
        return serialNumber;
    }
    public String getDescription() {
        return description;
    }
    public boolean Displayed;
    public final SerialNumber[] Scenes;

    public Scenario(SerialNumber sn, String desc, SerialNumber[] scenes,
                    boolean displayed)
    {
        serialNumber = sn;
        description = desc;
        Scenes = scenes;
        Displayed = displayed;
    }

    // Don't instantiate with default constructor!
    Scenario() {
        Scenes = null;
    }
}
