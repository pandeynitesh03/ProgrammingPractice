using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace PracticeProgramming
{
    class FilterJson
    {
        public static void Main()
        {
            var json = File.ReadAllText(@"C:\Users\npandey\Desktop\mobius.json");
           // Console.WriteLine(json.Data.)
            foreach (var val in json)
            {
                Console.WriteLine(val);
            }
            var data = JsonConvert.DeserializeObject<DummyDTO>(json);

            Console.WriteLine(data);
            Console.ReadLine();
            //Console.WriteLine(weather.Name);
            //Console.WriteLine(weather.Sys.Country);
        }
    }

    public class DummyDTO
    {
        public string CtTypCd { get; set; } //"CtTypCd":"1C",
        public string CtTypDscrptn { get; set; } //"CtTypDscrptn":"CLEAR",
        public string ActvInd { get; set; } //"ActvInd":"Y",
        public string CtQty { get; set; } //"CtQty":1,
        public int InsrtUsrId { get; set; } //"InsrtUsrId":2395,

        public string InsrtDt { get; set; }
         //"InsrtDt":"2020-02-05T09:30:55Z",
        public int UpdtUsrId { get; set; }
         //"UpdtUsrId":null,
        public string UpdtDt { get; set; }
         //"UpdtDt":null,
        public string CacheKey { get; set; }
         //"CacheKey":null
    }
}
