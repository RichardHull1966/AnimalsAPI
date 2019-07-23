using System.ComponentModel.DataAnnotations;

namespace MoviesAPI.Resources
{
    public class SaveHamsterResource
    {
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }
    }
}