using System;
using System.Runtime.Serialization;

namespace CausalityLibrary.Type
{
    [Serializable]
    public enum ScoreFeedbackEnum
    {
        /// <summary>
        /// 특정 점수값의 범위에 따라 피드백을 다르게 주는 형태
        /// 예) 0~2점: 피드백A, 3점: 피드백B, 4~5점: 피드백C
        /// </summary>
        [EnumMember]
        QuantizedClassification
    }
}
