using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace VideoStoreRedux.Controllers
{
    // - GET Retrieve a list of all customers
    // - GET Given a customer's id...
    //     - Customer info + List the movies they currently have checked out
    //     - (_List the movies a customer has checked out in the past_)
    //     - (_ordered by check out date_)
    //     - (_includes return date_)
    // - (_DELETE a customer_)

    public class CustomersController : ApiController
    {
        static readonly ICustomerRepository repo = new CustomerRepository();

        // GET api/customers
        public JsonResult Get()
        {
            List<Customer> customers = repo.All();

            if (customers.Count == 0)
            {
                return Json(new HttpResponseMessage(HttpStatusCode.NoContent));
            }
            else
            {
                return Json(customers);
            }
        }

        // GET api/customers/5
        public JsonResult Get(int id)
        {
            Customer customer = repo.Find(id);

            if (customer == null)
            {
                return Json(new HttpResponseMessage(HttpStatusCode.NotFound));
            }
            else
            {
                return Json(customer);
            }
        }

        // // DELETE api/customers/5
        // public void Delete(int id)
        // {
        //    Customer customer = repo.Find(id);
        //    if (customer == null)
        //    {
        //      return Json(new HttpResponseException(HttpStatusCode.NotFound));
        //    }
        //    else
        //    {
        //      return customer.Delete();
        //    }
        // }
    }
}
