using System;
using System.Collections.Generic;
using System.Text;
using DAC.Contract;
using GenWebAPI.Controllers;
using Models;
using Moq;
using Xbehave;
using Xunit;
using System.Linq;

namespace GenUnitTest
{
    public class StudentTest
    {
        private Mock<IStudentDAC> stddac;
        private StudentController stdController;

        [Background]
        public void Background()
        {
            var mock = new MockRepository(MockBehavior.Strict);
            stddac = mock.Create<IStudentDAC>();

            stdController = new StudentController();
            stdController.SetMockDac(stddac.Object);

            IEnumerable<Student> students = new List<Student>
            {
                new Student
                {
                    _id = "std01",
                    Name = "Gen",
                    CreateDate = DateTime.UtcNow
                },
                new Student
                {
                    _id = "std02",
                    Name = "P",
                    CreateDate = DateTime.UtcNow
                },
                new Student
                {
                    _id = "std03",
                    Name = "Jenny",
                    CreateDate = DateTime.UtcNow
                },
            };

            stddac.Setup(dac => dac.ListStudent()).Returns(students);
            stddac.Setup(dac => dac.GetStudent(It.IsAny<string>())).Returns<string>(id => students.FirstOrDefault(std => std._id == id));
        }

        [Scenario]
        public void TestListStudent()
        {   
            var result = stdController.ListStudent();
            Assert.Equal(3,result.Count());
        }

        [Scenario]
        [InlineData()]
        public void TestGetStudent(string id
            )
        {
            var result = stdController.ListStudent();
            Assert.Equal(3, result.Count());
        }
    }
}
