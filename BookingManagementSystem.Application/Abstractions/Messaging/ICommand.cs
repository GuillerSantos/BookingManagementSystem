using BookingManamentSystem.Domain.Abstractions;
using MediatR;

namespace BookingManagementSystem.Application.Abstractions.Messaging;

public interface ICommad : IRequest<Result>
{
}

public interface ICommad<TResponse> : IRequest<Result<TResponse>>, IBaseCommand
{
}

public interface IBaseCommand
{
}