using RecordsAsStronglyTypes.StronglyTypedIds;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordsAsStronglyTypes.Entities
{
    public class Product
    {
        public ProductId Id { get; set; }
        public string Name { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
