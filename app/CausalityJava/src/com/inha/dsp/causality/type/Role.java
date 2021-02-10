package com.inha.dsp.causality.type;

public class Role {
    private SerialNumber serialNumber;
    private String description;
    private String name;
    private PositionEnum position;

    public SerialNumber getSerialNumber() {
        return serialNumber;
    }
    public String getDescription() {
        return description;
    }
    public String getName() {
        return name;
    }
    public PositionEnum getPosition() {
        return position;
    }

    public Role(SerialNumber sn, String desc, String na, PositionEnum pos)
    {
        serialNumber = sn;
        description = desc;
        name = na;
        position = pos;
    }

    // Don't instantiate with default constructor!
    Role() {}
}
