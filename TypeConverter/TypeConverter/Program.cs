using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeConverter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SimpleOne simpleOne = new SimpleOne(10);
            SimpleTwo simpleTwo = new SimpleTwo("20");

            System.ComponentModel.TypeConverter converter = TypeDescriptor.GetConverter(simpleOne);
            bool canConvert = converter.CanConvertFrom(null, typeof(SimpleTwo));
            Console.WriteLine(canConvert);

            if(canConvert)
            {
                SimpleOne simpleOneFromSimpleTwo = converter.ConvertFrom(simpleTwo) as SimpleOne;


                if (simpleOneFromSimpleTwo != null)
                {
                    Console.WriteLine("Successfully converted SimpleTwo into SimpleOne");
                    Console.WriteLine(simpleOneFromSimpleTwo.TestProp.ToString());
                }
            }
        }
    }
}
