namespace ConductorAI.Models;

public class OllamaSettings
{
    public const string Section = "Ollama";
    public string Endpoint { get; set; } = "http://localhost:11434";
    public string Model { get; set; } = string.Empty;
}
