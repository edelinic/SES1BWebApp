import { Component, OnInit } from '@angular/core';
import { Title } from '@angular/platform-browser';
import { state } from 'src/app/model/state';

@Component({
  selector: 'app-reservation-edit',
  templateUrl: './reservation-edit.component.html',
  styleUrls: ['./reservation-edit.component.scss']
})
export class ReservationEditComponent implements OnInit {
  userName: string;
  userFirstName: string;
  userLastName: string;
  signedIn: boolean;
  constructor(private titleService:Title) {
    this.titleService.setTitle("eDine - Edit Reservations");
 
    if(state.userFirstName == null)
    {
      this.userName = "Not Logged in"
      this.signedIn = false;
    }
    else{
      this.userName = state.userFirstName + " " + state.userLastName;
      this.userFirstName = state.userFirstName;
      this.userLastName = state.userLastName;
      this.signedIn = true;
    }
   }

  ngOnInit(): void {
  }

}
