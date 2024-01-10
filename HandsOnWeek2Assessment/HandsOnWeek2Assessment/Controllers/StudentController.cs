using HandsOnWeek2Assessment.Model;
using HandsOnWeek2Assessment.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HandsOnWeek2Assessment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentRepository studentRepository;

        public StudentController(IStudentRepository studentRepository)
        {
            this.studentRepository = studentRepository;
        }

        //Add Student
        [HttpPost, Route("AddStudent")]
        public IActionResult AddStudent(Student student)
        {
            try
            {
                studentRepository.AddStudent(student);
                return StatusCode(200, student);
            }
            catch (Exception ex)
            {

                return StatusCode(501, ex);
            }
        }
        //Get Studnt By Qualification
        [HttpGet, Route("GetStudntByQualification/{qualification}")]
        public IActionResult GetStudntByQualification(string qualification)
        {
            try
            {
                return StatusCode(200, studentRepository.GetStudntByQualification(qualification));
            }
            catch (Exception ex)
            {

                return StatusCode(501, ex);
            }
        }

        //get student by skill
        [HttpGet, Route("GetStudentBySkill/{skill}")]
        public IActionResult GetStudentBySkill(string skill)
        {
            try
            {
                return StatusCode(200, studentRepository.GetStudentBySkill(skill));
            }
            catch (Exception ex)
            {

                return StatusCode(501, ex);
            }
        }

        //get student by Id
        [HttpGet, Route("GetStudentById/{id}")]
        public IActionResult GetStudentById(int id)
        {
            try
            {
                Student student = studentRepository.GetStudentById(id);
                if (student != null)
                    return StatusCode(200, student);
                else
                    return StatusCode(404, new JsonResult("Invalid Student Id"));
            }
            catch (Exception ex)
            {

                return StatusCode(501, ex);
            }
        }

        //update student
        [HttpPut, Route("UpdateStudent")]
        public IActionResult UpdateStudent(Student student)
        {
            try
            {
                studentRepository.UpdateStudent(student);
                return StatusCode(200, "updated");
            }
            catch (Exception ex)
            {

                return StatusCode(501, ex);
            }
        }

        //delete student
        [HttpDelete, Route("DeleteStudent/{id}")]
        public IActionResult DeleteStudent(int id)
        {
            try
            {
                studentRepository.DeleteStudent(id);
                return StatusCode(200, "deleted");

            }
            catch (Exception ex)
            {

                return StatusCode(501, ex);
            }
        }
    }
}

