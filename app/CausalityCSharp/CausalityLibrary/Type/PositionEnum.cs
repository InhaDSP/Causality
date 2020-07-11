using System;
using System.Runtime.Serialization;

namespace CausalityLibrary
{
    [Serializable]
    public enum PositionEnum
    {
        [EnumMember]
        Leader,
        [EnumMember]
        Supporter,
        [EnumMember]
        Narrator,
        [EnumMember]
        Extra
    }
}
