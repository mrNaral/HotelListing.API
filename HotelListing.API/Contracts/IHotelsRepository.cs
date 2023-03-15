using HotelListing.API.Data;

namespace HotelListing.API.Contracts
{
    public interface IHotelsRepository : IGenericRepository<Hotel>
    {
        Task<Hotel> GetWithCountryName(int id);
    }
}
