using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoviesAPI.Domain.Models

{
     public class Movie
     {

          public int Id { get; set; }

          public string Name { get; set; }

          public int Year { get; set; }
     }
}
