﻿using CSharpFunctionalExtensions;
using MediatR;

namespace GamesShop.Application.Queries.GetAllGamesConsoles;

public record GetAllGamesConsolesQuery() : IRequest<IResult<GetAllGamesConsolesResponse>>;
