﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Subscriptions
{
    public class SubscriptionStatus
    {
      public SubscriptionStatus() { }

        public SubscriptionStatus(string name) { }

        public int Id { get; set; }
        public string Name { get; set; }
    }
}
