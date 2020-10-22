import { Time } from '@angular/common';

export class bookingDto{
    Email: string;
    BookingId: number;
    Date: Date;
    Time: Time;
    NumberOfPeople: number;
    OrderPlaced: number;
    SpecialRequests: string;
    CustomerId: number;
    
    firstName: string;
    lastName: string;
}