using Microsoft.AspNetCore.Mvc;
using TestSample.Interfaces;

namespace TestSample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IMath _math;

        public ValuesController(IMath math)
        {
            _math = math;
        }

        [HttpGet]
        public ActionResult<int> Get()
        {
            var a = 0;
            var b = 0;

            return _math.Sum(a, b);
        }
    }
}
