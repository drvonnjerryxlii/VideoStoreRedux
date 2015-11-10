using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

// System.Nullable<T> variable

namespace VideoStoreRedux.Controllers
{
    public class RentalsController : ApiController
    {
        static readonly IRentalRepository repo = new RentalRepository();

        // - _POST "check out" one of the movie's inventory to the customer_
        // - _PATCH "check in" one of customer's rentals_

        // POST api/rentals
        public JsonResult Post([FromBody]string rentalParams)
        {
            Rental rental = repo.Create(rentalParams);

            if (rental == null)
            {
                return Json(new HttpResponseMessage());
            }
            else
            {
                return Json(new HttpResponseMessage(HttpStatusCode.Created));
            }
        }

        // PUT api/rentals/5
        public JsonResult Put(int id, [FromBody]string rentalParams)
        {
            Rental rental = repo.Find(id);

            if (rental == null)
            {
                return Json(new HttpResponseMessage(HttpStatusCode.NotFound));
            }
            else
            {
                rental.Return(DateTime.Today);
                return Json(rental);
            }
        }
    }
}
