package com.inha.dsp.causality.type;

import java.io.Serializable;

public class Media implements Serializable {
    private SerialNumber serialNumber;
    private SerialNumber targetCaption;
    private String mediaType;
    private String fileName;
    private String thumbnail;

    public SerialNumber getSerialNumber() { return serialNumber; }
    public SerialNumber getTargetCaption() { return targetCaption; }
    public String getMediaType() { return mediaType; }
    public String getFileName() { return fileName; }
    public String getThumbnail() { return thumbnail; }

    public Media(SerialNumber sn, SerialNumber tcap, String mtype, String fname, String tnail)
    {
        serialNumber = sn;
        targetCaption = tcap;
        mediaType = mtype;
        fileName = fname;
        thumbnail = tnail;
    }

    // Don't instantiate with default constructor!
    Media() {}
}
