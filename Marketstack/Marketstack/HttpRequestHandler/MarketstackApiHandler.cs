namespace Marketstack.HttpRequestHandler;

public class MarketstackApiHandler
{
    public async Task<string> GetAsync(string endpointUrl)
    {
        using var client = new HttpClient();
        const string baseUrl = "http://api.marketstack.com";
        client.BaseAddress = new Uri(baseUrl);

        var request = await client.GetAsync(endpointUrl);
        if (!request.IsSuccessStatusCode) throw new Exception();
        
        var response = await request.Content.ReadAsStringAsync();
        return response;
    }
}