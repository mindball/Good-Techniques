using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserDefinedConversions.MicrosoftExample
{
    public class MSClassA<T> 
    {       
    }

    public class MSClassB<T> : MSClassA<T> 
    {        
        public static implicit operator MSClassA<int>(MSClassB<T> value)
        {           
            return value; 
        }
    }
}
