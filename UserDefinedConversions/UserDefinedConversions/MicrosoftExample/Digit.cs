using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserDefinedConversions.MicrosoftExample
{
    public struct Digit
    {
        byte value;
        public Digit(byte value)
        {
            if (value < 0 || value > 9) throw new ArgumentException();
            this.value = value;
        }
        public static implicit operator byte(Digit d)
        {
            return d.value;
        }
        public static explicit operator Digit(byte b)
        {
            return new Digit(b);
        }
    }
}
