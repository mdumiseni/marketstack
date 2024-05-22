using Newtonsoft.Json;

namespace Marketstack.Models;

public class StockExchange
{
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }
    [JsonProperty(PropertyName = "acronym")]
    public string Acronym { get; set; }
    [JsonProperty(PropertyName = "mic")]
    public string Mic { get; set; }
    [JsonProperty(PropertyName = "country")]
    public string Country { get; set; }
    [JsonProperty(PropertyName = "country_code")]
    public string Country_code { get; set; }
    [JsonProperty(PropertyName = "city")]
    public string City { get; set; }
    [JsonProperty(PropertyName = "website")]
    public string Website { get; set; }
}