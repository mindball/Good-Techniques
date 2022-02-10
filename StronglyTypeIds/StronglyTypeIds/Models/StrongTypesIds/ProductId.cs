using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StronglyTypeIds.Models.StrongTypesIds
{
    public struct ProductId : IEquatable<ProductId>
    {

        public ProductId(int value)
        {
            Value = value;
        }
        public int Value { get; }

        public bool Equals(ProductId other) => other.Value == Value;

        public override bool Equals(object obj) => obj is ProductId other && Equals(other);

        override public int GetHashCode() => Value.GetHashCode();

        override public string ToString() => $"ProductId {Value}";

        public static bool operator ==(ProductId a, ProductId b) => a.Equals(b);

        public static bool operator !=(ProductId a, ProductId b) => !a.Equals(b);

    }
}
