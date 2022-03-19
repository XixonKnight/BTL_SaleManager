using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleManager.Model
{
    internal class RepairLogBean
    {
        public string Id { get; set; }
        public string NameProduct { get; set; }
        public string Solution { get; set; }
        public string Repairer { get; set; }
        public DateTime FixDate { get; set; }
        public DateTime RepairDate { get; set; }
    }
}
