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
        // database connection
        private IDbConnection db = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFileName=C:\Users\AdaRockstar\Documents\visual studio 2015\Projects\VideoStoreRedux\VideoStoreRedux\App_Data\VideoStoreDB-Development.mdf;Integrated Security=True");

        // Create
        #region MovieRepository.Create
        public Movie Create(Movie movie)
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
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