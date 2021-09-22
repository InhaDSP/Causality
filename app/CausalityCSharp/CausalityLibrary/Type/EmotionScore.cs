using System;

namespace CausalityLibrary.Type
{
    [Serializable]
    public sealed class EmotionScore : Score
    {
        public string EmotionType { get; }
        public readonly string[] ObjectEmotion;

        public EmotionScore(SerialNumber serialNumber, string description,
            ScoreRuleEnum scoreRule, string emotionType, string[] objectEmotion,
            SerialNumber[] objective = null)
            : base(serialNumber, description, scoreRule, objective)
        {
            EmotionType = emotionType;
            ObjectEmotion = objectEmotion;
        }

        // Don't instantiate with default constructor!
        internal EmotionScore()
        { }
    }
}
