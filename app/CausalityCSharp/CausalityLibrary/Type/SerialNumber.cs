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
                    case "CUS":
                        Type = TypeEnum.CustomAction;
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

        public override bool Equals(object obj)
        {
            if (obj is SerialNumber)
            {
                return Equals((SerialNumber)obj);
            }
            return false;
        }

        public bool Equals(SerialNumber sn)
        {
            // If parameter is null, return false.
            if (ReferenceEquals(sn, null))
            {
                return false;
            }

            // Optimization for a common success case.
            if (ReferenceEquals(this, sn))
            {
                return true;
            }

            // If run-time types are not exactly the same, return false.
            if (GetType() != sn.GetType())
            {
                return false;
            }

            return (Type == sn.Type) && (Index == sn.Index);
        }

        public override int GetHashCode()
        {
            return rawSerial.GetHashCode();
        }

        public static bool operator ==(SerialNumber lhs, SerialNumber rhs)
        {
            // Check for null on left side.
            if (ReferenceEquals(lhs, null))
            {
                if (ReferenceEquals(rhs, null))
                {
                    // null == null = true.
                    return true;
                }

                // Only the left side is null.
                return false;
            }
            // Equals handles case of null on right side.
            return lhs.Equals(rhs);
        }

        public static bool operator !=(SerialNumber lhs, SerialNumber rhs)
        {
            return !(lhs == rhs);
        }
    }
}
