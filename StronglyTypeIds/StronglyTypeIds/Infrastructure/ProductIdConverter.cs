using StronglyTypeIds.Models.StrongTypesIds;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StronglyTypeIds.Infrastructure
{
    public class ProductIdConverter : TypeConverter
    {
        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
            => sourceType == typeof(string);

        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
            => destinationType == typeof(string);

        /// <summary>
        ///  In a real case value scenario we’d probably want to support conversion to and from int as well.)
        /// </summary>
        /// <param name="context"></param>
        /// <param name="culture"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
        {
            var str = typeof(string);
            switch(value)
            {
                case string s:
                    return new ProductId(int.Parse(s));                    
                default: throw new ArgumentException($"Cannot convert from {value} to ProductId", nameof(value));
            }           
            //.net 8
            //return value switch
            //{
            //    string s => new ProductId(int.Parse(s)),
            //    _ => throw new NotImplementedException()
            //}
        }

        /// <summary>
        ///  In a real case value scenario we’d probably want to support conversion to and from int as well.)
        /// </summary>
        /// <param name="context"></param>
        /// <param name="culture"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
        {
            if(destinationType == typeof(string))
            {
                switch (value)
                {
                    case ProductId id: return id.Value.ToString();
                    default:
                        throw new ArgumentException($"Cannot convert {value} to string", nameof(value));
                }
            }

            throw new ArgumentException($"Cannot convert {value ?? "(null)"} to {destinationType}", nameof(destinationType));
        }
    }
}
