using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovarianceAndContravariance.Contravariant
{
    public interface IContraVariant<in A>
    {
        object Val { get; set; }
    }

    interface IExtContravariant<in A> : IContraVariant<A> { }

    public class Sample<A> : IContraVariant<A> 
    { 
        public object Val { get; set; } 
    }
}
