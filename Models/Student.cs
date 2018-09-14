using System;
using MongoDB.Bson.Serialization.Attributes;

namespace Models
{
    public class Student
    {
        [BsonId]
        public string _id { get; set; }
        public string Name { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
