   using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAC;
using DAC.Contract;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace GenWebAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    public class StudentController : ControllerBase
    {
        IStudentDAC stdDac;
        public StudentController()
        {
            stdDac = new StudentDAC();
        }

        public void SetMockDac(IStudentDAC stdDac)
        {
            this.stdDac = stdDac;
        }
        
        [HttpPost]
        public Student AddStudent([FromBody]Student request)
        {
            return request;
        }
        
        [HttpGet]
        public IEnumerable<Student> ListStudent()
        {
            var result = stdDac.ListStudent();
            return result;
        }
    }
}
   
