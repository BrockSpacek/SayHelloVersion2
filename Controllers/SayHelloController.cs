
using Microsoft.AspNetCore.Mvc;

namespace SayHello.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SayHelloController : ControllerBase
    {
        [HttpPost]
        [Route("Greeting/{name}")]
        public string UserGreeting(string name)
        {
            return $"Hello, {name}.";
        }
    }
}