package com.inha.dsp.causality.util;

import com.inha.dsp.causality.type.PositionEnum;

public class StringExtension {
    public static PositionEnum toPosition(String positionStr)
    {
        switch (positionStr)
        {
            case "Leader":
                return PositionEnum.Leader;
            case "Supporter":
                return PositionEnum.Supporter;
            case "Narrator":
                return PositionEnum.Narrator;
            case "Extra":
            default:
                return PositionEnum.Extra;
        }
    }
}
