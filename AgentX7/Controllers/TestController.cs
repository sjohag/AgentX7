using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AgentX7.DTO;
using System.Net.Http;

namespace AgentX7.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestController : ControllerBase
    {
        private readonly ILogger<TestController> _logger;

        public TestController(ILogger<TestController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        public ActionResult<MeddelandeUT> Post(MeddelandeIN message)
        {
            Console.Write(("Received message"));
            _logger.LogError(System.Text.Json.JsonSerializer.Serialize(message));
            var meddelandeUT = new MeddelandeUT
            {
                id = 3,
                spyhandle = "AgentX7",
                binary = $"{message.Binary} 01110010 01110101"
            };
            return meddelandeUT;
        }
    }
}
