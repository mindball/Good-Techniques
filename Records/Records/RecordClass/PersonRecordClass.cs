using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Records.RecordClass
{
    public record class PersonRecordClass
    {
        public PersonRecordClass(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;   
        }

        public string FirstName { get; init; }

        public string LastName { get; init; }
    }
}
