using System;
using System.Collections.Generic;
using System.Text;

namespace CausalityLibrary.Type
{
    public class SerialNumber
    {
        public TypeEnum Type
        { get; }
        public uint Index
        { get; }

        public SerialNumber(string fullSerial)
        {
            rawSerial = fullSerial;
            var classStr = fullSerial.Substring(0, 3);
            if (classStr.Equals("END"))
            {
                Type = TypeEnum.End;
                Index = 0;
            }
            else
            {
                switch (classStr)
                {
                    case "ROL":
                        Type = TypeEnum.Role;
                        break;
                    case "ACT":
                        Type = TypeEnum.Action;
                        break;
                    case "PER":
                        Type = TypeEnum.Perceptron;
                        break;
                    case "CAU":
                        Type = TypeEnum.Cause;
                        break;
                    case "OPT":
                        Type = TypeEnum.Option;
                        break;
                    case "CAP":
                        Type = TypeEnum.Caption;
                        break;
                    case "SNE":
                        Type = TypeEnum.Scene;
                        break;
                    case "SNR":
                        Type = TypeEnum.Scenario;
                        break;
                    default:
                        // Exception?
                        break;
                }
                Index = uint.Parse(fullSerial.Substring(3));
            }
        }

        public override string ToString()
        {
            return rawSerial;
        }

        private string rawSerial;
    }
}
