using System;
using System.Diagnostics;

namespace OutlookLyncAddin.Common
{
    public class TextReplacementLocation : IEquatable<TextReplacementLocation>
    {

        public readonly int Length;
        public readonly int Start;
        public readonly string Replacement;

        public bool Contains(TextReplacementLocation other)
        {
            if (other == null) throw new ArgumentNullException("other");
            
            return Start <= other.Start && (Start + Length) >= (other.Start + other.Length);
        }

        public TextReplacementLocation(int start, int length, string replacement)
        {
            Start = start;
            Length = length;
            Replacement = replacement;
        }

        public bool Equals(TextReplacementLocation other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return Start == other.Start && Length == other.Length;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != GetType()) return false;
            return Equals((TextReplacementLocation) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return (Start*397) ^ Length;
            }
        }

        public static bool operator ==(TextReplacementLocation left, TextReplacementLocation right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(TextReplacementLocation left, TextReplacementLocation right)
        {
            return !Equals(left, right);
        }

        public override string ToString()
        {
            return string.Format("Start: {0}, Length: {1}, Replacement: {2}", Start, Length, Replacement);
        }
    }
}