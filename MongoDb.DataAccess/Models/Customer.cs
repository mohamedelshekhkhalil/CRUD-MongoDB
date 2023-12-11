using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoDb.DataAccess.Models
{
    [BsonIgnoreExtraElements]
    public class Customer
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement]
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Please enter a value bigger than 0")]
        public int CustomerID { get; set; }

        [BsonElement]
        [Required]
        public string Name { get; set; }

        [BsonElement]
        [Required]
        [Range(15, 100, ErrorMessage = "Age should be between 15 and 100 years")]
        public int Age { get; set; }

        [BsonElement]
        [Required]
        [Range(1000, 10000)]
        public int Salary { get; set; }
    }
}
