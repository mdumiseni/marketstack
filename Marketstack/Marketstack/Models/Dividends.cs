using Newtonsoft.Json;

namespace Marketstack.Models;

public class Dividends
{
    [JsonProperty(PropertyName = "pagination")]
    public Pagination Pagination { get; set; }
    [JsonProperty(PropertyName = "data")]
    public DividendData[] Data { get; set; }
}
public class DividendData
{
    [JsonProperty(PropertyName = "date")]
    public DateTime Date { get; set; }
    [JsonProperty(PropertyName = "dividend")]
    public double Dividend { get; set; }
    [JsonProperty(PropertyName = "symbol")]
    public string Symbol { get; set; }
}

