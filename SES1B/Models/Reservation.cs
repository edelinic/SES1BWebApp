using System;

namespace SES1B.Models
{
  public class Reservation
  {
    public int idReservation {get; set;}
    public int numPeople {get; set;}
    public int tableNum {get; set;}
    public string specialRequest {get; set;}
    public int phoneNum {get; set;}
    public DateTime dateandtime {get; set;} 
  }
}