using Marketstack.HttpRequestHandler;
using Marketstack.Models;
using Newtonsoft.Json;

namespace Marketstack.ApiAdapter;

public class Marketstack(string access_key)
{
    private readonly MarketstackApiHandler _client = new();
    
    public async Task<EndOfDay?> GetTickerEndOfDay(string ticker)
    {
        var url = $"{Constants.Endpoints.EndOfDay}?symbols={ticker}&access_key={access_key}";
        var eod = await _client.GetAsync(url);
        return JsonConvert.DeserializeObject<EndOfDay>(eod);
    }
}