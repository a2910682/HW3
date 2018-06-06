using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;


namespace ConsoleApplication1
{
    class Program
    {
        static ConsoleApplication1.Repository.IRepository _rep;
        static void Main(string[] args)
        {
            _rep = new ConsoleApplication1.Repository.lai();
            List<object> items = _rep.ReadJsonData();
            Console.WriteLine("資料標題:法務部編印「信託法令解釋及裁判要旨彙編」 \n" + "資料組筆為數 : " + items.Count + "\n");

            foreach (Models.OpenData item in items)
            {
                 Console.WriteLine("資料集名稱 :{0} 資料集連結:{1} \n", item.資料集名稱, item.資料集連結);
            }

            Console.ReadLine();
        }
    }
}
