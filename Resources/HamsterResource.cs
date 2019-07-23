using System.ComponentModel.DataAnnotations;

namespace AnimalsAPI.Resources
{
    public class HamsterResource
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        
        [Required]
        public int Age { get; set; }
    }
}