using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHTC.Model
{
    public class ReportTemplete
    {
        public int Id { get; set; }
        public int OwnerId { get; set; }
        public int Type { get; set; }
        public string Name { get; set; }
        public string Induction { get; set; }
        public byte[] Raw { get; set; }
    }
}
