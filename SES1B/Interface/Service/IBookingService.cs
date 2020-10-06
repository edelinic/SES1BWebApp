using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SES1B.Shared.DTO;

namespace SES1B.Interface.Service
{

    public interface IBookingService
    {
        
          BookingDTO createBooking(BookingDTO bookingDTO);
    }
}
