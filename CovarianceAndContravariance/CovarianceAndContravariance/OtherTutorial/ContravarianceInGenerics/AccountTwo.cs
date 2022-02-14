using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovarianceAndContravariance.OtherTutorial.ContravarianceInGenerics
{
    public abstract class AccountTwo
    {
        public AccountTwo(string name, string ssn)
        {
            this.Name = name;
            this.SSN = ssn;
        }

        public string Name { get; set; }

        public string SSN { get; set; }
    }
}
