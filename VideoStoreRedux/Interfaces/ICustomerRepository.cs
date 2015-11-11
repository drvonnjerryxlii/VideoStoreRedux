using System.Collections.Generic;
using VideoStoreRedux.Models;


namespace VideoStoreRedux.Interfaces
{
    public interface ICustomerRepository
    {
        // Create
        Customer Create(Customer customer);

        // Read
        List<Customer> All();
        Customer Find(int id);

        // Update
        void Save(Customer customer);
        Customer Update(Customer customer);

        // Delete
        void Delete(int id);
    }
}
