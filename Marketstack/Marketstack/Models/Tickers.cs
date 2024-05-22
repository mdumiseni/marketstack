using Newtonsoft.Json;

namespace Marketstack.Models;
public class Tickers
{
    [JsonProperty(PropertyName = "pagination")]
    public Pagination Pagination { get; set; }
    [JsonProperty(PropertyName = "data")]
    public TickerData[] Data { get; set; }
}

public class TickerData
{
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }
    [JsonProperty(PropertyName = "symbol")]
    public string Symbol { get; set; }
    [JsonProperty(PropertyName = "has_intraday")]
    public bool Has_intraday { get; set; }
    [JsonProperty(PropertyName = "has_eod")]
    public bool Has_eod { get; set; }
    [JsonProperty(PropertyName = "country")]
    public object Country { get; set; }
    [JsonProperty(PropertyName = "stock_exchange")]
    public StockExchange Stock_exchange { get; set; }
}


