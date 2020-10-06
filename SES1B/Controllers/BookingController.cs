using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SES1B.Interface.Service;
using SES1B.Shared.DTO;

namespace SES1B.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        IBookingService _bookingService;
        public BookingController(IBookingService bookingService)
        {
            _bookingService = bookingService;
        }



        [HttpPost("/booking")]
        public ActionResult<BookingDTO> createBooking([FromForm] BookingDTO bookingDTO, UserDTO userDTO)
        {
            return _bookingService.createBooking(bookingDTO);
        }

    }
}