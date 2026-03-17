namespace ConductorAI.Api.Models;

public class AuthSettings
{
    public const string Section = "Auth";
    public List<ApiKey> ApiKeys { get; set; } = [];
}