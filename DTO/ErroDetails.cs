using System.Text.Json;

namespace test_webapi_app.DTO;

public class ErroDetails
{
    public int StatusCode { get; set; }
    public string? Message { get; set; }

    public ErroDetails(int statusCode, string? message)
    {
        StatusCode = statusCode;
        Message = message;
    }
    public override string ToString()=>JsonSerializer.Serialize(this);
}
