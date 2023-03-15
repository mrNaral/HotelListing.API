using HotelListing.API.Contracts;
using HotelListing.API.Data;
using Microsoft.EntityFrameworkCore;

namespace HotelListing.API.Repository
{
    public class HotelsRepository : GenericRepository<Hotel>, IHotelsRepository
    {
        private readonly HotelListingDbContext _context;

        public HotelsRepository(HotelListingDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<Hotel> GetWithCountryName(int id)
        {
            var hotel = await _context.Hotels.Include(q => q.Country)
                .FirstOrDefaultAsync(q => q.Id == id);
            return hotel;
        }
    }
}
