using System;

namespace CausalityLibrary.Type
{
    public sealed class Context
    {
        public Guid GUID
        { get; }

        public string CurrentScenario
        { get; set; }

        public string CurrentScene
        { get; set; }

        public string CurrentCaption
        { get; set; }

        public Context(Guid guid)
        {
            GUID = guid;
        }
    }
}
