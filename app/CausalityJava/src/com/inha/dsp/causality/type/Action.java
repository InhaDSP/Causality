package com.inha.dsp.causality.type;

import java.io.Serializable;

public class Action implements Serializable {
    private SerialNumber serialNumber;
    private String description;
    private String defaultValue;
    private String actorName;
    public boolean IsPerformed;

    public SerialNumber getSerialNumber() {
        return serialNumber;
    }
    public String getDescription() {
        return description;
    }
    public String getDefaultValue() {
        return defaultValue;
    }
    public String getActorName() {
        return actorName;
    }

    public Action(SerialNumber sn, String desc, String aname, String dvalue)
    {
        serialNumber = sn;
        description = desc;
        actorName = aname;
        defaultValue = dvalue;
        IsPerformed = false;
    }

    // Don't instantiate with default constructor!
    Action() {}
}
