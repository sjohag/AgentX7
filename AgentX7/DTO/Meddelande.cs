using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace AgentX7.DTO
{
    public class MeddelandeIN
    {
        public int Id { get; set; }
        public string Spyhandle { get; set; }
        public string Binary { get; set; }
    }
    public class MeddelandeUT
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("spyhandle")]
        public string Spyhandle { get; set; }
        [JsonPropertyName("binary")]
        public string Binary { get; set; }
    }
}
