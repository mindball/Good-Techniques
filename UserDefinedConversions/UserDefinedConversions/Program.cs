using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserDefinedConversions.MicrosoftExample;
using UserDefinedConversions.PluralsightExample;
using UserDefinedConversions.Thesharperdev;

namespace UserDefinedConversions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region PluralsightExample
            //int number = 3;
            //Conversions magic = number;
            //Console.WriteLine($"From int: {number} \nto: {magic},\nWith value: {magic.Number}");
            //int bNumber = (int)magic;
            //Console.WriteLine($"From: {magic},\nWith value: {magic.Number},\nto: {bNumber}");
            #endregion

            #region MicrosoftExample
            //MSClassB<int> mSClassB = new MSClassB<int>();
            //MSClassA<int> mSClassA = new MSClassA<int>();
            //int a = 10;
            //mSClassB = mSClassA;


            //Console.WriteLine($"From: {mSClassB.GetType().Name} {mSClassA.GetType().Name}");

            //Digit implicitVal = new Digit(8);
            //byte a = implicitVal;
            //Console.WriteLine(a);
            //Digit explicitVal = (Digit)10;
            //Console.WriteLine(explicitVal);
            #endregion

            #region thesharperdev
            string path = @"c:\Users";
            var pathOps = new PathOps();
            pathOps.PathExists(path);
            pathOps.PathExists(new FilePath(path));
            pathOps.PrintFolderContents(path);
            pathOps.PrintFolderContents(new FilePath(path));

            #endregion


            ;
        }
    }
}
