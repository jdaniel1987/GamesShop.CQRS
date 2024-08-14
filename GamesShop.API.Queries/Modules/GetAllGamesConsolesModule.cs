﻿using Carter;
using GamesShop.Application.Queries.GetAllGamesConsoles;
using GamesShop.Domain.Entities;
using MediatR;

namespace GamesShop.API.Queries.Modules;

public class GetAllGamesConsolesModule : ICarterModule
{
    public void AddRoutes(IEndpointRouteBuilder app)
    {
        app.MapGet("api/GamesConsoles", (IMediator mediator) =>
        {
            return mediator.Send(new GetAllGamesConsolesQuery());
        })
        .WithOpenApi()
        .WithName(nameof(GetAllGamesConsolesModule))
        .WithTags(nameof(GamesConsole));
    }
}
