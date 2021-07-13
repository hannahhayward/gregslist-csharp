using System.ComponentModel.DataAnnotations;

namespace gregslist_csharp.Models
{
public class Dog{
  public int Id {get; set;}

  [Required]
  [MinLength(3)]
  public string Name { get; set; }
  [Required]
  [MinLength(3)]

  public string Breed { get; set; }
  [Required]
  public int Age { get; set; }
  [Required]
  public int Price { get; set; }
}
}