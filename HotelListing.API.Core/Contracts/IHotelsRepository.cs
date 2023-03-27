using HotelListing.API.Data;

namespace HotelListing.API.Core.Contracts
{
    public interface IHotelsRepository : IGenericRepository<Hotel>
    {
        Task<Hotel> GetWithCountryName(int id);
    }
}
