using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api_gladia.Models
{
    public class Items_Order
    {
        public int fk_id_order { get; set; }
        public int fk_id_prod { get; set; }
        public int items_quant  { get; set; }
        public string items_subtotal { get; set; }
    }
}
