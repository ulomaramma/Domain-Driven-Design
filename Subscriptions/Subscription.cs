﻿using Domain.Patients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Domain.Subscriptions
{
    public class Subscription
    {
       public int SubscriptionID { get; set; }
       public string SubscriptionName { get; set; }

        public string SubscriptionType { get; set; }

        public DateTime CreatedDate { get; set; }

        // Constructor and methods
        public Subscription(Guid id, string name, string species, DateTime dateOfBirth)
        {
            Id = id;
            Name = name;
            Species = species;
            DateOfBirth = dateOfBirth;
            MedicalRecords = new List<MedicalRecords>();
        }
    }
}
