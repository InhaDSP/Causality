using System;

namespace CausalityLibrary.Type
{
    [Serializable]
    public class Caption
    {
        public SerialNumber SerialNumber
        { get; }

        public string Dialogue
        { get; }

        public readonly SerialNumber[] DialogueParameter;

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
        public Caption(SerialNumber serialNumber,
            string dialogue, SerialNumber[] dialogueParameter,
            string speakerName, SerialNumber nextCaption,
            bool displayed = false) 
        {
            SerialNumber = serialNumber;
            Dialogue = dialogue;
            DialogueParameter = dialogueParameter;
            SpeakerName = speakerName;
            NextCaption = nextCaption;
            Displayed = displayed;
        }

        /// <summary>
        /// with cause
        /// </summary>
        public Caption(SerialNumber serialNumber, 
            string dialogue, SerialNumber[] dialogueParameter,
            string speakerName, SerialNumber nextCaption,
            bool displayed, SerialNumber cause, bool hasCause = true)
        {
            SerialNumber = serialNumber;
            Dialogue = dialogue;
            DialogueParameter = dialogueParameter;
            SpeakerName = speakerName;
            NextCaption = nextCaption;
            Displayed = displayed;
            Cause = cause;
            HasCause = true;
        }

        /// <summary>
        /// with option
        /// </summary>
        public Caption(SerialNumber serialNumber,
            string dialogue, SerialNumber[] dialogueParameter,
            string speakerName, SerialNumber nextCaption,
            bool displayed, SerialNumber option)
        {
            SerialNumber = serialNumber;
            Dialogue = dialogue;
            DialogueParameter = dialogueParameter;
            SpeakerName = speakerName;
            NextCaption = nextCaption;
            Displayed = displayed;
            Option = option;
        }

        /// <summary>
        /// with option and cause
        /// </summary>
        public Caption(SerialNumber serialNumber,
            string dialogue, SerialNumber[] dialogueParameter,
            string speakerName, SerialNumber nextCaption,
            bool displayed, SerialNumber cause, SerialNumber option)
        {
            SerialNumber = serialNumber;
            Dialogue = dialogue;
            DialogueParameter = dialogueParameter;
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
