using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Mvc;
using VideoStoreRedux.Models;
using VideoStoreRedux.Data_Layer;

namespace VideoStoreRedux.Controllers
{
    // - GET Retrieve a list of all movies
    //     - ordered by customer id
    //     - ordered by customer name
    //     - ordered by check out date
    // - GET Given a movie's title...
    //     - Movie details
    //     - (_Get a list of customers that have currently checked out a copy of the film_)
    //     - (_Get a list of customers that have checked out a copy in the past_)

    public class MoviesController : ApiController
    {
        static readonly IMovieRepository repo = new MovieRepository();

        // GET api/movies
        public JsonResult Get()
        {
            List<Movie> movies = repo.All();

            if (movies.Count == 0)
            {
                return Json(new HttpResponseMessage(HttpStatusCode.NoContent));
            }
            else
            {
                return Json(movies);
            }
        }

        // GET api/movies/5
        public JsonResult Get(int id)
        {
            Movie movie = repo.Find(id);

            if (movie == null)
            {
                return Json(new HttpResponseMessage(HttpStatusCode.NotFound));
            }
            else
            {
                return Json(movie);
            }
        }
    }
}
