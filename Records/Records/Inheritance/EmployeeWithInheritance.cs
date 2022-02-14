using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Records.Inheritance
{
    public record  EmployeeWithInheritance(string FirstName, int Age, string Job) : PersonWithInheritance(FirstName, Age)
    {
    }
}
