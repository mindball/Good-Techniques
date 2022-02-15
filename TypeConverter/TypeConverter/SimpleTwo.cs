using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeConverter
{
	[Serializable]
    public class SimpleTwo
    {
		private string testProp;

		public SimpleTwo(string testProp)
		{
			this.testProp = testProp;
		}

		[Required]
		public string TestProp
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
