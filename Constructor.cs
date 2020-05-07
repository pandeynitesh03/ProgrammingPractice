using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProgramming
{
    class Constructor
    {
        int a, b;
        public Constructor()   //default contructor  
        {
            a = 100;
            b = 175;
        }
        public static void Main()
        {
            Constructor obj = new Constructor(); //an object is created , constructor is called  
            Console.WriteLine(obj.a);
            Console.WriteLine(obj.b);
            Console.Read();
            Console.ReadLine();
        }
    }
}
