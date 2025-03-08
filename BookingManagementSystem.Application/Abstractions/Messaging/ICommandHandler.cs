using BookingManamentSystem.Domain.Abstractions;
using BookingManagementSystem.Application.Abstractions.Messaging;
using MediatR;

namespace BookingManagementSystem.Application.Abstractions.Messaging;

public interface ICommandHandler<TCommand> : IRequestHandler<TCommand, Result>
    where TCommand : BookingManagementSystem.Application.Abstractions.Messaging.ICommad
{
}

public interface ICommandHandler<TCommand> : IRequestHandler<TCommand, Result>
    where TCommand : BookingManagementSystem.Application.Abstractions.Messaging.ICommad
{
}