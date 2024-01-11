using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentAPI.Model;
using StudentAPI.Repositories;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace StudentAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudent studentRepository;
        public StudentController(IStudent studentRepository)
        {
            this.studentRepository = studentRepository;
        }

        [HttpGet, Route("GetAll")]

        public IActionResult GetAll()
        {
            try
            {
                return Ok(studentRepository.GetAll());
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpGet, Route("GetStudent/{id}")]

        public IActionResult GetStudent(int id)
        {
            try
            {
                return Ok(studentRepository.GetStudent(id));
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpGet, Route("GetStudentsByStd/{std}")]

        public IActionResult GetStudentsByStd(string std)
        {
            try
            {
                return Ok(studentRepository.GetAllStudents(std));
            }
            catch (Exception)
            {

                throw;
            }
        }


        [HttpGet, Route("GetStudents/{std}/{section}")]

        public IActionResult GetAllStudents(string std, string section)
        {
            try
            {
                return Ok(studentRepository.GetAllStudents(std, section));
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpPost, Route("AddStudent")]

        public IActionResult AddStudent(Student student)
        {
            try
            {
                studentRepository.AddStudent(student);
                return Ok(student);
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpPut, Route("UpdateStudent")]

        public IActionResult UpdateStudent(Student student)
        {
            try
            {
                studentRepository.UpdateStudent(student);
                return Ok(student);
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpDelete, Route("DeleteStudent")]

        public IActionResult DeleteStudent(int id)
        {
            try
            {
                studentRepository.DeleteStudent(id);
                return Ok("Student Deleted");
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}

            
        
    


