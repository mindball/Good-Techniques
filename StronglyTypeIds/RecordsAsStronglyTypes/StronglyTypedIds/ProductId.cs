using Newtonsoft.Json;
using RecordsAsStronglyTypes.Infrastructure.Converters.JsonConverters;
using RecordsAsStronglyTypes.Infrastructure.Helpers;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordsAsStronglyTypes.StronglyTypedIds
{
    [JsonConverter(typeof(StronglyTypedIdNewtonsoftJsonConverter))]
    public record ProductId(Guid Value) : StrongTypeIdEntityBase<Guid>(Value)
    {
    }
}
