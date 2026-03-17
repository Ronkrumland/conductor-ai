#if WINDOWS

namespace ConductorAI.Api.Connectors;

public class WindowsMediaConnector : IDeviceConnector
{
    public string Name => "Windows Media";
    public string Scope => "media";

    Task<ConnectorResult> IDeviceConnector.GetStatusAsync()
    {
        throw new NotImplementedException();
    }

    Task<ConnectorResult> IDeviceConnector.ExecuteAsync(string action, Dictionary<string, string>? parameters)
    {
        throw new NotImplementedException();
    }
}

#endif