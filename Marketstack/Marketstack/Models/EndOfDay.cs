using Newtonsoft.Json;

namespace Marketstack.Models;

public class EndOfDay
{
    [JsonProperty(PropertyName = "pagination")]
    public Pagination Pagination { get; set; }
    [JsonProperty(PropertyName = "data")]
    public List<Datum> Data { get; set; }
}
public class Datum
{
    [JsonProperty(PropertyName = "open")]
    public double Open { get; set; }
    [JsonProperty(PropertyName = "high")]
    public double High { get; set; }
    [JsonProperty(PropertyName = "low")]
    public double Low { get; set; }
    [JsonProperty(PropertyName = "close")]
    public double Close { get; set; }
    [JsonProperty(PropertyName = "volume")]
    public double Volume { get; set; }
    [JsonProperty(PropertyName = "adj_high")]
    public double Adj_high { get; set; }
    [JsonProperty(PropertyName = "adj_low")]
    public double Adj_low { get; set; }
    [JsonProperty(PropertyName = "adj_close")]
    public double Adj_close { get; set; }
    [JsonProperty(PropertyName = "adj_open")]
    public double Adj_open { get; set; }
    [JsonProperty(PropertyName = "adj_volume")]
    public double Adj_volume { get; set; }
    [JsonProperty(PropertyName = "split_factor")]
    public double Split_factor { get; set; }
    [JsonProperty(PropertyName = "dividend")]
    public double Dividend { get; set; }
    [JsonProperty(PropertyName = "symbol")]
    public string Symbol { get; set; }
    [JsonProperty(PropertyName = "exchange")]
    public string Exchange { get; set; }
    [JsonProperty(PropertyName = "data")]
    public DateTime Date { get; set; }
}