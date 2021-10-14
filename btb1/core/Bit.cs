using System;

namespace core
{
    /// <summary>
    /// conceptual properties of a bit as a c# class
    /// </summary>
    public sealed class Bit
    {
        public bool Value { get; set; }

        public Bit(bool initialValue = false)
        {
            Value = initialValue;
        }

        public override bool Equals(object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                var objBit = obj as Bit;
                if (objBit == null)
                    return false;
                else
                    return objBit.Value == this.Value;
            }
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Value);
        }

        public static bool operator ==(Bit left, Bit right)
        {
            if (((object)left) == null || ((object)right) == null)
                return Object.Equals(left, right);

            return left.Equals(right);
        }

        public static bool operator !=(Bit left, Bit right)
        {
            return !(left == right);
        }

        public override string ToString()
        {
            return Value ? "1" : "0";
        }
    }
}
