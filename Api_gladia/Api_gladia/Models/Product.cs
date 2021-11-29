using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api_gladia.Models
{
    public class Product
    {
        public int prod_id { get; set; }
        public string prod_name { get; set; }
        public string prod_desc { get; set; }
        public string prod_brand { get; set; }
        public string prod_price { get; set; }
        public int prod_quant { get; set; }
        public string prod_img { get; set; }
        public int prod_min_quant { get; set; }
        public int fk_category { get; set; }
    }
}
