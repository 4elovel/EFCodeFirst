using System.ComponentModel.DataAnnotations.Schema;

namespace Entities;
public class Match
{
    public int Id { get; set; }
    public int HomeTeam { get; set; }
    public int GuestTeam { get; set; }
    public int? GoalHome { get; set; }
    public int? GoalGuest { get; set; }
    public string? Date { get; set; }
    [ForeignKey("HomeTeam")]
    public virtual Team HTeam { get; set; }
    [ForeignKey("GuestTeam")]
    public virtual Team GTeam { get; set; }
    public string? info { get; set; }

}
