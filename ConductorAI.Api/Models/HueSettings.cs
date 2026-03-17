namespace ConductorAI.Models;

public class HueSettings
{
    public const string Section = "Hue";
    public string BridgeIp { get; set; } = string.Empty;
    public string AppKey { get; set; } = string.Empty;
    public int BridgePort { get; set; } = 80;
}