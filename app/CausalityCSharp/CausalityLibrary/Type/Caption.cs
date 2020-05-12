
namespace CausalityLibrary.Type
{
    public class Caption
    {
        public SerialNumber SerialNumber
        { get; }

        public string Dialogue
        { get; }

        public bool HasCause
        { get; }

        public SerialNumber Cause
        { get; }

        public string SpeakerName
        { get; }

        public SerialNumber Option
        { get; }
        
        public SerialNumber NextCaption
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
        public Caption(SerialNumber serialNumber, string dialogue,
            string speakerName, SerialNumber nextCaption,
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
        public Caption(SerialNumber serialNumber, string dialogue,
            string speakerName, SerialNumber nextCaption,
            bool displayed, SerialNumber cause, bool hasCause = true)
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
        public Caption(SerialNumber serialNumber, string dialogue,
            string speakerName, SerialNumber nextCaption,
            bool displayed, SerialNumber option)
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
        public Caption(SerialNumber serialNumber, string dialogue,
            string speakerName, SerialNumber nextCaption,
            bool displayed, SerialNumber cause, SerialNumber option)
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
