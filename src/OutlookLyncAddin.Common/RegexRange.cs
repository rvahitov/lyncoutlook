using System;
using System.Collections.Generic;

namespace OutlookLyncAddin.Common
{
    public class RegexRange : IEquatable<RegexRange>
    {
        public readonly int Start;
        public readonly int Length;

        public RegexRange(int start, int length)
        {
            Start = start;
            Length = length;
        }

        public bool Equals(RegexRange other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return Start == other.Start && Length == other.Length;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((RegexRange) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return (Start*397) ^ Length;
            }
        }

        public static bool operator ==(RegexRange left, RegexRange right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(RegexRange left, RegexRange right)
        {
            return !Equals(left, right);
        }

    }
}