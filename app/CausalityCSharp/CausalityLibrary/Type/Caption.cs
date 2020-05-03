
namespace CausalityLibrary.Type
{
    public class Caption
    {
        public string SerialNumber
        { get; }

        public string Dialogue
        { get; }

        public bool HasCause
        { get; }

        public string Cause
        { get; }

        public string SpeakerName
        { get; }

        public string Option
        { get; }
        
        public string NextCaption
        { get; }

        public bool Displayed
        { get; set; }

        /// <summary>
        /// w.o cause and option
        /// </summary>
        /// <param name="serialNumber"></param>
        /// <param name="dialogue"></param>
        /// <param name="speakerName"></param>
        /// <param name="nextCaption"></param>
        /// <param name="displayed"></param>
        public Caption(string serialNumber, string dialogue,
            string speakerName, string nextCaption,
            bool displayed = false) 
        {
            SerialNumber = serialNumber;
            Dialogue = dialogue;
            SpeakerName = speakerName;
            NextCaption = nextCaption;
            Displayed = displayed;
        }

        /// <summary>
        /// with cause
        /// </summary>
        /// <param name="serialNumber"></param>
        /// <param name="dialogue"></param>
        /// <param name="speakerName"></param>
        /// <param name="nextCaption"></param>
        /// <param name="displayed"></param>
        /// <param name="cause"></param>
        /// <param name="hasCause"></param>
        public Caption(string serialNumber, string dialogue,
            string speakerName, string nextCaption,
            bool displayed, string cause, bool hasCause = true)
        {
            SerialNumber = serialNumber;
            Dialogue = dialogue;
            SpeakerName = speakerName;
            NextCaption = nextCaption;
            Displayed = displayed;
            Cause = cause;
            HasCause = true;
        }

        /// <summary>
        /// with option
        /// </summary>
        /// <param name="serialNumber"></param>
        /// <param name="dialogue"></param>
        /// <param name="speakerName"></param>
        /// <param name="nextCaption"></param>
        /// <param name="displayed"></param>
        /// <param name="option"></param>
        public Caption(string serialNumber, string dialogue,
            string speakerName, string nextCaption,
            bool displayed, string option)
        {
            SerialNumber = serialNumber;
            Dialogue = dialogue;
            SpeakerName = speakerName;
            NextCaption = nextCaption;
            Displayed = displayed;
            Option = option;
        }

        /// <summary>
        /// with option and cause
        /// </summary>
        /// <param name="serialNumber"></param>
        /// <param name="dialogue"></param>
        /// <param name="speakerName"></param>
        /// <param name="nextCaption"></param>
        /// <param name="displayed"></param>
        /// <param name="cause"></param>
        /// <param name="option"></param>
        public Caption(string serialNumber, string dialogue,
            string speakerName, string nextCaption,
            bool displayed, string cause, string option)
        {
            SerialNumber = serialNumber;
            Dialogue = dialogue;
            SpeakerName = speakerName;
            NextCaption = nextCaption;
            Displayed = displayed;
            Cause = cause;
            HasCause = true;
            Option = option;
        }

        // Don't instantiate with default constructor!
        private Caption() { }
    }
}
