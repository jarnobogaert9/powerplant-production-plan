using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace PowerPlantChallenge.Api.Dtos
{
    public class Payload
    {
        [Required]
        [Range(1, Int32.MaxValue)]
        public double Load { get; set; }
        
        [Required]
        public Fuel Fuels { get; set; }
        
        [Required]
        public List<Powerplant> Powerplants { get; set; }
    }
}
