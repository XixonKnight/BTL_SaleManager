using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleManager.Model
{
    internal class ReceiptSlipBean
    {
        public string Id { get; set; }
        public string NameCustomer { get; set; }
        public string Address { get; set; }
        public string Recevier { get; set; }
        public DateTime RecevingTime { get; set; }
        public  DateTime PayTime { get; set; }

    }
}
