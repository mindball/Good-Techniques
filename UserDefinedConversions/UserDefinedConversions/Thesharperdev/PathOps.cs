using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserDefinedConversions.Thesharperdev
{
    public class PathOps
    {
        public void PrintFolderContents(string path)
        {
            Console.WriteLine($"Print contents of {path}");
        }
        public void PathExists(FilePath path)
        {
            Console.WriteLine($"object:{path.GetType().Name} {path} exists");
        }
    }
}
