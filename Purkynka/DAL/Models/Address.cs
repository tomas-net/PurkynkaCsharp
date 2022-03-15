﻿namespace Purkynka.DAL.Models
{
    public class Address
    {
        public int AddressId { get; set; }

        public string Street { get; set; }

        public string City { get; set; }

        public string PostalCode { get; set; }

        public string Country { get; set; }

        public virtual User User { get; set; }
    }
}