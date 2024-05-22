using Newtonsoft.Json;

namespace Marketstack.Models;

public class Exchange
{
    [JsonProperty(PropertyName = "pagination")]
    public Pagination Pagination { get; set; }
    [JsonProperty(PropertyName = "data")]
    public StockExchange[] Data { get; set; }
}