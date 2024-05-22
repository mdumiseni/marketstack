using Newtonsoft.Json;

namespace Marketstack.Models;

public class Currencies
{
    [JsonProperty(PropertyName = "pagination")]
    public Pagination Pagination { get; set; }
    [JsonProperty(PropertyName = "data")]
    public CurrenciesData[] Data { get; set; }
}

public class CurrenciesData
{
    [JsonProperty(PropertyName = "code")]
    public string Code { get; set; }
    [JsonProperty(PropertyName = "symbol")]
    public string Symbol { get; set; }
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }
}