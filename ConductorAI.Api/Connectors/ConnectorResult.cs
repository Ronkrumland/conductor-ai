namespace ConductorAI.Api.Connectors;

public class ConnectorResult
{
    public bool Success { get; set; }
    public object? Data { get; set; }
    public string? Error { get; set; }

    public static ConnectorResult Ok(object data) => new()
    {
        Success = true,
        Data = data
    };

    public static ConnectorResult Fail(string error) => new()
    {
        Success = false,
        Error = error
    };
}
