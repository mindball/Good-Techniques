using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Records.Init
{
    public record PersonInit
    {
        public string FirstName { get; init; }
        public string LastName { get; init; }

         
    }
}
