using BookingManamentSystem.Domain.Shared;

namespace BookingManamentSystem.Domain.Bookings
{
    public record PricingDetails(
        Money PriceForPeriod,
        Money CleaningFee,
        Money AmenitiesUpCharge,
        Money TotalPrice);
}