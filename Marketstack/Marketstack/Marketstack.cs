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