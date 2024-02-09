using Newtonsoft.Json;

namespace UnifiJsonConverter.Model
{
    public class PastConnection
    {
        private string associationTime;

        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("assoc_time")]
        public string AssociationTime
        {
            get => associationTime;
            set
            {
                var valueAsTicks = Convert.ToInt64(value);
                var offset = DateTimeOffset.FromUnixTimeSeconds(valueAsTicks);
                associationTime = offset.UtcDateTime.ToString("O");
            }
        }

        [JsonProperty("duration")]
        public int Duration { get; set; }

        [JsonProperty("rx_bytes")]
        public long ReceivedBytes { get; set; }

        [JsonProperty("tx_bytes")]
        public long TransmittedBytes { get; set; }

        [JsonProperty("mac")]
        public string MacAddress { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("hostname")]
        public string Hostname { get; set; }

        [JsonProperty("is_guest")]
        public bool IsGuest { get; set; }

        [JsonProperty("ip")]
        public string IpAddress { get; set; }

        [JsonProperty("is_wired")]
        public bool IsWired { get; set; }

        [JsonProperty("ap_mac")]
        public string AccessPointMac { get; set; }

        [JsonProperty("satisfaction")]
        public double Satisfaction { get; set; }

        [JsonProperty("satisfaction_avg")]
        public double SatisfactionAverage { get; set; }

        [JsonProperty("oid")]
        public string Oid { get; set; }

        [JsonProperty("o")]
        public string O { get; set; }
    }
}
