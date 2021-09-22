using System;
using System.Runtime.Serialization;

namespace CausalityLibrary.Type
{
    [Serializable]
    public enum TypeEnum
    {
        [EnumMember]
        Role,
        [EnumMember]
        Action,
        [EnumMember]
        CustomAction,
        [EnumMember]
        EmotionalAction,
        [EnumMember]
        Perceptron,
        [EnumMember]
        Cause,
        [EnumMember]
        Option,
        [EnumMember]
        Caption,
        [EnumMember]
        Scene,
        [EnumMember]
        Scenario,
        [EnumMember]
        Context,
        [EnumMember]
        Score,
        [EnumMember]
        EmotionScore,
        [EnumMember]
        ScoreFeedback,
        [EnumMember]
        End
    }
}
