using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovarianceAndContravariance.Delegates
{
    public class CheckingAccountDelegate : IAccountDelegate
    {
        public CheckingAccountDelegate(string name)            
        {
            this.Name = name;
        }

        public string Name { get; }
    }
}
