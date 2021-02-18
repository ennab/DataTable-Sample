
using DataTableSample.Context;
using DataTableSample.IService;
using DataTableSample.Models;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataTableSample.Service
{
    public class StudentService : IStudentService
    {
        private readonly DatabaseContext _context;
        public StudentService(DatabaseContext context)
        {
            _context = context;
        }
        public string Delete(int studentId)
        {
            var student = _context.Students.FirstOrDefault(x => x.StudentId == studentId);
            if (student != null)
            {
                _context.Students.Remove(student);
                _context.SaveChanges();
            }
            return "Deleted";
        }

        public Student GetById(int studentId)
        {
            return _context.Students.SingleOrDefault(x => x.StudentId == studentId);
        }

        public List<Student> GetStudents()
        {
            //return _context.Students.ToList();
            return new List<Student>();
        }

        public void Save(Student oStudent)
        {
            _context.Students.Add(oStudent);
            _context.SaveChanges();
        }

        public void Update(Student oStudent)
        {
            _context.Students.Update(oStudent);
            _context.SaveChanges();
        }
    }
}
