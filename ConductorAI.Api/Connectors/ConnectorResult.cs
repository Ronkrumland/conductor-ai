namespace ConductorAI.Api.Connectors;

public class ConnectorResult
{
    public bool Success { get; set; }
    public object? Data { get; set; }
    public string? Error { get; set; }

    // actions that return data
    public static ConnectorResult Ok(object data) => new()
    {
        Success = true,
        Data = data
    };

    // actions that succeed with no payload
    public static ConnectorResult Ok() => new()
    {
        Success = true
    };

    public static ConnectorResult Fail(string error) => new()
    {
        Success = false,
        Error = error
    };
}
