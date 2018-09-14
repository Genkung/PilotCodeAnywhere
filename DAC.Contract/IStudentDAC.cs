using Models;
using System;
using System.Collections.Generic;

namespace DAC.Contract
{
    public interface IStudentDAC
    {
        Student GetStudent(string studentid);
        IEnumerable<Student> ListStudent();
        void AddStudent(Student student);
        void DeleteStudent(string studentid);
    }
}
