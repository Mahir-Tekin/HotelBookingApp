using System.Net;

public class ServiceResult<T>
{
    public T Data { get; private set; }
    public string ErrorMessage { get; private set; }
    public bool Success { get; private set; }
    public HttpStatusCode StatusCode { get; private set; }

    private ServiceResult(T data, bool success, string? errorMessage, HttpStatusCode statusCode)
    {
        Data = data;
        Success = success;
        ErrorMessage = errorMessage;
        StatusCode = statusCode;
    }

    // Veri içeren başarılı sonuç döndürme metodu
    public static ServiceResult<T> SuccessResult(T data, HttpStatusCode statusCode = HttpStatusCode.OK)
    {
        return new ServiceResult<T>(data, true, null, statusCode);
    }

    // Veri içermeyen başarılı sonuç döndürme metodu
    public static ServiceResult<T> SuccessResult(HttpStatusCode statusCode = HttpStatusCode.OK)
    {
        return new ServiceResult<T>(default, true, null, statusCode);
    }

    // Hatalı sonuç döndürme metodu
    public static ServiceResult<T> FailureResult(string errorMessage, HttpStatusCode statusCode = HttpStatusCode.BadRequest)
    {
        return new ServiceResult<T>(default, false, errorMessage, statusCode);
    }
}
