package com.inha.dsp.causality.type;

import java.io.Serializable;
import java.util.ArrayList;

public class Option implements Serializable {
    private SerialNumber serialNumber;
    private String description;
    private boolean multiple;
    public final SerialNumber[] Actions;
    public final ArrayList<SerialNumber> ChosenActions = new ArrayList<>();

    public SerialNumber getSerialNumber() {
        return serialNumber;
    }
    public String getDescription() {
        return description;
    }
    public boolean isMultiple() {
        return multiple;
    }

    public Option(SerialNumber sn, String desc, SerialNumber[] actions,
                  boolean multi)
    {
        serialNumber = sn;
        description = desc;
        Actions = actions;
        multiple = multi;
    }

    // Don't instantiate with default constructor!
    Option() {
        Actions = null;
    }
}
