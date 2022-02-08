using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovarianceAndContravariance.Covariant
{
    public interface ICovariant<out T> 
    {
        object Val { get; set; }
    }

    public interface IExtCovariant<out T> : ICovariant<T> { }

    public class Example<T> : ICovariant<T>
    {
        public object Val { get ; set; }
    }
}
