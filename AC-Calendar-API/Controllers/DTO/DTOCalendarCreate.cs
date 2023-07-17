namespace AC_Calendar_API.Controllers.DTO
{
    public class DTOCalendarCreate
    {
        public string display { get; set; }
        public bool startEditable { get; set; }
        public bool durationEditable { get; set; }
        public string overlap { get; set; }
        public string backgroundColor { get; set; }
        public string borderColor { get; set; }
        public string textColor { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
