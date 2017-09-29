using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PHTC.UpdateLib;
namespace LocalConfigFileMaker
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length < 2)
                return;
            Config c = new Config(true, args[0]);
            c.Write(args[1]);
        }
    }
}
