using Marketstack.Models;

namespace Marketstack.HttpRequestHandler;

public static class QueryStringBuilder
{
    public static List<string> GetQueryParameters(RequestParams requestParams)
    {
        var parameters = new List<string>();
        
        if (!string.IsNullOrEmpty(requestParams.Exchange))
            parameters.Add($"exchanges={requestParams.Exchange}");
        if (!string.IsNullOrEmpty(requestParams.Sort))
            parameters.Add($"sort={requestParams.Sort}");
        if (requestParams.Limit >= 0)
            parameters.Add($"limit={requestParams.Limit}");
        if(requestParams.Offset >= 0)
            parameters.Add($"offset={requestParams.Offset}");
        if (requestParams.DateFrom is not null)
        {
            var fromDate =  requestParams.DateFrom?.ToString("s").Split("T")[0];
            parameters.Add($"date_from={fromDate}");
        }

        if (requestParams.DateTo is not null)
        {
            var toDate = requestParams.DateTo?.ToString("s").Split("T")[0];
            parameters.Add($"date_to={toDate}");
        }
        
        return parameters;
    }
}