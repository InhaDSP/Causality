package com.inha.dsp.causality.type;

import java.io.Serializable;

public class Scene implements Serializable {
    private SerialNumber serialNumber;
    private String description;
    private SerialNumber caption;
    private SerialNumber cause;
    private boolean hascause;

    public SerialNumber getSerialNumber() {
        return serialNumber;
    }
    public String getDescription() {
        return description;
    }
    public SerialNumber getCaption() {
        return caption;
    }
    public boolean hasCause() {
        return hascause;
    }
    public boolean Displayed;

    public Scene(SerialNumber sn, String desc, SerialNumber cap,
                 boolean displayed)
    {
        serialNumber = sn;
        description = desc;
        caption = cap;
        cause = null;
        hascause = false;
        Displayed = displayed;
    }

    public Scene(SerialNumber sn, String desc, SerialNumber cap,
                 SerialNumber cau, boolean displayed)
    {
        serialNumber = sn;
        description = desc;
        caption = cap;
        cause = cau;
        hascause = true;
        Displayed = displayed;
    }

    // Don't instantiate with default constructor!
    Scene(){}
}
