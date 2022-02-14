using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IZtrii
{
    public struct StructWithConstructor
    {
        public StructWithConstructor(string firstName, int age)
        {
            this.FirstName = firstName;
            this.Age = age; 
        }

        public string FirstName { get; }

        public int Age { get; }
    }
}
