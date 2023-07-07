using Microsoft.AspNetCore.Mvc;

namespace CritterConduit.Auth;

[ApiController, Route("api/users")]
public class RegistrationController : ControllerBase
{
    [HttpPost]
    public async Task<RegistrationResponse> Register(RegistrationRequest user)
    {
        return user.User;
    }
}


public record RegistrationRequest(RegistrationResponse User);

public record RegistrationResponse(string Email, string? Token, string Username, string? Bio, string? Image);


