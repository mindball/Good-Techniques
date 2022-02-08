using ImplicitАndExplicitOperatorsOverClassessOrStructs.ExampleOne;
using ImplicitАndExplicitOperatorsOverClassessOrStructs.ExampleTwo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplicitАndExplicitOperatorsOverClassessOrStructs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Example one
            MessageTableEntity tableEntity = new MessageTableEntity
            {
                Id = Guid.NewGuid(),
                Message = "Test message",
                CreatedBy = "User_ABC"
            };

            //implicit
            //MessageDto dto = tableEntity;

            //explicit
            MessageDto dto = (MessageDto)tableEntity;

            //Example two

            var d = new Digit(7);
            byte number = d;
            Console.WriteLine(number);

            Digit digit = (Digit)number;
            Console.WriteLine(digit);
            ;
        }
    }
}
