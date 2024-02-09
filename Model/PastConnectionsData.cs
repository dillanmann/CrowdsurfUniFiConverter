using Newtonsoft.Json;

namespace UnifiJsonConverter.Model
{
    public class PastConnectionsData
    {
        [JsonProperty("data")]
        public IEnumerable<PastConnection> Connections { get; set; }
    }
}
