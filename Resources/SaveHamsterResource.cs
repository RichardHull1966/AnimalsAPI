using System.ComponentModel.DataAnnotations;

namespace AnimalsAPI.Resources
{
    public class SaveHamsterResource
    {
        [Required]
        [MaxLength(150)]
        public string Name { get; set; }

        [Required]
        public string Age { get; set; }
    }
}