using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IZtrii
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StructWithoutConstructor a = new StructWithoutConstructor();
            //Not compile - readonly properties
            //a.FirstName = "asd";
            //a.Age = 1;

            StructWithConstructor b = new StructWithConstructor("Bai ivan", 78);
            //Not compile 
            //b.FirstName = "hadji Gench";

            //Compare structs
            var personOne = new StructWithConstructor("Bai ivan", 78);
            var personTwo = new StructWithConstructor("Bai ivan", 78);


            //Not compile
            //Console.WriteLine(personOne == personTwo);
            Console.WriteLine(personOne.Equals(personTwo));
            Console.WriteLine(personTwo.GetHashCode() == personOne.GetHashCode());

            
        }
    }
}
