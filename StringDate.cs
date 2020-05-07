using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProgramming
{
    class StringDate
    {
        static void Main(string[] args)
        {
            string strDate = "10-11-2020";
            // DateTime.ParseExact(chartData.First().RecordDate, "MM-dd-yyyy", CultureInfo.InvariantCulture);
            // DateTime dateTime=dateTime.parse
            //                DateTime dateTime13 = DateTime.ParseExact(strDate, "MM-dd-yyyy", CultureInfo.InvariantCulture).AddDays(1);
            //            DateTime dateTime16 = DateTime.ParseExact(strDate, new string[] { "MM.dd.yyyy", "MM-dd-yyyy", "MM/dd/yyyy" }, CultureInfo.InvariantCulture, DateTimeStyles.None);


            //            Console.WriteLine("dateTime13: " + dateTime13.ToString("MM-dd-yyyy"));
            //            Console.WriteLine("dateTime16: " + dateTime16.ToString("MM-dd-yyyy"));
            string sampleText = @"F:\ToteVerification\EcoatData\Failed\EcoatTankTemplate_GM_Spring Hill_2019-12-12--16-34-34_Processing.xlsx";
            Console.WriteLine(sampleText);            
            sampleText=sampleText.Split('\\').LastOrDefault().Replace("_" + sampleText.Split('_').LastOrDefault(), "");
            Console.WriteLine(sampleText);
            Console.WriteLine(sampleText.Replace("_" + sampleText.Split('_').LastOrDefault(), "") + ".xlsx");
            Console.ReadLine();
        }
    }
}
