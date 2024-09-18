﻿using CSharpFunctionalExtensions;
using GameShop.Application.Read.Extensions;
using GameShop.Domain.Repositories;
using MediatR;

namespace GameShop.Application.Read.Queries.GetGamesByName;

public class GetGamesByNameHandler(
    IGameReadRepository gameReadRepository) : IRequestHandler<GetGamesByNameQuery, IResult<GetGamesByNameQueryResponse>>
{
    private readonly IGameReadRepository _gameReadRepository = gameReadRepository;

    public async Task<IResult<GetGamesByNameQueryResponse>> Handle(GetGamesByNameQuery request, CancellationToken cancellationToken)
    {
        var games = await _gameReadRepository.GetGamesByName(request.GameName, cancellationToken);

        return Result.Success(games.ToGetGamesByNameQueryResponse());
    }
}
