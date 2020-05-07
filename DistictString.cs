using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProgramming
{
    class DistictString
    {
        static void Main()
        {
            // string mystring = "5,6,4,8,5,6,2,5,4,5,4,5,5,8,9,1,10";
            string mystring = "Ecoat Shift Data,Ecoat Shift Data,Ecoat Daily Data,Ecoat MCL Data,Ecoat Defect Data";// "Josaf,Mani,Josaf,Aaryav";  
            List<string> uniqueValues = mystring.Split(',').Distinct().ToList();
            string UniqueString = string.Join(", ", uniqueValues);
            Console.WriteLine(UniqueString);
            Console.ReadLine();
        }
    }
}
