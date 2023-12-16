using System.ComponentModel.DataAnnotations.Schema;

namespace Entities;

public class Goal
{
    public int Id { get; set; }
    public int? MatchId { get; set; }
    public int? PlayerId { get; set; }
    [ForeignKey("MatchId")]
    public virtual Match Match { get; set; }
    [ForeignKey("PlayerId")]
    public virtual Player Player { get; set; }
}
