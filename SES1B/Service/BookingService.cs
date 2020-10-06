using SES1B.Interface.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SES1BBackendAPI.Domain.Repository;
using SES1BBackendAPI.Interface.Domain;
using SES1B.Shared.DTO;
using SES1BBackendAPI.Domain.Entity;

namespace SES1BBackendAPI.Service
{
    public class BookingService : IBookingService
    {

 bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }


        // will be used to push it to the DB
        IRepository _repository;
        public BookingService(IRepository repository)
        {
            _repository = repository;
        }

        public BookingDTO createBooking(BookingDTO bookingDTO)
        {
            // make new bool to check if the data is complete
            bool dataComplete = true;

            // make sure all the input are NOT Empty
           
            if (bookingDTO.NumberOfPeople <= 1)
            {
                dataComplete = false;
            }

            if (bookingDTO.Date == null)
            {
                dataComplete = false;
            }
            
            if (bookingDTO.Time == null)
            {
                dataComplete = false;
            }

            // Makes sure that all if cases pass
            if (!dataComplete)
            {
                return bookingDTO;
            }
            
            //var booking = new User()
            //{
            //    FirstName = userDTO.FirstName,
            //    LastName = userDTO.LastName,
            //    Email = userDTO.Email,
            //    PhoneNumber = userDTO.PhoneNumber,
                
            //};




            //This should push it to the database according to my unserstanding 
            return bookingDTO;// need to push it the db
        }



    }
}
