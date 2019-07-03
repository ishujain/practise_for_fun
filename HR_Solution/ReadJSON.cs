using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Solution
{
    class ReadJSON
    {
        static void Main()
        {

            string json = "";
            string txt = "";
            using (StreamReader streamReader = new StreamReader("C:\\Users\\ijain\\Downloads\\tenantInfo.json"))
            {
                 json = streamReader.ReadToEnd();

            }
            //using (StreamReader streamReader = new StreamReader("C:\\Users\\ijain\\Downloads\\qwert.txt"))
            //{
            //    txt = streamReader.ReadToEnd();

            //}

            dynamic array = JsonConvert.DeserializeObject(json);
            
            foreach (var item in array)
            {
                Console.WriteLine("{0}", item.TenantKey);
            }
        }
    }
}
