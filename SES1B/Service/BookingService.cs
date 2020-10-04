using Microsoft.AspNetCore.Identity;
using SES1B.Interface.Service;
using SES1B.Shared.DTO;
using SES1BBackendAPI.Domain.Repository;
using SES1BBackendAPI.Interface.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SES1BBackendAPI.Service
{
    public class BookingService : IBookingService
    {

        IRepository _repository;
        public BookingService(IRepository repository)
        {
            _repository = repository;
        }

        public BookingDTO ModifyBooking(BookingDTO bookingDto) 
        {
            // Retrieve the booking information from DB
            var booking = _repository.GetBooking().WithBookingId(bookingDto.BookingId);

            // Check Email + Password
            // if email not registered; return false
            if (booking != null) {
                bookingDto.BookingId = booking.BookingId;
                bookingDto.Date = booking.Date;
                bookingDto.Time = booking.Time;
                bookingDto.NumberOfPeople = booking.NumberOfPeople;
                bookingDto.OrderPlaced = booking.OrderPlaced;
                bookingDto.SpecialRequests = booking.SpecialRequests;
        
            }

            return bookingDto;

        }




















    }
}
