using Newtonsoft.Json;

namespace Marketstack.Models;

public class TimeZone
{
    [JsonProperty(PropertyName = "pagination")]
    public Pagination Pagination { get; set; }
    [JsonProperty(PropertyName = "data")]
    public TimeZoneData Data { get; set; }
}


public class TimeZoneData
{
    [JsonProperty(PropertyName = "timezone")]
    public string TimeZone { get; set; }
    [JsonProperty(PropertyName = "abbr")]
    public string Abbr { get; set; }
    [JsonProperty(PropertyName = "abbr_dst")]
    public string AbbrDst { get; set; }
}