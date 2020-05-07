using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProgramming
{
    class FindIndexOfInt
    {
        public static int SearchIndex(int[] arr, int length, int item)
        {
            for (int i = 0; i < length; i++)
            {
                if (arr[i] == item)
                {
                    return i;
                }
            }
            return -1;
        }
        public static void Main()
        {
            int[] arr = new int[100];
            int no, sItem,i;

          no=Convert.ToInt32(Console.ReadLine());

            for(i=0;i< no; i++)
            arr[i]= Convert.ToInt32(Console.ReadLine());

            sItem = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine(SearchIndex(arr,no, sItem));
            Console.ReadLine();

        }
    }
}
