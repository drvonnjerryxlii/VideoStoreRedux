using System.Collections.Generic;
using VideoStoreRedux.Models;


namespace VideoStoreRedux.Interfaces
{
    public interface IRentalRepository
    {
        // Create
        Rental Create(Rental rental);

        // Read
        List<Rental> All();
        Rental Find(int id);

        // Update
        void Save(Rental rental);
        Rental Update(Rental rental);

        // Delete
        void Delete(int id);
    }
}
