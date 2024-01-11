using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StaffAPI.Model;
using StaffAPI.Repository;

namespace StaffAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StaffController : ControllerBase
    {
        private readonly IStaffRepository staffRepository;

        public StaffController(IStaffRepository staffRepository)
        {
            this.staffRepository = staffRepository;
        }
        [HttpGet,Route("GetAllStaffs")]
        public IActionResult Get()
        {
            try
            {
                return Ok(staffRepository.GetAll);
            }
            catch (Exception)
            {
                throw;

            }
        }
        [HttpGet, Route("GetAllStaffs")]
        public IActionResult Get()
        {
            try
            {
                return Ok(staffRepository.GetAll);
            }
            catch (Exception)
            {
                throw;

            }
        }
        [HttpPost, Route("AddStaff")]
        public IActionResult Staff(Staff staff)
        {
            try
            {
                return Ok(staffRepository.GetAll);
            }
            catch (Exception)
            {
                throw;

            }
        }
    }
}
