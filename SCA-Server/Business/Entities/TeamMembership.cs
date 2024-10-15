namespace Business.Entities;

public class TeamMembership : Common
{
    public int UserId { get; set; }
    public User User { get; set; }
    public int TeamId { get; set; }
    public Team Team { get; set; }
}