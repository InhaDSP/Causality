using System;

namespace CausalityLibrary.Type
{
    [Serializable]
    public class Score
    {
        public SerialNumber SerialNumber
        { get; }

        public string Description
        { get; }

        public readonly SerialNumber[] Objectives;

        public ScoreRuleEnum ScoreRule { get; }

        public Score(SerialNumber serialNumber, string description,
            ScoreRuleEnum scoreRule, SerialNumber[] objectives)
        {
            SerialNumber = serialNumber;
            Description = description;
            ScoreRule = scoreRule;
            Objectives = objectives;
        }

        // Don't instantiate with default constructor!
        internal Score()
        {
        }
    }
}
