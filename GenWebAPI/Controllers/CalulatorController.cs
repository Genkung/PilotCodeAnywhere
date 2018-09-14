using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using MongoDB.Bson.Serialization.Attributes;
using Models;

namespace GenWebAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    public class CalculatorController : ControllerBase
    {
        private readonly IMongoClient _client;
        private readonly IMongoDatabase _database;
        private readonly IMongoCollection<Student> Collection;
        
        public CalculatorController()
        {
            _client = new MongoClient("mongodb://admin:lljick146@ds056559.mlab.com:56559/votemeifyoucan");
            _database = _client.GetDatabase("votemeifyoucan");
            Collection = _database.GetCollection<Student>("Student");
        }
        
        [HttpGet("{valueFirst}/{valueSecond}")]
        public double Plus(double valueFirst, double valueSecond)
        {
            var result = valueFirst + valueSecond;
            return result;
        }
    }
}