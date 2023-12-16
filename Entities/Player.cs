using System.ComponentModel.DataAnnotations.Schema;

namespace Entities;

public class Player
{
    public int Id { get; set; }
    public String? FirstName { get; set; }
    public String? LastName { get; set; }
    public String? Country { get; set; }
    public int? Number { get; set; }
    public string? Position { get; set; }
    public int TeamId { get; set; }
    [ForeignKey("TeamId")]
    public virtual Team Team { get; set; }
}
