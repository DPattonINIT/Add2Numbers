using Microsoft.AspNetCore.Mvc;

namespace Add2Numbers.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserNumberController : ControllerBase
    {
        [HttpGet]
        [Route("FetchUserNumbers/{userNum1}/{userNum2}")]

        public IActionResult Sum(int userNum1, int userNum2)
        {
            int results = userNum1 + userNum2;
            return Ok($"The sum of {userNum1} and {userNum2} is {results}");
        }
    }
}