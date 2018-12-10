using BankaIslemleri.Data;
using BankaIslemleri.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver.Linq;
using MongoDB.Driver;
using MongoDB.Bson;

namespace BankaIslemleri.Services
{
    public static class UserService
    {
        public static void CreateUser(User user)
        {
            if (user != null)
            {
                MongoContext context = new MongoContext();
                context.Users.InsertOne(user);
            }
        }

        public static User GetUserById(string userId)
        {
            if (userId != null)
            {
                MongoContext context = new MongoContext();
                var builder = Builders<User>.Filter;
                var filter = builder.Eq("_id", ObjectId.Parse(userId));
                var user = context.Users.Find<User>(filter).FirstOrDefault();
                return user;
            }
            else return null;
        }

        public static List<User> GetAllUsers()
        {

            MongoContext context = new MongoContext();
            var users = context.Users.Find<User>(new BsonDocument()).ToList();
            return users;
        }

        public static void InsertBankAccountToUser(BankAccount bankAccount, string userId)
        {
            if (bankAccount != null)
            {
                var user = GetUserById(userId);
                if (user != null)
                {
                    user.BankAccounts.Add(bankAccount);

                    MongoContext context = new MongoContext();
                    context.Users.ReplaceOne<User>(k => k.Id == userId, user);
                }
            }
        }

        public static void UpdateUser(User user)
        {
            MongoContext context = new MongoContext();
            context.Users.ReplaceOne<User>(k => k.Id == user.Id, user);
        }

    }
}
