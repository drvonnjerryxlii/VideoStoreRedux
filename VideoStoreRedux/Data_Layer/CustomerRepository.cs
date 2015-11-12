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
        private IDbConnection _db = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFileName=C:\Users\AdaRockstar\Documents\visual studio 2015\Projects\VideoStoreRedux\VideoStoreRedux\App_Data\VideoStoreDB-Development.mdf;Integrated Security=True");

        // dapper params reference:
        // http://stackoverflow.com/questions/9481678/how-to-create-arguments-for-a-dapper-query-dynamically

        private int getNextId()
        {
            int maxId = _db.Query<int?>("SELECT MAX(id) FROM Customer;").SingleOrDefault() ?? 0;
            return maxId + 1;
        }

        // Create
        #region CustomerRepository.Create
        public Customer Create(Customer customer)
        {
            int id = getNextId();

            var sqlQuery = string.Format("INSERT INTO Customer (id, name, registered_at, address, city, state, zip, phone, account_credit) VALUES({0}, @Name, @RegisteredAt, @Address, @City, @State, @Zip, @Phone, @AccountCredit);", id);

            _db.Query<Movie>(sqlQuery, customer);

            return customer;

        }
        #endregion

        // Read
        #region CustomerRepository.All
        public List<Customer> All()
        {
            return _db.Query<Customer>("select * from customer;").ToList();
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
            Customer customer = _db.Query<Customer>(
              "select * from customer where id=@id;", dbArgs
            ).SingleOrDefault();

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
            // package id for query
            var dbArgs = new DynamicParameters();
            dbArgs.Add("id", id);

            // query DB
            _db.Query<Customer>("delete * from Customer where id=@id;", dbArgs);
        }
        #endregion
    }
}
