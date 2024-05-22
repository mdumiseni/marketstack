using Newtonsoft.Json;

namespace Marketstack.Models;

public class Pagination
{
    [JsonProperty(PropertyName = "limit")]
    public int Limit { get; set; }
    [JsonProperty(PropertyName = "offset")]
    public int Offset { get; set; }
    [JsonProperty(PropertyName = "count")]
    public int Count { get; set; }
    [JsonProperty(PropertyName = "total")]
    public int Total { get; set; }
}