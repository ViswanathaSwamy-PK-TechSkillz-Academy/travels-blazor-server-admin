using System.Text.Json.Serialization;

namespace TravelsAdmin.Web.Data;

public class CountryInfoDto
{
    [JsonPropertyName("capital_state")]
    public string? CapitalState { get; set; }

    [JsonPropertyName("country_name")]
    public string? CountryName { get; set; }

    [JsonPropertyName("country_population")]
    public int CountryPopulation { get; set; }

    [JsonPropertyName("national_bird")]
    public string? NationalBird { get; set; }
}