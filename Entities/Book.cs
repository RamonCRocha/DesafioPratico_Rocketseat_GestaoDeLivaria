using DesafioPratico_Rocketseat_GestaoDeLivaria.Enums;

namespace DesafioPratico_Rocketseat_GestaoDeLivaria.Entities;

public class Book
{
  public int Id { get; set; }
  public string Title { get; set; } = string.Empty;
  public string Author { get; set; } = string.Empty;
  public required Genre Genre { get; set; }
  public decimal Price { get; set; }
  public int Stock { get; set; }
}
