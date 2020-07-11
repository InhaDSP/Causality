using System;

namespace CausalityLibrary.Type
{
    [Serializable]
    public sealed class Context
    {
        public Guid GUID
        { get; }

        public SerialNumber CurrentScenario
        { get; set; }

        public SerialNumber CurrentScene
        { get; set; }

        public SerialNumber CurrentCaption
        { get; set; }

        public Context(Guid guid)
        {
            GUID = guid;
        }
    }
}
