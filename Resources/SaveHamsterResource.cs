using System.ComponentModel.DataAnnotations;

namespace MoviesAPI.Resources
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