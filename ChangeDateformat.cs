using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProgramming
{
    class ChangeDateformat
    {
        public static string EncryptPasswordWithSHA512(string plainPassword)
        {
            SHA512 sha512 = new SHA512CryptoServiceProvider();

            //provide the string in byte format to the ComputeHash method. 
            //This method returns the SHA-512 hash code in byte array
            byte[] arrHash = sha512.ComputeHash(Encoding.UTF8.GetBytes(plainPassword));

            // use a Stringbuilder to append the bytes from the array to create a SHA-512 hash code string.
            StringBuilder sbHash = new StringBuilder();

            // Loop through byte array of the hashed code and format each byte as a hexadecimal code.
            for (int i = 0; i < arrHash.Length; i++)
            {
                sbHash.Append(arrHash[i].ToString("x2"));
            }

            // Return the hexadecimal SHA-512 hash code string.
            return sbHash.ToString();
        }
        static string changeDateFormat(string date)
        {
            string newDate = "";
            string[] RecordDate = date.Split('-');
            newDate = RecordDate[2] + "-" + RecordDate[1] + "-" + RecordDate[0];

            return newDate;
        }
        static void Main() {

            string mydate = EncryptPasswordWithSHA512("Axalta@123");
           // string mydate = decr("Axalta@123");
            string matchCase = "";
            if ("5c57ba656b4ed96993a9617725d9235138ed0aebe43f0b2e87e1b339538fe161760b37baf374db41f12c251dc659af65ac6d60d7fe73fb759573dd3f71420dc5" == mydate)
                matchCase = "Password Matched";
            else
                matchCase = "Password not Matched";
            Console.WriteLine(matchCase);
            Console.ReadLine();
        }
    }
}
