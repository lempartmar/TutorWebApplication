using Microsoft.AspNetCore.Mvc;

namespace TutorAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {

        [HttpGet(Name = "GetTutorId2")]
        public String GetTutorId2()
        {
            return "123";
        }
    }
}
