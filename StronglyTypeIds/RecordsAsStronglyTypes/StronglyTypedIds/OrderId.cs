using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordsAsStronglyTypes.StronglyTypedIds
{
    public record OrderId(Guid Value) : StrongTypeIdEntityBase<Guid>(Value)
    {
    }
}
