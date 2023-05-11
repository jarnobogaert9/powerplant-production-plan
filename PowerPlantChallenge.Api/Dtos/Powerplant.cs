using System.ComponentModel.DataAnnotations;

namespace PowerPlantChallenge.Api.Dtos
{
    public class Powerplant
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Type { get; set; }

        [Required]
        public double Efficiency { get; set; }

        [Required]
        public double PMin { get; set; }

        [Required]
        public double PMax { get; set; }

        public double Cost { get; set; }
    }
}
