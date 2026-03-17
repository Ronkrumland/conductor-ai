namespace ConductorAI.Api.Connectors;

public interface IDeviceConnector
{
    string Name { get; }
    string Scope { get; }
    Task<ConnectorResult> GetStatusAsync();
    Task<ConnectorResult> ExecuteAsync(string action, Dictionary<string, string>? parameters = null);
}
