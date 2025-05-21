using System.Security.Claims;

namespace DigiMenu.Api.Authentication;

public static class ClaimsPrincipalExtensions
{
    public static int GetUserId(this ClaimsPrincipal claimsPrincipal)
    {
        if(!int.TryParse(claimsPrincipal.FindFirstValue(ClaimTypes.NameIdentifier), out var id))
            throw new InvalidOperationException("Invalid UserId");

        return id;
    }
}