import { Component, OnInit } from '@angular/core';
import { Title } from '@angular/platform-browser';
import { state } from 'src/app/model/state';

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
  today=new Date();
  
  constructor(private titleService:Title) {
    this.titleService.setTitle("eDine - Book a Table");
    if(state.userFirstName == null)
    {
      this.userName = "Not Logged in"
    }
    else{
      this.userName = state.userFirstName + " " + state.userLastName;
    }
    
    if(state.userFirstName == null || state.userLastName == null)
    {
      this.userFirstName = "N/A"
      this.userLastName = "N/A"
      this.userEmail = "N/A"
      this.userPhone = "N/A"
      this.signedIn = false;
    }
    else{
      this.userFirstName = state.userFirstName;
      this.userLastName = state.userLastName;
      this.userEmail = state.userEmail;
      this.userPhone = state.userPhone;
      this.signedIn = true;
    }  
   }

  ngOnInit(): void {
  }

}
