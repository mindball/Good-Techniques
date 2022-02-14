using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Records.Inheritance
{
    public record PersonWithInheritance
    {
        public PersonWithInheritance(string firstName, int age)
        {
            this.FirstName = firstName;
            this.Age = age;
        }

        public string FirstName { get; init; }

        public int Age { get; init; }
    }
}
