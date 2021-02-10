package com.inha.dsp.causality.type;

public class SerialNumber {
    private TypeEnum type;
    private int index;
    private String rawSerial;

    public TypeEnum getType() {
        return type;
    }
    public int getIndex() {
        return index;
    }
    @Override
    public String toString() {
        return rawSerial;
    }

    public SerialNumber(String fullSerial)
    {
        rawSerial = fullSerial;
        var classStr = fullSerial.substring(0, 3);
        if (classStr.equals("END"))
        {
            type = TypeEnum.End;
            index = 0;
        }
        else
        {
            switch (classStr)
            {
                case "ROL":
                    type = TypeEnum.Role;
                    break;
                case "ACT":
                    type = TypeEnum.Action;
                    break;
                case "CUS":
                    type = TypeEnum.CustomAction;
                    break;
                case "PER":
                    type = TypeEnum.Perceptron;
                    break;
                case "CAU":
                    type = TypeEnum.Cause;
                    break;
                case "OPT":
                    type = TypeEnum.Option;
                    break;
                case "CAP":
                    type = TypeEnum.Caption;
                    break;
                case "SNE":
                    type = TypeEnum.Scene;
                    break;
                case "SNR":
                    type = TypeEnum.Scenario;
                    break;
                default:
                    // Exception?
                    break;
            }
            index = Integer.parseInt(fullSerial.substring(3));
        }
    }

    @Override
    public boolean equals(Object obj) {
        if(obj.getClass() == this.getClass()) {
            return equals((SerialNumber)obj);
        }
        return false;
    }

    public boolean equals(SerialNumber sn) {
        if(sn == null) {
            return false;
        }
        if(this == sn) {
            return true;
        }
        return (type == sn.getType()) && (index == sn.getIndex());
    }

    @Override
    public int hashCode() {
        return rawSerial.hashCode();
    }
}
