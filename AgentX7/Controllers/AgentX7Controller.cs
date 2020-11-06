using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AgentX7.DTO;

namespace AgentX7.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AgentX7Controller : ControllerBase
    {
        private readonly ILogger<AgentX7Controller> _logger;

        public AgentX7Controller(ILogger<AgentX7Controller> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        public void Post(MeddelandeIN message)
        {
            Console.Write(("Received message"));
        }
    }
}
