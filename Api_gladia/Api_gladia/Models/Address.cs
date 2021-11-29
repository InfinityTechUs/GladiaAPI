using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api_gladia.Models
{
    public class Address
    {
        public int address_id { get; set; }
        public string address_cep { get; set; }
        public string address_uf { get; set; }
        public string address_city { get; set; }
        public string address_district { get; set; }
        public string address_public_place { get; set; }
        public string address_complement { get; set; }
        public int fk_user_id { get; set; }

    }
}
