using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProgramming
{
    class SubStringExample
    {
        public static void Main()
        {
            string path = "FWA E-Coat Tank Management UpLoad V1.5 (2)_123.xlsx";

            string newString=path.Substring(0, ((path.LastIndexOf('_'))));
            Console.WriteLine(newString);
            Console.ReadLine();
        }
    }
}
