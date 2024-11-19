using Business.Enums;

namespace Business.Entities;

public class User : Common
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Password { get; set; }
    public string Email { get; set; }
    public Roles Role { get; set; } = Roles.User;

    public ICollection<EloHistory> EloHistories { get; set; } = new List<EloHistory>();
    public ICollection<TeamMembership> TeamMemberships { get; set; } = new List<TeamMembership>();
    public ICollection<Match> MatchesAsPlayer1 { get; set; } = new List<Match>();
    public ICollection<Match> MatchesAsPlayer2 { get; set; } = new List<Match>();
    public ICollection<Match> MatchesAsOpponent1 { get; set; } = new List<Match>();
    public ICollection<Match> MatchesAsOpponent2 { get; set; } = new List<Match>();
}