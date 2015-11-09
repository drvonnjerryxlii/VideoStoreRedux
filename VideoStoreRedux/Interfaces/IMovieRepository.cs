using System.Collections.Generic;

namespace VideoStoreRedux.Interfaces
{
    public interface IMovieRepository
    {
        // Create
        Movie Create(Movie movie);

        // Read
        List<Movie> All();
        Movie Find(int id);

        // Update
        void Save(Movie movie);
        Movie Update(Movie movie);

        // Delete
        void Delete(int id);
    }
}
