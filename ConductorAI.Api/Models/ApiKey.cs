namespace ConductorAI.Api.Models;

public class ApiKey
{
    public string Name { get; set; } = string.Empty;
    public string Key { get; set; } = string.Empty;
    public List<string> Scopes { get; set; } = [];
}