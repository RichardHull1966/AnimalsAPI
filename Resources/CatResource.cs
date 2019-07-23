using System.ComponentModel.DataAnnotations;

namespace AnimalsAPI.Resources
{
    public class CatResource
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Type { get; set; }

        [Required]
        public int YearOfBirth { get; set; }
    }
}