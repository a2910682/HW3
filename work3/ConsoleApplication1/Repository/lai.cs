using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace ConsoleApplication1.Repository
{
    class lai : IRepository
    {
        public string DataName
        {
            get
            {
                return ConsoleApplication1.Shared.memberlai.GetDataName();
            }
        }

        public List<object> ReadJsonData()
        {
            StreamReader r = new StreamReader(DataName);
            string JsonFileData = r.ReadToEnd();
            List<ConsoleApplication1.Models.OpenData> JsonData;

            JsonData = JsonConvert.DeserializeObject<List<ConsoleApplication1.Models.OpenData>>(JsonFileData);
            return JsonData.OfType<Object>().ToList();

        }
    }
}
