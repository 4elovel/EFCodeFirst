namespace Entities;

public class Team
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? City { get; set; }
    public int? Win { get; set; }
    public int? Lose { get; set; }
    public int? Tie { get; set; }
    public int? ConfirmedGoals { get; set; }
    public int? ConcededGoals { get; set; }
}