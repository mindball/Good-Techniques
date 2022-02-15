﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StronglyTypeIds.Models.StrongTypesIds
{
    [JsonConverter(typeof(OrderIdJsonConverter))]
    //[TypeConverter(typeof(OrderIdTypeConverter))]
    public readonly struct OrderId : IComparable<OrderId>, IEquatable<OrderId>
    {
        public Guid Value { get; }

        public OrderId(Guid value)
        {
            Value = value;
        }

        public static OrderId New() => new OrderId(Guid.NewGuid());

        public static OrderId Empty { get; } = new OrderId(Guid.Empty);

        public bool Equals(OrderId other) => this.Value.Equals(other.Value);

        public int CompareTo(OrderId other) => Value.CompareTo(other.Value);

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            return obj is OrderId other && Equals(other);
        }

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString();
        public static bool operator ==(OrderId a, OrderId b) => a.CompareTo(b) == 0;
        public static bool operator !=(OrderId a, OrderId b) => !(a == b);

        class OrderIdJsonConverter : JsonConverter
        {
            public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
            {
                var id = (OrderId)value;
                serializer.Serialize(writer, id.Value);
            }

            public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
            {
                var guid = serializer.Deserialize<Guid>(reader);
                return new OrderId(guid);
            }

            public override bool CanConvert(Type objectType)
            {
                return objectType == typeof(OrderId);
            }
        }

        //public class OrderIdTypeConverter : TypeConverter
        //{

        //    public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
        //    {
        //        return sourceType == typeof(string) || base.CanConvertFrom(context, sourceType);
        //    }

        //    public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
        //    {
        //        var stringValue = value as string;
        //        if (!string.IsNullOrEmpty(stringValue)
        //         && Guid.TryParse(stringValue, out var guid))
        //        {
        //            return new OrderId(guid);
        //        }

        //        return base.ConvertFrom(context, culture, value);
        //    }
        //}
    }
}
