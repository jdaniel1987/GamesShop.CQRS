﻿using CSharpFunctionalExtensions;
using MediatR;

namespace GamesShop.Application.Commands.AddGamesConsole;

public record AddGamesConsoleCommand(
    string Name,
    string Manufacturer,
    double Price) : IRequest<IResult<AddGamesConsoleResponse>>;
