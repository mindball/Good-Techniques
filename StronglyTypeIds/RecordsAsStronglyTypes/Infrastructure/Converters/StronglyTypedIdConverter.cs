using RecordsAsStronglyTypes.Infrastructure.Helpers;
using RecordsAsStronglyTypes.StronglyTypedIds;
using System.ComponentModel;
using System.Globalization;

namespace RecordsAsStronglyTypes.Infrastructure.Converters
{
    public class StronglyTypedIdConverter<TValue> : TypeConverter
        where TValue : notnull
    {
        private static readonly TypeConverter IdValueConverter = GetIdValueConverter();
        private readonly Type _type;
        public StronglyTypedIdConverter(Type type)
        {
            _type = type;            
        }

        private static TypeConverter GetIdValueConverter()
        {
            var converter = TypeDescriptor.GetConverter(typeof(TValue));
            if (!converter.CanConvertFrom(typeof(string)))
                throw new InvalidOperationException(
                    $"Type '{typeof(TValue)}' doesn't have a converter that can convert from string");

            return converter;
        }

        public override bool CanConvertFrom(ITypeDescriptorContext? context, Type sourceType)
        {
            var isString = sourceType == typeof(string);
            var isTValue = sourceType == typeof(TValue);
            var baseResult = base.CanConvertFrom(context, sourceType);

            return isString || isTValue || baseResult;
        }


        //TODO destinationType in base class is not nullable
        public override bool CanConvertTo(ITypeDescriptorContext? context, Type? destinationType)
        {
            var isString = destinationType == typeof(string);
            var isTValue = destinationType == typeof(TValue);
            var baseResult = base.CanConvertTo(context, destinationType);

            return isString || isTValue || baseResult;
        }

        public override object? ConvertFrom(ITypeDescriptorContext? context, CultureInfo? culture, object value)
        {
            //TODO check value for null
            if(value is string s)
            {
                value = IdValueConverter.ConvertFrom(s);
            }

            if(value is TValue idValue)
            {
                var factory = StronglyTypedIdHelper.GetFactory<TValue>(_type);
                return factory(idValue);
            }

            return base.ConvertFrom(context, culture, value);
        }

        public override object? ConvertTo(ITypeDescriptorContext? context, CultureInfo? culture, object? value, Type destinationType)
        {
            if(value is null)
                throw new ArgumentNullException(nameof(value));

            var stronglyTypeId = (StrongTypeIdEntityBase<TValue>)value;
            TValue idValue = stronglyTypeId.Value;

            if (destinationType == typeof(string))
                return idValue.ToString();

            if (destinationType == typeof(TValue))
                return idValue;

            return base.ConvertTo(context, culture, value, destinationType);
        }
    }
}
