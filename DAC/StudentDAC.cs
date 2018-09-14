using DAC.Contract;
using Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;

namespace DAC
{
    public class StudentDAC : IStudentDAC
    {
        private readonly IMongoClient _client;
        private readonly IMongoDatabase _database;
        private readonly IMongoCollection<Student> Collection;

        public StudentDAC()
        {
            _client = new MongoClient("mongodb://admin:lljick146@ds056559.mlab.com:56559/votemeifyoucan");
            _database = _client.GetDatabase("votemeifyoucan");
            Collection = _database.GetCollection<Student>("Student");
        }

        public Student GetStudent(string studentid)
        {
            var result = Collection.Find(std => std._id == studentid).FirstOrDefault();
            return result;
        }

        public void AddStudent(Student student)
        {
            Collection.InsertOne(student);
        }

        public IEnumerable<Student> ListStudent()
        {
            var result = Collection.Find(std => true).ToList();
            return result;
        }

        public void DeleteStudent(string studentid)
        {
            Collection.DeleteOne(std => std._id == studentid);
        }
    }
}
