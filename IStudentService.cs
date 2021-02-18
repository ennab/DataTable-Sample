using DataTableSample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataTableSample.IService
{
    public interface IStudentService
    {
        List<Student> GetStudents();
        Student GetById(int studentId);
        void Save(Student oStudent);
        void Update(Student oStudent);
        string Delete(int studentId);
    }
}
