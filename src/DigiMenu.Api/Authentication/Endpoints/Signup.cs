using DigiMenu.Api.Authentication.Services;
using DigiMenu.Api.Common.Api;
using DigiMenu.Api.Common.Api.Extensions;
using DigiMenu.Api.Common.Api.Results;
using DigiMenu.Api.Data;
using DigiMenu.Api.Data.Entities;
using FluentValidation;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;

namespace DigiMenu.Api.Authentication.Endpoints;

public class Signup : IEndpoint
{
    public static void Map(IEndpointRouteBuilder app) => app
        .MapPost("/signup", Handle)
        .WithSummary("Creates a new user account")
        .WithRequestValidation<Request>();

    public record Request(string Username, string Password, string Name);
    public record Response(string Token);
    public class RequestValidator : AbstractValidator<Request>
    {
        public RequestValidator()
        {
            RuleFor(x => x.Username).NotEmpty();
            RuleFor(x => x.Password).NotEmpty();
            RuleFor(x => x.Name).NotEmpty();
        }
    }

    private static async Task<Results<Ok<Response>, ValidationError>> Handle(Request request, AppDbContext database, Jwt jwt, CancellationToken cancellationToken)
    {
        var isUsernameTaken = await database.Usuarios
            .AnyAsync(x => x.Username == request.Username, cancellationToken);

        if (isUsernameTaken)
            return new ValidationError("Username is already taken");

        // TODO: Hash password

        var user = new Usuario
        {
            Username = request.Username,
            HashPassword = request.Password,
            Nombres = request.Name
        };
        await database.Usuarios.AddAsync(user, cancellationToken);
        await database.SaveChangesAsync(cancellationToken);

        var token = jwt.GenerateToken(user);
        var response = new Response(token);
        return TypedResults.Ok(response);
    }
}