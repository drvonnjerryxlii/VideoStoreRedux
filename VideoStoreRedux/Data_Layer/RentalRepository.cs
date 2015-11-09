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
    public class RentalRepository : IRentalRepository
    {
        // database connection
        private IDbConnection db = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFileName=C:\Users\AdaRockstar\Documents\visual studio 2015\Projects\VideoStoreRedux\VideoStoreRedux\App_Data\VideoStoreDB-Development.mdf;Integrated Security=True");

        // Create
        #region RentalRepository.Create
        public Rental Create(Rental rental)
        {
            throw new NotImplementedException();
        }
        #endregion

        // Read
        #region RentalRepository.All
        public List<Rental> All()
        {
            return this.db.Query<Rental>("select * from rental").ToList();
        }
        #endregion

        #region RentalRepository.Find
        public Rental Find(int id)
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }
        #endregion
    }
}