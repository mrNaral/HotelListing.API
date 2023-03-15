﻿using System.ComponentModel.DataAnnotations;

namespace HotelListing.API.Models.Hotel
{
    public class CreateHotelDto : BaseHotelDto
    {
        [Required]
        [Range(1, int.MaxValue)]
        public int CountryId { get; set; }
    }
}
