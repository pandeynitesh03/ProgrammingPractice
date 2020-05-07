using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PracticeProgramming
{
    class Program
    {
        static void Main(string[] args)           
        {
            string strTxt = ReadChar();
          // Console.WriteLine("Count is: " + strTxt.ToString());

            string[] srtarr = strTxt.Split(new[] { Environment.NewLine },StringSplitOptions.None);
            StringBuilder collection = new StringBuilder();
            foreach (string str in srtarr)
            {
                if (str.Contains("Name:"))
                {
                    int ix = str.IndexOf("Name:");

                    if (ix != -1)
                    {
                        string code = str.Substring(ix + 5);
                        collection.AppendLine( "\n" + code);
                        // do something here
                    }
                }
            }
            Console.ReadLine();
            Console.WriteLine(collection);
          //  File.WriteAllLines(@"C:\\Users\\npandey\\Desktop\\Temp.txt", collection.ToString());
            Console.ReadLine();
        }
        public static string ReadChar() {
            int count = 0;
            string txt = "";
            using (StreamReader reader = new StreamReader("C:\\Users\\npandey\\Desktop\\Password_Mail.txt"))
            {
                 txt = reader.ReadToEnd();
                count = txt.Length;

            }
            return txt;
        }
    }

    
}
