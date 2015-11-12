using System.Collections.Generic;
using System.Web.Http;
using VideoStoreRedux.Models;
using VideoStoreRedux.Data_Layer;

// System.Nullable<T> variable

namespace VideoStoreRedux.Controllers
{
    public class RentalsController : ApiController
    {
        static readonly RentalRepository repo = new RentalRepository();

        // - _POST "check out" one of the movie's inventory to the customer_
        // - _PATCH "check in" one of customer's rentals_

        // POST api/rentals
        //public Rental Post([FromBody]string rentalParams)
        //{
        //    Rental rental = repo.Create(rentalParams);
        //    return rental;
        //}

        //// PUT api/rentals/5
        //public Rental Put(int id, [FromBody]string rentalParams)
        //{
        //    Rental rental = repo.Find(id);
        //    rental.Return(DateTime.Today);
        //}
    }
}
