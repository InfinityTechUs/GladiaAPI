﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api_gladia.Models
{
    public class User
    {
        public int user_id { get; set; }
        public string user_cpf { get; set; }
        public string user_phone { get; set; }
        public string user_name { get; set; }
        public string user_email { get; set; }
        public string user_password { get; set; }
        public string user_img { get; set; }
        public string user_lvl { get; set; }
        public int fk_address_id { get; set; }
    }
}
