using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataTableSample.IService;
using DataTableSample.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DataTableSample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        IStudentService _studentService = null;

        public StudentsController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        // GET: api/Students
        [HttpGet]
        public IEnumerable<Student> GetStudents()
        {
            return _studentService.GetStudents();
        }

        // GET: api/Students/5
        [HttpGet("{id}", Name = "Get")]
        public Student Get(int id)
        {
            return _studentService.GetById(id);
        }

        // POST: api/Students
        [HttpPost]
        public void SaveOrUpdate([FromForm] Student student)
        {
            if (student.StudentId == 0) _studentService.Save(student);
            else _studentService.Update(student);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return _studentService.Delete(id);
        }
    }
}
