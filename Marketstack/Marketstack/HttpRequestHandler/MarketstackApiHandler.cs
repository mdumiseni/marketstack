namespace Marketstack.HttpRequestHandler;

public class MarketstackApiHandler(IHttpClientFactory httpClientFactory)
{
    public async Task<string> GetAsync(string endpointUrl)
    {
        using var client =  httpClientFactory.CreateClient("Marketstack");
        
        var request = await client.GetAsync(endpointUrl);
        if (!request.IsSuccessStatusCode) throw new HttpRequestException("Failed to communicate with api");
        
        var response = await request.Content.ReadAsStringAsync();
        return response;
    }
}