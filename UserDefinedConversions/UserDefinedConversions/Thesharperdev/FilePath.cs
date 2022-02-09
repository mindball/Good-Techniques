using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserDefinedConversions.Thesharperdev
{
    public class FilePath
    {
        private string path;

        public FilePath(string path)
        {
            this.path = path;
        }

        public static implicit operator string(FilePath self)
        {
            return self?.path;   
        }

        public static implicit operator FilePath(string value)
        {
            return new FilePath(value);
        }

        public override string ToString()
        {
            return this.path;
        }
    }
}
