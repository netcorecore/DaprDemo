using Microsoft.AspNetCore.Mvc;

namespace Service00.Controllers
{
    [ApiController]
    public class HelloController : ControllerBase
    {
        // 每个Service01实例分配不同的InstanceId
        private static readonly string InstanceId = Guid.NewGuid().ToString();

        [HttpGet("api/Hello")]
        public async Task<IActionResult> Hello()
        {
            await Task.CompletedTask;

            // API被访问时，返回InstanceId，来验证负载均衡效果
            return Ok(new { Service = "service00", InstanceId });
        }
    }
}
