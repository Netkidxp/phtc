using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHTC.RegSet
{
    class Program
    {
        static void Main(string[] args)
        {
            SetConnectionString();
        }
        static void SetConnectionString()
        {
            string cs = @"Data Source=192.168.2.88;Initial Catalog=phtc;User ID=PHTC;Password=punai123+";
            GlobalTool.SetConnectionString(cs);
        }
    }
}
