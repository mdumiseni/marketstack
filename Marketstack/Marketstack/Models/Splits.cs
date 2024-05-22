using Newtonsoft.Json;

namespace Marketstack.Models;

public class Splits
{
    [JsonProperty(PropertyName = "pagination")]
    public Pagination Pagination { get; set; }
    [JsonProperty(PropertyName = "data")]
    public Data[] Data { get; set; }
}

public class Data
{
    [JsonProperty(PropertyName = "date")]
    public DateTime date { get; set; }
    [JsonProperty(PropertyName = "split_factor")]
    public double Split_factor { get; set; }
    [JsonProperty(PropertyName = "symbol")]
    public string Symbol { get; set; }
}

