   using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using MongoDB.Bson.Serialization.Attributes;

namespace GenWebAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    public class StudentController : ControllerBase
    {
        private readonly IMongoClient _client;
        private readonly IMongoDatabase _database;
        private readonly IMongoCollection<Student> Collection;
        
        public StudentController()
        {
            _client = new MongoClient("mongodb://admin:lljick146@ds056559.mlab.com:56559/votemeifyoucan");
            _database = _client.GetDatabase("votemeifyoucan");
            Collection = _database.GetCollection<Student>("Student");
        }

        
        [HttpPost]
        public Student AddStudent([FromBody]Student request)
        {
            return request;
        }
        
        [HttpGet]
        public List<Student> GetStudent()
        {
            var result = Collection.Find(x => true).ToList();
            return result;
        }
        
    }

    public class Testpost
    {
        public string value1 { get; set; }
        public string value2 { get; set; }
    }
  
    public class Student
    {
      [BsonId]
      public string _id {get; set;}
      public string Name {get; set;}
      public DateTime CreateDate {get; set;}
    }

}
   
