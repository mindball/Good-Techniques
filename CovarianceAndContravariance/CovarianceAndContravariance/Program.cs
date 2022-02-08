using CovarianceAndContravariance.Contravariant;
using CovarianceAndContravariance.Covariant;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovarianceAndContravariance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IContraVariant<Object> iobj = new Sample<Object>();
            IContraVariant<String> istr = new Sample<String>();
            istr = iobj;
            iobj.Val = 1;
            Console.WriteLine($"{iobj.Val} {(iobj.Val.GetType().Name)}");
            istr.Val = 2.2;
            Console.WriteLine($"{istr.Val} {(istr.Val.GetType().Name)}");



            ICovariant<Object> obj = new Example<Object>();
            ICovariant<String> str = new Example<String>();

            obj = str;
            obj.Val = 2;
            Console.WriteLine($"{obj.Val} {(obj.Val.GetType().Name)}");
            str.Val = 3;
            Console.WriteLine($"{str.Val} {(str.Val.GetType().Name)}");  
            ;
        }
    }
}
