using System;

namespace CausalityLibrary.Type
{
    [Serializable]
    public sealed class EmotionalAction : Action
    {
        public readonly string MediaType; // "audio", "image", or "text"
        public readonly string EmotionType; // "3type"(pos/neg/neu), "7type", "av"
        public readonly SerialNumber[] Actions;
        public readonly string[] Emotions;

        public SerialNumber chosenAction;
        public string EmotionalValue;
        public double Arousal = 0;
        public double Valence = 0;
        public string Timestamp;
        public string Info;

        public EmotionalAction(SerialNumber serialNumber, string description,
    string actorName, string mediaType, string emotionType,
    SerialNumber[] actions, string[] emotions,
    string defaultValue = null)
            : base(serialNumber, description, actorName, defaultValue)
        {
            MediaType = mediaType;
            EmotionType = emotionType;
            Actions = actions;
            Emotions = emotions;
        }

        // Don't instantiate with default constructor!
        private EmotionalAction()
        { }
    }
}
