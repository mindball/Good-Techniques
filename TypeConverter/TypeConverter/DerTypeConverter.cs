using System;
using System.ComponentModel;
using System.Globalization;

namespace TypeConverter
{
    public class DerTypeConverter : System.ComponentModel.TypeConverter
    {
        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
        {
            if (sourceType == typeof(SimpleTwo))
                return true;


            return base.CanConvertFrom(context, sourceType);
        }

        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
        {
            SimpleTwo simpleTwo = value as SimpleTwo;
            if(simpleTwo == null)
                return base.ConvertFrom(context, culture, value);

            int n = int.Parse(simpleTwo.TestProp);
            SimpleOne simpleOne = new SimpleOne(n);
            return simpleOne;
        }
    }
}
