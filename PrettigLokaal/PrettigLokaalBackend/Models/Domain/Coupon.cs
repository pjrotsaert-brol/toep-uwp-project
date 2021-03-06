﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrettigLokaalBackend.Models.Domain
{
    public class Coupon
    {
        public int Id { get; set; }
        [JsonIgnore] public Account Account { get; set; }
        public Promotion Promotion { get; set; }
    }
}
