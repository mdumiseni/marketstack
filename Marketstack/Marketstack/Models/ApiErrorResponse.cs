using Newtonsoft.Json;

namespace Marketstack.Models;


public class ApiErrorResponse
{
    [JsonProperty(PropertyName = "error")]
    public Error Error { get; set; }
}

public class Context
{
    [JsonProperty(PropertyName = "symbol")]
    public List<Symbol> Symbols { get; set; }
}

public class Error
{
    [JsonProperty(PropertyName = "code")]
    public string Code { get; set; }
    [JsonProperty(PropertyName = "message")]
    public string Message { get; set; }
    [JsonProperty(PropertyName = "context")]
    public Context Context { get; set; }
}

public class Symbol
{
    [JsonProperty(PropertyName = "key")]
    public string Key { get; set; }
    [JsonProperty(PropertyName = "message")]
    public string Message { get; set; }
}

