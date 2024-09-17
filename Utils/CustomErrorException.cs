namespace test_webapi_app.Utils;

public class CustomErrorException: Exception
{
    public int ErrorCode { get; set; }
    public string ErrorMessage { get; set; }
    public CustomErrorException(int errorCode, string errorMessage)
    {
        ErrorCode = errorCode;
        ErrorMessage = errorMessage;
    }
}
