namespace Marketstack.Models;

public class RequestParams
{
    public string Exchange { get; set; }
    public string Sort { get; set; }
    public DateTime? DateFrom { get; set; } 
    public DateTime? DateTo { get; set; } 
    public int Limit { get; set; }
    public int Offset { get; set; }
}