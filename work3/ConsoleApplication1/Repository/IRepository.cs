using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ConsoleApplication1.Repository
{
    public interface IRepository
    {
        string DataName { get; }
        List<object> ReadJsonData();
    }
}
