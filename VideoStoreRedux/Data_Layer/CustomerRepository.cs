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
    public class CustomerRepository// : ICustomerRepository
    {
        // database connection
        private IDbConnection db = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFileName=C:\Users\AdaRockstar\Documents\visual studio 2015\Projects\VideoStoreRedux\VideoStoreRedux\App_Data\VideoStoreDB-Development.mdf;Integrated Security=True");

        // dapper params reference:
        // http://stackoverflow.com/questions/9481678/how-to-create-arguments-for-a-dapper-query-dynamically

        // Create
        #region CustomerRepository.Create
        public Customer Create(Customer customer)
        {
            //string[] allowedParams = { "name", "registered_at", "address", "city", "state", "zip", "phone", "account_credit", "account_balance" };
            //return this.db.Query<Customer>("insert into customer ", dbArgs);
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

        //public static IEnumerable<T> Query<T>(this IDbConnection cnn, string sql, object param = null, SqlTransaction transaction = null, bool buffered = true)
        //connection.Query<Dog>("select Age = @Age, Id = @Id", new { Age = (int?)null, Id = guid });
        #region CustomerRepository.Find
        public Customer Find(int id)
        {
            // package id for query
            var dbArgs = new DynamicParameters();
            dbArgs.Add("id", id);

            // query DB
            Customer customer = this.db.Query<Customer>(
              "select * from customer where id=@id", dbArgs
            ).SingleOrDefault();

            // return customer (or return null if no customer)
            return customer;
        }
        #endregion

        // Update
        #region CustomerRepository.Save
        public void Save(Customer customer)
        {
            //throw new NotImplementedException();
        }
        #endregion

        #region CustomerRepository.Update
        public Customer Update(Customer customer)
        {
            //var dbArgs = new DynamicParameters();
            //foreach (var pair in args) dbArgs.Add(pair.Key, pair.Value);
            //throw new NotImplementedException();
            return customer;
        }
        #endregion

        // Delete
        #region CustomerRepository.Delete
        public void Delete(int id)
        {
            //throw new NotImplementedException();
        }
        #endregion
    }
}
