import { Component, OnInit } from '@angular/core';
import { Title } from '@angular/platform-browser';
import { state } from 'src/app/model/state';

@Component({
  selector: 'app-reservation-view',
  templateUrl: './reservation-view.component.html',
  styleUrls: ['./reservation-view.component.scss']
})
export class ReservationViewComponent implements OnInit {
  userName: string;
  userFirstName: string;
  userLastName: string;
  signedIn: boolean;

  constructor(private titleService:Title) {
    this.titleService.setTitle("eDine - My Reservations");
    if(state.userFirstName == null)
    {
      this.userName = "Not Logged in"
      this.signedIn = false;
    }
    else{
      this.userName = state.userFirstName + " " + state.userLastName;
      this.signedIn = true;
    }
   }

  ngOnInit(): void {
  }

}
