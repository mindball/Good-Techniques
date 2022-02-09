namespace UserDefinedConversions.PluralsightExample
{
    public class Conversions
    {
        public int Number { get; set; }
        public bool Magic { get; set; }

        public static implicit operator Conversions(int value)
        {
            return new Conversions() { Number = value, Magic = false };
        }

        public static explicit operator int(Conversions magic)
        {
            return magic.Number;
        }
    }
}
