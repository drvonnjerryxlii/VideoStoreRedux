using System.Collections.Generic;
using System.Web.Http;
using VideoStoreRedux.Models;
using VideoStoreRedux.Data_Layer;


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
        static readonly CustomerRepository repo = new CustomerRepository();

        // GET api/customers
        public List<Customer> Get()
        {
            List<Customer> customers = repo.All();
            return customers;
        }

        // GET api/customers/5
        public Customer Get(int id)
        {
            Customer customer = repo.Find(id);
            return customer;
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
