﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrettigLokaalBackend.Models.Domain
{
    public class MerchantSubscription
    {
        public int Id { get; set; }
        public Account Account { get; set; }
        public Merchant Merchant { get; set; }
    }
}
