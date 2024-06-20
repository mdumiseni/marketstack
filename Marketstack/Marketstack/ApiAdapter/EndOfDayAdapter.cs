using System.Text;
using Marketstack.HttpRequestHandler;
using Marketstack.Models;
using Newtonsoft.Json;

namespace Marketstack.ApiAdapter;

public class EndOfDayAdapter(MarketstackApiHandler client)
{
    public async Task<EndOfDay?> GetTickerEoEndOfDay(string ticker)
    {
        var eod = await client.GetAsync(Constants.Endpoints.EndOfDay);
        return JsonConvert.DeserializeObject<EndOfDay>(eod);
    }
    
    public async Task<EndOfDay?> GetTickerEoEndOfDay(string ticker, Options options)
    {
        var optionalParam = new StringBuilder();

        if (options.From is not null)
        {
            optionalParam.Append($"&date_from={options.From}");
        }
        var eod = await client.GetAsync(Constants.Endpoints.EndOfDay);
        return JsonConvert.DeserializeObject<EndOfDay>(eod);
    }
}