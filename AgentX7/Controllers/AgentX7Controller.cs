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
            _logger.LogError(System.Text.Json.JsonSerializer.Serialize(message));
            var meddelandeUT = new MeddelandeUT
            {
                Id = 3,
                Spyhandle = "AgentX7",
                Binary = $"{message.Binary} 01110010 01110101"
            };
            using var client = new HttpClient();
            var url = $"https://prod-80.westeurope.logic.azure.com:443/workflows/4b7a0f50fb9d4877970c1235825427ce/triggers/manual/paths/invoke?api-version=2016-10-01&sp=%2Ftriggers%2Fmanual%2Frun&sv=1.0&sig=JH_RoBQJe1UsByRsY_DX8XI9TkkjpyN1i57kDaa9wBI";
            client.PostAsJsonAsync(url, meddelandeUT);
        }
    }
}
