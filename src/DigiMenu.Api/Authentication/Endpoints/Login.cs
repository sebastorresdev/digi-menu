using DigiMenu.Api.Authentication.Services;
using DigiMenu.Api.Common.Api;
using DigiMenu.Api.Common.Api.Extensions;
using DigiMenu.Api.Data;
using FluentValidation;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;

namespace DigiMenu.Api.Authentication.Endpoints;

public class Login : IEndpoint
{
    public static void Map(IEndpointRouteBuilder app) => app
        .MapPost("/login", Handle)
        .WithSummary("Logs in a user")
        .WithRequestValidation<Request>();

    public record Request(string Username, string Password);
    public record Response(string Token);
    public class RequestValidator : AbstractValidator<Request>
    {
        public RequestValidator()
        {
            RuleFor(x => x.Username).NotEmpty();
            RuleFor(x => x.Password).NotEmpty();
        }
    }

    private static async Task<Results<Ok<Response>, UnauthorizedHttpResult>> Handle(Request request, AppDbContext database, Jwt jwt, CancellationToken cancellationToken)
    {
        var user = await database.Usuarios.SingleOrDefaultAsync(x => x.Username == request.Username && x.HashPassword == request.Password, cancellationToken);

        if (user is null || user.HashPassword != request.Password)
        {
            return TypedResults.Unauthorized();
        }

        var token = jwt.GenerateToken(user);
        var response = new Response(token);
        return TypedResults.Ok(response);
    }
}
