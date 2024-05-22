namespace Marketstack.HttpRequestHandler;

public class MarketstackApiHandler(string access_key)
{
    public async Task<string> GetAsync(string endpointUrl)
    {
        using var client = new HttpClient();
        client.BaseAddress = new Uri(Constants.Endpoints.BaseUrl);
        

        return "";
    }
}