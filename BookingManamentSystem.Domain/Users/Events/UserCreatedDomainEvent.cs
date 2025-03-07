using BookingManamentSystem.Domain.Abstractions;

namespace BookingManamentSystem.Domain.Users.Events
{
    public record UserCreatedDomainEvent(Guid UserId) : IDomainEvent;
}