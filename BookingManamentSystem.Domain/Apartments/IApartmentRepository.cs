namespace BookingManamentSystem.Domain.Apartments
{
    public interface IApartmentRepository
    {
        #region Public Methods

        Task<Apartment?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);

        #endregion Public Methods
    }
}