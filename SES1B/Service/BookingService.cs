using SES1B.Interface.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SES1BBackendAPI.Domain.Repository;
using SES1BBackendAPI.Interface.Domain;
using SES1B.Shared.DTO;


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

        public BookingDTO booking(BookingDTO bookingDTO)
        {
 // Am not sure if the booking DTO is the resource for the frontend input
//but I will work with it like this for now


//Checking all info is valid
            if (bookingDTO.Time == null || bookingDTO.Date == null )
            {
                return bookingDTO;
            }

//making sure the e-mail is valid
//It is not in the DTO tho ?
//IsValidEmail





//This should push it to the database according to my unserstanding 
            return bookingDTO;// need to push it the db
        }



    }
}
