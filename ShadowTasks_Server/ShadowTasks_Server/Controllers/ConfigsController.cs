using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShadowTasks_Server.Models;

namespace ShadowTasks_Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConfigsController : ControllerBase
    {
        [HttpGet]
        [Route("Environment")]
        public ResponseResult<string> GetEnvironment()
        {
            return new ResponseResult<string>(ConfigManager.Environment);
        }
    }
}
