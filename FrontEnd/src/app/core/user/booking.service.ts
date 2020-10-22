import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { bookingDto } from 'src/app/model/bookingDto';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class BookingService {

  constructor(private http:HttpClient) { }

  reservation(_bookingDto : bookingDto): Observable<bookingDto>
  {
    const headers = new HttpHeaders().set('Content-Type','application/json');

    return this.http.post<bookingDto>('https://localhost:44349/api/booking/booking',
    {
      email: _bookingDto.Email, 
      BookingId: _bookingDto.BookingId,
      Date: _bookingDto.Date,
      Time: _bookingDto.Time,
      NumberOfPeople: _bookingDto.NumberOfPeople,
      OrderPlaced: _bookingDto.OrderPlaced,
      SpecialRequests: _bookingDto.SpecialRequests,
      CustomerId: _bookingDto.CustomerId,
      firstName: _bookingDto.firstName,
      lastName: _bookingDto.lastName,
    },{headers:headers});
    
  }
}
