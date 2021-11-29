using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api_gladia.Models
{
    public class Order
    {
        public int order_id { get; set; }
        public DateTime order_date { get; set; }
        public string order_status{ get; set; }
        public string order_total { get; set; }
        public string order_payment { get; set; }
        public string order_shipping { get; set; }
        public int fk_id_user { get; set; }
    }
}
