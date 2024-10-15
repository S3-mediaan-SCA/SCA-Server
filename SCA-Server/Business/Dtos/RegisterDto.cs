using Business.Enums;

namespace Business.Dtos;

public class RegisterDto
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string ConfirmPassword { get; set; }
    public Roles Role { get; set; } = Roles.User;
}