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
    public class RentalRepository //: IRentalRepository
    {
        // database connection
        private IDbConnection _db = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFileName=C:\Users\AdaRockstar\Documents\visual studio 2015\Projects\VideoStoreRedux\VideoStoreRedux\App_Data\VideoStoreDB-Development.mdf;Integrated Security=True");

        private int getNextId()
        {
            int maxId = _db.Query<int?>("SELECT MAX(id) FROM Rental;").SingleOrDefault() ?? 0;
            return maxId + 1;
        }

        // Create
        #region RentalRepository.Create
        public Rental Create(Rental rental)
        {
            int id = getNextId();

            var sqlQuery = string.Format("INSERT INTO Rental (id, movie_id, customer_id, returned, check_out_date) VALUES({0}, @MovieId, @CustomerId, @Returned, @CheckOutDate);", id);

            _db.Query<Movie>(sqlQuery, rental);

            return rental;
        }
        #endregion

        // Read
        #region RentalRepository.All
        public List<Rental> All()
        {
            return _db.Query<Rental>("select * from Rental;").ToList();
        }
        #endregion

        #region RentalRepository.Find
        public Rental Find(int id)
        {
            // package id for query
            var dbArgs = new DynamicParameters();
            dbArgs.Add("id", id);

            // query DB
            Rental rental = _db.Query<Rental>(
              "select * from Rental where id=@id;", dbArgs
            ).SingleOrDefault();

            return rental;
        }
        #endregion

        // Update
        #region RentalRepository.Save
        public void Save(Rental rental)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region RentalRepository.Update
        public Rental Update(Rental rental)
        {
            throw new NotImplementedException();
        }
        #endregion

        // Delete
        #region RentalRepository.Delete
        public void Delete(int id)
        {
            // package id for query
            var dbArgs = new DynamicParameters();
            dbArgs.Add("id", id);

            // query DB
            _db.Query<Rental>("delete * from Rental where id=@id;", dbArgs);
        }
        #endregion
    }
}
