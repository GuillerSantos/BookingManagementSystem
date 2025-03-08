using BookingManamentSystem.Domain.Abstractions;
using MediatR;

namespace BookingManagementSystem.Application.Abstractions.Messaging;

public interface IQueryHandler<TQuery, TResponse> : IRequestHandler<TQuery, Result<TResponse>>
    where TQuery : IQuery<TResponse>
{
}