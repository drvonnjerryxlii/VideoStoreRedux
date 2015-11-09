using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VideoStoreRedux.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime RegisteredAt { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Phone { get; set; }
        public double AccountCredit { get; set; }
        public double AccountBalance { get; set; }
    }
}