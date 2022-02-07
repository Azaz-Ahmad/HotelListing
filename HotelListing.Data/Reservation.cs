using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HotelListing.Data
{
    public class Reservation
    {
        public int ReservationId { get; set; }
        public int CustomerId { get; set; }
        [ForeignKey(nameof(Hotel))]
        public int HotelId { get; set; }
        //[ForeignKey(nameof(Country))]
        public int CountryId { get; set; }
        public DateTime ReservationDate { get; set; }
        public DateTime AccommodationDate { get; set; }
        public Hotel Hotel { get; set; }
        public Country Country { get; set; }
        //public virtual IList<Hotel> Hotels { get; set; }
    }
}
