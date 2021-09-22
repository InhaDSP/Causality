using System;
using System.Collections.Generic;
using System.Text;

namespace CausalityLibrary.Type
{
    [Serializable]
    public class ScoreFeedback
    {
        public SerialNumber SerialNumber
        { get; }

        public string Description
        { get; }

        public ScoreFeedbackEnum FeedbackRule { get; }

        public SerialNumber Score { get; }

        /// <summary>
        /// 점수 범위
        /// 예) QuantizedClassification일 경우: [1, 3, 4, 5] == 0~1점, 2~3점, 4점, 5점
        /// </summary>
        public double[] ScoreStep;

        /// <summary>
        /// 위의 ScoreStep과 항상 짝이 맞아야함(같은 크기)
        /// </summary>
        public string[] ScoreMessage;

        public ScoreFeedback(SerialNumber serialNumber, string description,
            ScoreFeedbackEnum feedbackRule, SerialNumber score,
            double[] scoreStep, string[] scoreMessage)
        {
            SerialNumber = serialNumber;
            Description = description;
            FeedbackRule = feedbackRule;
            Score = score;
            ScoreStep = scoreStep;
            ScoreMessage = scoreMessage;
        }

        // Don't instantiate with default constructor!
        internal ScoreFeedback()
        { }
    }
}
