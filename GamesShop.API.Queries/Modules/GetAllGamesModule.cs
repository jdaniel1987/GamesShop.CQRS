﻿using Carter;
using GamesShop.Application.Queries.GetAllGames;
using GamesShop.Domain.Entities;
using MediatR;

namespace GamesShop.API.Queries.Modules;

public class GetAllGamesModule : ICarterModule
{
    public void AddRoutes(IEndpointRouteBuilder app)
    {
        app.MapGet("api/Games", async (IMediator mediator) =>
        {
            return ResultChecker.CheckResult(await mediator.Send(new GetAllGamesQuery()));
        })
        .WithOpenApi(operation =>
        {
            operation.Summary = "Gets all games";
            operation.Description = "Gets all games from system.";
            return operation;
        })
        .WithName(nameof(GetAllGamesModule))
        .WithTags(nameof(Game))
        .Produces(StatusCodes.Status200OK)
        .Produces(StatusCodes.Status500InternalServerError);
    }
}
