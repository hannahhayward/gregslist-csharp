using System.ComponentModel.DataAnnotations;

namespace gregslist_csharp.Models
{
public class Dog{
  public int Id {get; set;}

  [Required]
  [MinLength(3)]
  public string Name { get; set; }
  public string Breed { get; set; }
  public int Age { get; set; }
  public int Price { get; set; }
}
}