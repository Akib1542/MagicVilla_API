using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace MagicVilla_VillaAPI.Models.Dto
{
    public class VillaDTO
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(20)]
        public string Name { get; set; }

        public int Occupancy { get; set; }
        public int Sqft { get; set; }
    }
}
