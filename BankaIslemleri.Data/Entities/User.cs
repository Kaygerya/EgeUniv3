using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaIslemleri.Data.Entities
{
    public class User
    {
        public User()
        {
            BankAccounts = new List<BankAccount>();
        }

        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public string FullName { get; set; }
        public string Tel { get; set; }

        public List<BankAccount> BankAccounts { get; set; }

    }
}
