using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AnimalsAPI.Domain.Models

{
     public class Cat
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
