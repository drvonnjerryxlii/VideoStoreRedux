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
    public class CustomerRepository : ICustomerRepository
    {
        // database connection
        private IDbConnection db = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFileName=C:\Users\AdaRockstar\Documents\visual studio 2015\Projects\VideoStoreRedux\VideoStoreRedux\App_Data\VideoStoreDB-Development.mdf;Integrated Security=True");

        // Create
        #region CustomerRepository.Create
        public Customer Create(Customer customer)
        {
            throw new NotImplementedException();
        }
        #endregion

        // Read
        #region CustomerRepository.All
        public List<Customer> All()
        {
            return this.db.Query<Customer>("select * from customer").ToList();
        }
        #endregion

        #region CustomerRepository.Find
        public Customer Find(int id)
        {
            // package id for query
            var dbArgs = new DynamicParameters();
            dbArgs.Add("id", id);

            // query DB
            Customer customer = this.db.Query<Customer>(
              "select * from customer where id=@id", dbArgs
            ).First();

            // return customer (or return null if no customer)
            return customer ? customer : null;
        }
        #endregion

        // Update
        #region CustomerRepository.Save
        public void Save(Customer customer)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region CustomerRepository.Update
        public Customer Update(Customer customer)
        {
            throw new NotImplementedException();
        }
        #endregion

        // Delete
        #region CustomerRepository.Delete
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
