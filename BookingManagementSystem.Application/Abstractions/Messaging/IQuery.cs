using BookingManamentSystem.Domain.Abstractions;
using MediatR;

namespace BookingManagementSystem.Application.Abstractions.Messaging
{
    public interface IQuery<TResponse> : IRequest<Result<TResponse>>
    {
    }
}