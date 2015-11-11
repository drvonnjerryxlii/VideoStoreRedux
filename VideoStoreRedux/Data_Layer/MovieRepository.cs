using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using VideoStoreRedux.Interfaces;
using VideoStoreRedux.Models;
using Dapper;

namespace VideoStoreRedux.Data_Layer
{
    public class MovieRepository : IMovieRepository
    {
        // models are just an object class w/ no methods
        // only properties

        // repositories connect to DB
        // id assignment should be in the repo

        // factories
        // if you need an id the moment you create a movie
        // order the posters, etc
        // this is called the FACTORY PATTERN

        // database connection
        private IDbConnection db = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFileName=C:\Users\AdaRockstar\Documents\visual studio 2015\Projects\VideoStoreRedux\VideoStoreRedux\App_Data\VideoStoreDB-Development.mdf;Integrated Security=True");

        private static int getNextId()
        {
            int maxId = db.Query<int>("SELECT MAX(id) FROM Movie;").SingleOrDefault() ?? 0;
            return maxId + 1;
        }

        // Create
        #region MovieRepository.Create
        public Movie Create(Movie movie)
        {
            int id = Movie.getNextId();

            var sqlQuery = string.Format("INSERT INTO Movie (id, title, overview, release_year, inventory) VALUES({0}, @Title, @Overview, @ReleaseYear, @Inventory);", id);

            db.Query<Movie>(sqlQuery, movie);

            return movie;
        }
        #endregion

        // Read
        #region MovieRepository.All
        public List<Movie> All()
        {
            return this.db.Query<Movie>("select * from movie").ToList();
        }
        #endregion

        #region MovieRepository.Find
        public Movie Find(int id)
        {
            // package id for query
            var dbArgs = new DynamicParameters();
            dbArgs.Add("id", id);

            // query DB
            Movie movie = this.db.Query<Movie>("select * from movie where id=@id", dbArgs).SingleOrDefault();

            return movie;
        }
        #endregion

        // Update
        #region MovieRepository.Save
        public void Save(Movie movie)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region MovieRepository.Update
        public Movie Update(Movie movie)
        {
            throw new NotImplementedException();
        }
        #endregion

        // Delete
        #region MovieRepository.Delete
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
