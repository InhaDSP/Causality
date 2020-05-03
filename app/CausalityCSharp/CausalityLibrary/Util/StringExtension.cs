using System;
using System.Collections.Generic;
using System.Text;

namespace CausalityLibrary.Util
{
    public static class StringExtension
    {
        public static PositionEnum toPosition(this string positionStr)
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
}
