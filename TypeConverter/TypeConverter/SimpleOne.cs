using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeConverter
{
	[TypeConverter(typeof(DerTypeConverter))]
    public class SimpleOne
    {
		private int testProp;

		public SimpleOne(int testProp)
		{
			this.testProp = testProp;
		}

		public int TestProp
		{
			get
			{
				return this.testProp;
			}
			set
			{
				this.testProp = value;
			}
		}
	}
}
