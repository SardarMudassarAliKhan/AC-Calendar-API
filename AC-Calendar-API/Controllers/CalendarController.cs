using AC_Calendar_API.Controllers.DTO;
using AC_Calendar_API_Domain_Layer.Data;
using AC_Calendar_API_Domain_Layer.Models;
using AC_Calendar_API_Service_Layer.IService;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AC_Calendar_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class CalendarController : ControllerBase
    {
        private readonly ICustomService<Calendar> _customService;
        private readonly ApplicationDbContext _applicationDbContext;
        private readonly IMapper _mapper;

        public CalendarController(ICustomService<Calendar> customService, ApplicationDbContext applicationDbContext, IMapper mapper)
        {
            _customService = customService;
            _applicationDbContext = applicationDbContext;
            _mapper = mapper;
        }
        [HttpGet(nameof(GetCalendarById))]
        public IActionResult GetCalendarById(int Id)
        {
            var obj = _customService.Get(Id);
            if (obj == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(obj);
            }
        }
        [HttpGet(nameof(GetAllCalendar))]
        public IActionResult GetAllCalendar()
        {
            var obj = _customService.GetAll();
            if (obj == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(obj);
            }
        }
        [HttpPost(nameof(CreateCalendar))]
        public IActionResult CreateCalendar(DTOCalendarCreate Calendars)
        {

            try
            {
                if (Calendars != null)
                {
                    var Calendarsdata = _mapper.Map<Calendar>(Calendars);
                    _customService.Insert(Calendarsdata);
                    return Ok("Created Successfully");
                }
                else
                {
                    return BadRequest("Somethingwent wrong");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpPost(nameof(UpdateCalendar))]
        public IActionResult UpdateCalendar(DTOCalendar Calendars)
        {
            if (Calendars != null)
            {
                var Calendarsdata = _mapper.Map<Calendar>(Calendars);
                _customService.Update(Calendarsdata);
                return Ok("Updated SuccessFully");
            }
            else
            {
                return BadRequest();
            }
        }
        [HttpDelete(nameof(DeleteCalendar))]
        public IActionResult DeleteCalendar(DTOCalendar Calendars)
        {
            if (Calendars != null)
            {
                var Calendarsdata = _mapper.Map<Calendar>(Calendars);
                _customService.Delete(Calendarsdata);
                return Ok("Deleted Successfully");
            }
            else
            {
                return BadRequest("Something went wrong");
            }
        }
    }
}
