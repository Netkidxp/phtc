using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHTC.Model
{
    public class ProjectTemplete
    {
        public int Id { get; set; }
        public string Class1 { get; set; }
        public string Class2 { get; set; }
        public string Class3 { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public byte[] Raw { get; set; }
    }
}
