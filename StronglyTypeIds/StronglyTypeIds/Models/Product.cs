using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StronglyTypeIds;
using StronglyTypeIds.Infrastructure;
using StronglyTypeIds.Models.StrongTypesIds;

namespace StronglyTypeIds.Models
{
    [TypeConverter(typeof(ProductIdConverter))]
    public record ProductId(int value);

    public class Product
    {       


        public ProductId Id { get; set; }
        public string Name { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
