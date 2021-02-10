package com.inha.dsp.causality.type;

public class Caption {
    private SerialNumber serialNumber;
    private String dialogue;
    private boolean _hasCause;
    private SerialNumber cause;
    private String speakerName;
    private SerialNumber option;
    private SerialNumber nextCaption;
    public final SerialNumber[] DialogueParameter;

    public boolean Displayed;

    public SerialNumber getSerialNumber() {
        return serialNumber;
    }
    public String getDialogue() {
        return dialogue;
    }
    public boolean hasCause() {
        return _hasCause;
    }
    public SerialNumber getCause() {
        return cause;
    }
    public String getSpeakerName() {
        return speakerName;
    }
    public SerialNumber getOption() {
        return option;
    }
    public SerialNumber getNextCaption() {
        return nextCaption;
    }

    // without cause and option
    public Caption(SerialNumber sn, String dial, SerialNumber[] dparam,
                   String sname, SerialNumber ncaption, boolean displayed)
    {
        serialNumber = sn;
        dialogue = dial;
        DialogueParameter = dparam;
        speakerName = sname;
        nextCaption = ncaption;
        Displayed = displayed;
        _hasCause = false;
        option = null;
    }

    // with cause
    public Caption(SerialNumber sn, String dial, SerialNumber[] dparam,
                   String sname, SerialNumber ncaption, boolean dp,
                   SerialNumber cau, boolean hcause)
    {
        serialNumber = sn;
        dialogue = dial;
        DialogueParameter = dparam;
        speakerName = sname;
        nextCaption = ncaption;
        Displayed = dp;
        cause = cau;
        _hasCause = true;
        option = null;
    }

    // with option
    public Caption(SerialNumber sn, String dial, SerialNumber[] dparam,
                   String sname, SerialNumber ncaption, boolean dp,
                   SerialNumber opt)
    {
        serialNumber = sn;
        dialogue = dial;
        DialogueParameter = dparam;
        speakerName = sname;
        nextCaption = ncaption;
        Displayed = dp;
        cause = null;
        _hasCause = false;
        option = opt;
    }

    // with option and cause
    public Caption(SerialNumber sn, String dial, SerialNumber[] dparam,
                   String sname, SerialNumber ncaption, boolean dp,
                   SerialNumber cau, SerialNumber opt)
    {
        serialNumber = sn;
        dialogue = dial;
        DialogueParameter = dparam;
        speakerName = sname;
        nextCaption = ncaption;
        Displayed = dp;
        cause = cau;
        _hasCause = true;
        option = opt;
    }

    // Don't instantiate with default constructor!
    Caption() {
        DialogueParameter = null;
    }
}
