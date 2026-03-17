namespace ConductorAI.Api.Models;

public class WeatherSettings
{
    public const string Section = "Weather";
    public string GridOffice { get; set; } = string.Empty;
    public int GridX { get; set; }
    public int GridY { get; set; }
}