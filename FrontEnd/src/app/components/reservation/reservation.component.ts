import { Component, OnInit } from '@angular/core';
import { Title } from '@angular/platform-browser';
import { state } from 'src/app/model/state';
import { FormGroup, FormControl } from '@angular/forms';
import { BookingService } from 'src/app/core/user/booking.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-reservation',
  templateUrl: './reservation.component.html',
  styleUrls: ['./reservation.component.scss']
})

export class ReservationComponent implements OnInit {
  signedIn: boolean;
  userFirstName: string;
  userLastName: string;
  userName: string;
  userEmail: string;
  userPhone: string;
  today = new Date();

  reservationForm: FormGroup;
  isSuccess: boolean;

  constructor(private titleService: Title,
    private bookingService: BookingService,
    private router: Router) {
    this.titleService.setTitle("eDine - Book a Table");

    if (state.userFirstName == null) {
      this.userName = "Not Logged in"
    }
    else {
      this.userName = state.userFirstName + " " + state.userLastName;
    }

    if (state.userFirstName == null || state.userLastName == null) {
      this.userFirstName = "N/A"
      this.userLastName = "N/A"
      this.userEmail = "N/A"
      this.userPhone = "N/A"
      this.signedIn = false;
    }
    else {
      this.userFirstName = state.userFirstName;
      this.userLastName = state.userLastName;
      this.userEmail = state.userEmail;
      this.userPhone = state.userPhone;
      this.signedIn = true;
    }
  }

  ngOnInit(): void {
    this.reservationForm = new FormGroup({
      email: new FormControl(""),
      BookingId: new FormControl(""),
      Date: new FormControl(""),
      Time: new FormControl(""),
      NumberOfPeople: new FormControl(""),
      OrderPlaced: new FormControl(""),
      SpecialRequests: new FormControl(""),
      CustomerId: new FormControl(""),
      firstName: new FormControl(""),
      lastName: new FormControl(""),
    })
  }

  reservationClick() {
    if (this.reservationForm.valid) {
      email: this.reservationForm.value.email;
      BookingId: 0;
      Date: this.reservationForm.value.Date;
      Time: this.reservationForm.value.time;
      NumberOfPeople: this.reservationForm.value.NumberOfPeople;
      OrderPlaced: false;
      SpecialRequests: this.reservationForm.value.SpecialRequests;
      CustomerId: 0;
      firstName: this.reservationForm.value.firstName;
      lastName: this.reservationForm.value.lastName;
      this.isSuccess = true;
    }
    else {
      alert("Something has went wrong")
    }
    // this.bookingService.reservation(this.bookingDto).subscribe(result => {
    //   console.log(result);
    //   if(this.isSuccess == true){
    //     this.router.navigate(['/'])
    //   }
    // })
  }
}
