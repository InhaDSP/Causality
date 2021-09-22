using CausalityLibrary.Type;
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

        public static ScoreRuleEnum toScoreRule(this string scoreRuleStr)
        {
            switch (scoreRuleStr)
            {
                case "SimpleAccumulation":
                    return ScoreRuleEnum.SimpleAccumulation;
                case "EntireEmotionResult":
                    return ScoreRuleEnum.EntireEmotionResult;
                default:
                    return ScoreRuleEnum.SimpleAccumulation;
            }
        }

        public static ScoreFeedbackEnum toScoreFeedback(this string scoreFeedbackStr)
        {
            switch (scoreFeedbackStr)
            {
                case "QuantizedClassification":
                    return ScoreFeedbackEnum.QuantizedClassification;
                default:
                    return ScoreFeedbackEnum.QuantizedClassification;
            }
        }
    }
}
