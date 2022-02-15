using Dapr.Client;
using Microsoft.AspNetCore.Mvc;

namespace Service02.Controllers
{
    [ApiController]
    public class HelloController : ControllerBase
    {
        private readonly DaprClient _daprClient;

        public HelloController(DaprClient daprClient)
        {
            _daprClient = daprClient;
        }

        [HttpGet("api/Hello")]
        public async Task<IActionResult> Hello()
        {
            // 通过dapr访问Service01的API
            var result = await _daprClient.InvokeMethodAsync<object>(HttpMethod.Get, "service01", "api/hello");
            
            return Ok(result);
        }
    }
}
