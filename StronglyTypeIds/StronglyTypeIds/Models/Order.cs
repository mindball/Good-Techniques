using StronglyTypeIds.Models.StrongTypesIds;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StronglyTypeIds.Models
{
    public class Order
    {
        public OrderId OrderId { get; set; }

        public decimal Total { get; set; }

        public bool RequareInvoice { get; set; }
    }
}
