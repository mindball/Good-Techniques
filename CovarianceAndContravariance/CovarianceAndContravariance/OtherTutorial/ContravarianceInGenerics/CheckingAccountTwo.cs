using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovarianceAndContravariance.OtherTutorial.ContravarianceInGenerics
{
    internal class CheckingAccountTwo : AccountTwo
    {
        public CheckingAccountTwo(string name, string ssn)
            :base(name, ssn)
        {
        }
    }
}
