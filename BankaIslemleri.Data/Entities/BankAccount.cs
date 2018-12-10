using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaIslemleri.Data.Entities
{
    public class BankAccount
    {
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        //public string UserId { get; set; }
        public string AccountNumber { get; set; }
        public int Amount { get; set; }
    }
}
