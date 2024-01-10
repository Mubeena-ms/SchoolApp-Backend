using HandsOnWeek2Assessment.Model;
using HandsOnWeek2Assessment.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HandsOnWeek2Assessment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private readonly ICompanyRepository companyRepository;

        public CompanyController(ICompanyRepository companyRepository)
        {
            this.companyRepository = companyRepository;
        }

        //Get All Company
        [HttpGet, Route("GetAllBook")]
        public IActionResult GetAll()
        {

            try
            {
                List<Company> companies = companyRepository.GetAllCompany();
                return StatusCode(200, companies);
            }
            catch (Exception ex)
            {

                return StatusCode(501, ex);
            }
        }

        //Add company
        [HttpPost, Route("AddCompany")]
        public IActionResult AddCompany(Company company) 
        {
            try
            {
                companyRepository.AddCompany(company);
                return StatusCode(200, company);
            }
            catch (Exception ex)
            {

                return StatusCode(501, ex);
            }
        }

        //Get Company By City
        [HttpGet, Route("GetCompanyByCity/{city}")]
        public IActionResult GetCompanyByCity(string city) 
        {
            try
            {
                return StatusCode(200, companyRepository.GetCompanyByCity(city));
            }
            catch (Exception ex)
            {

                return StatusCode(501, ex);
            }
        }

        //Get Company By Id
        [HttpGet, Route("GetStudentById/{id}")]
        public IActionResult GetStudentById(int id)
        {
            try
            {
                Company company = companyRepository.GetCompanyById(id);
                if (company != null)
                    return StatusCode(200, company);
                else
                    return StatusCode(404, new JsonResult("Invalid company Id"));
            }
            catch (Exception ex)
            {

                return StatusCode(501, ex);
            }
        }

        //Delete Company
        [HttpDelete, Route("DeleteCompany/{id}")]
        public IActionResult DeleteCompany(int id)
        {
            try
            {
                companyRepository.DeleteCompany(id);
                return StatusCode(200, "deleted");

            }
            catch (Exception ex)
            {

                return StatusCode(501, ex);
            }
        }
    }
}
