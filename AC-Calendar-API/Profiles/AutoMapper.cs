using AC_Calendar_API.Controllers.DTO;
using AC_Calendar_API_Domain_Layer.Models;
using AutoMapper;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AC_Calendar_API.Profiles
{
    public class AutoMapper : Profile
    {
        public AutoMapper()
        {
            CreateMap<Calendar, DTOCalendarCreate>().ReverseMap();
            CreateMap<Calendar, DTOCalendar>().ReverseMap();
        }
    }
}
