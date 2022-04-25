using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace TimeClock.Controllers
{
    [ApiController]
    [Route("api")]
    public class TimeClockAPI : Controller
    {
        [HttpGet]
        [Route("clock")]
        public string GetTimeV1_1()
        {
            var time = new DateAndTime();
            var timeNow = DateTime.Now;
            time.Time = $"{timeNow.ToShortDateString()} {timeNow.Hour}:{timeNow.Minute}:{timeNow.Second}";

            var timeJson = JsonConvert.SerializeObject(time);

            return timeJson;
        }
    }

    public class DateAndTime
    {
        public string Time { get; set; }
    }
}
