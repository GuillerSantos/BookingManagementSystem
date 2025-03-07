using BookingManamentSystem.Domain.Abstractions;

namespace BookingManamentSystem.Domain.Bookings.Events
{
    public sealed record BookingReservedDomainEvent(Guid BookingId) : IDomainEvent;
}