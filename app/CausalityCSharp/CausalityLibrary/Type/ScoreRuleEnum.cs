using System;
using System.Runtime.Serialization;

namespace CausalityLibrary.Type
{
    [Serializable]
    public enum ScoreRuleEnum
    {
        /// <summary>
        /// 단순히 true 값을 가진 IsPerformed 속성을 가진 요소들을 1로 간주하여 합산
        /// </summary>
        [EnumMember]
        SimpleAccumulation,
        /// <summary>
        /// 이걸 여기에 추가하는게 맞는진 모르겠음...
        /// 범불안장애 최종 결과 화면에 스크리닝 참여하는 동안 수집된
        /// 특정 감정이 차지하는 비율을 표시하는 부분이 있어서 그걸 구현하기 위해 추가한 룰임
        /// EmotionScore에 사용할 것
        /// </summary>
        [EnumMember]
        EntireEmotionResult
    }
}
