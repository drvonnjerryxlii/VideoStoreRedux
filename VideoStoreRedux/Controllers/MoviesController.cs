using System.Collections.Generic;
using System.Web.Http;
using VideoStoreRedux.Models;
using VideoStoreRedux.Data_Layer;

namespace VideoStoreRedux.Controllers
{
    public class MoviesController : ApiController
    {
        static readonly MovieRepository repo = new MovieRepository();
        // GET: Movies
        public List<Movie> Get()
        {
            List<Movie> movies = repo.All();
            return movies;
        }

        public Movie Get(int id)
        {
            Movie movie = repo.Find(id);
            return movie;
        }
    }
}
