using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace TimeClock.Controllers
{
    [ApiController]
    //[Route("api/v{version:apiVersion}")]
    [Route("api")]
    public class TimeClockAPI : Controller
    {
        [ApiVersion("1.1")]
        [HttpGet]
        [Route("clock")]
        public ActionResult<DateAndTimeV1> GetTimeV1_1()
        {
            //var time = new DateAndTimeV1();
            //var timeNow = DateTime.Now;
            //time.Time = $"{timeNow.ToShortDateString()} {timeNow.Hour}:{timeNow.Minute}:{timeNow.Second}";

            //var timeJson = JsonConvert.SerializeObject(time);

            //return timeJson;

            return new DateAndTimeV1()
            {
                Time = DateTime.Now
            };
        }

        [ApiVersion("1.2")]
        [HttpGet]
        [Route("clock")]
        public ActionResult<DateAndTimeV2> GetTimeV1_2()
        {
            var time = new DateAndTimeV2();
            var today = DateTime.Now;
            time.Year = today.Year;
            time.Month = today.Month;
            time.Day = today.Day;
            time.Hour = today.Hour;
            time.Minute = today.Minute;
            time.Second = today.Second;

            //var timeJson = JsonConvert.SerializeObject(time);

            return time;
        }
    }

    public class DateAndTimeV1
    {
        public DateTime Time { get; set; }
    }

    public class DateAndTimeV2
    {
        public int Year { get; set; }
        public int Month { get; set; }
        public int Day { get; set; }
        public int Hour { get; set; }
        public int Minute { get; set; }
        public int Second { get; set; }
    }
}
