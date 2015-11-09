using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VideoStoreRedux.Models
{
    public class Rental
    {
        public int Id { get; set; }
        public int MovieId { get; set; }
        public int CustomerId { get; set; }
        public bool Returned { get; set; }
        public DateTime CheckOutDate { get; set; }
        public DateTime ReturnDate { get; set; }
    }
}