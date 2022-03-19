using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleManager.Model
{
    internal class ProductBean
    {
        public string id { get; set; }
        public string idCategory { get; set; }
        public string nameProduct { get; set; }
        public string color { get; set; }
        public string size { get; set; }
        public double price { get; set; }
        public int quantity { get; set; }
        public string description { get; set; }
        public DateTime createdDate { get; set; }
    }
}
