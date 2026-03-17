#if WINDOWS

namespace ConductorAI.Api.Connectors;

public class WindowsMediaConnector : IDeviceConnector
{
    public string Name => "Windows Media";
    public string Scope => "media";

    public Task<object> GetStatusAsync()
    {
        // SMTC implementation
        throw new NotImplementedException("Soon...");
    }

    public Task<object> ExecuteAsync(string action, Dictionary<string, object>? parameters = null)
    {
        // SMTC implementation
        throw new NotImplementedException("Soon...");
    }   

}

#endif