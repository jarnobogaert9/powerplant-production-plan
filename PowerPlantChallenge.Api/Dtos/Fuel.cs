using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace PowerPlantChallenge.Api.Dtos
{
    public class Fuel
    {
        [JsonPropertyName("gas(euro/MWh)")]
        [DisplayName("gas(euro/MWh)")]
        [Required]
        public double Gas { get; set; }

        [JsonPropertyName("kerosine(euro/MWh)")]
        [DisplayName("kerosine(euro/MWh)")]
        [Required]
        public double Kerosine { get; set; }

        [JsonPropertyName("co2(euro/ton)")]
        [DisplayName("co2(euro/ton)")]
        [Required]
        public double Co2{ get; set; }

        [JsonPropertyName("wind(%)")]
        [DisplayName("wind(%)")]
        [Required]
        public double Wind { get; set; }
    }
}
