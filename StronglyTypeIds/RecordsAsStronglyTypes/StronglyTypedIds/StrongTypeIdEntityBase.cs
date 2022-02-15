using RecordsAsStronglyTypes.Infrastructure.Converters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordsAsStronglyTypes.StronglyTypedIds
{
    [TypeConverter(typeof(IntermediateConverter))]
    public abstract record StrongTypeIdEntityBase<TValue>(TValue Value)
        where TValue : notnull
    {
        public override string ToString()
            => Value.ToString();
    }
}
