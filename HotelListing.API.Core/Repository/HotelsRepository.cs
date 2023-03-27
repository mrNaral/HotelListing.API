﻿using AutoMapper;
using HotelListing.API.Core.Contracts;
using HotelListing.API.Data;
using Microsoft.EntityFrameworkCore;

namespace HotelListing.API.Core.Repository
{
    public class HotelsRepository : GenericRepository<Hotel>, IHotelsRepository
    {
        private readonly HotelListingDbContext _context;

        public HotelsRepository(HotelListingDbContext context, IMapper mapper) : base(context, mapper)
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
