using BankaIslemleri.Data.Entities;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaIslemleri.Data
{
    public class MongoContext
    {
        public MongoContext()
        {
            var connectionString = "mongodb://kaygerya:123456Aa@ds047865.mlab.com:47865/egeuniv";
            _client = new MongoClient(connectionString);
            _database = _client.GetDatabase("egeuniv");
        }
        private IMongoClient _client;
        private IMongoDatabase _database;

        public IMongoCollection<User> Users
        {
            get { return _database.GetCollection<User>("users"); }
        }
    }
}
