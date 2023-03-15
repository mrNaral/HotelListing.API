using HotelListing.API.Data;
using HotelListing.API.Models.Country;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelListing.API.Models.Hotel
{
    public class HotelDto : BaseHotelDto
    {
        public int Id { get; set; }
        public string CountryName { get; set; }

    }
}

