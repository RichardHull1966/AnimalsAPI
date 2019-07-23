using System.ComponentModel.DataAnnotations;

namespace AnimalsAPI.Resources
{
    public class SaveCatResource
    {
        [Required]
        [MaxLength(150)]
        public string Name { get; set; }

        [Required]
        public string Type { get; set; }

        [Required]
        public int YearOfBirth { get; set; }
    }
}