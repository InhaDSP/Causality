package com.inha.dsp.causality.type;

import java.io.Serializable;

public class CustomAction extends Action implements Serializable {
    private String customValue;
    public String getCustomValue() {
        return customValue;
    }
    public void setCustomValue(String cv) {
        customValue = cv;
    }

    public CustomAction(SerialNumber sn, String desc, String aname,
        String dvalue)
    {
        super(sn, desc, aname, dvalue);
    }

    // Don't instantiate with default constructor!
    CustomAction() {}
}
