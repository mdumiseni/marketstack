using Marketstack.HttpRequestHandler;
using Marketstack.Models;
using Newtonsoft.Json;

namespace Marketstack;

public class Marketstack(string accessKey, IHttpClientFactory httpClientFactory)
{
    public async Task<EndOfDay?> GetTickerEndOfDay(EodParameters? requestParams)
    {
        var parameter = GetEndOfDayParameterList(requestParams);
        var url = $"{Constants.Endpoints.EndOfDay}?{parameter}&access_key={accessKey}";
        
        try
        {
            var contentStream = await GetAsync(url);
            return JsonConvert.DeserializeObject<EndOfDay>(contentStream);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    /// <summary>
    ///  Intraday prices are available for all US stock tickers included in the IEX (Investors Exchange) stock exchange.
    /// </summary>
    /// <param name="symbol">The stock ticker symbol of the current data object.</param>
    /// <param name="startDate">Filter results based on a specific timeframe by passing an end-date in YYYY-MM-DD format. You can also specify an exact time in ISO-8601 date format, e.g. 2020-05-21T00:00:00+0000.</param>
    /// <param name="endDate">Filter results based on a specific timeframe by passing an end-date in YYYY-MM-DD format. You can also specify an exact time in ISO-8601 date format, e.g. 2020-05-21T00:00:00+0000.</param>
    /// <returns></returns>
    public async Task<EndOfDay?> GetHistoricalData(string symbol, DateTime startDate, DateTime endDate)
    {
        return await GetTickerEndOfDay(new EodParameters()
        {
            Symbols = symbol,
            DateTo = endDate,
            DateFrom = startDate
        });
    }

    private string GetEndOfDayParameterList(EodParameters? requestParams)
    {
        if (requestParams is null)
            return string.Empty;

        var parameters = new List<string>();
        
        parameters.AddRange(QueryStringBuilder.GetQueryParameters(requestParams));
        
        if (!string.IsNullOrEmpty(requestParams.Symbols))
            parameters.Add($"symbols={requestParams.Symbols}");
        
        return string.Join("&", parameters.ToArray());;
    }

    private async Task<string> GetAsync(string url)
    {
        var httpClient = httpClientFactory.CreateClient("Marketstack");
        
        var httpResponseMessage = await httpClient.GetAsync(url);

        if (!httpResponseMessage.IsSuccessStatusCode) throw new HttpRequestException();
        
        return await httpResponseMessage.Content.ReadAsStringAsync();
    }
}