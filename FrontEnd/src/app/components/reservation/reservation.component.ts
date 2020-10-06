import { Component, OnInit } from '@angular/core';
import { Title } from '@angular/platform-browser';
import { state } from 'src/app/model/state';

@Component({
  selector: 'app-reservation',
  templateUrl: './reservation.component.html',
  styleUrls: ['./reservation.component.scss']
})
export class ReservationComponent implements OnInit {
  userFirstName: string;
  userLastName: string;
  userName: string;

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
    }
    else{
      this.userFirstName = state.userFirstName;
      this.userLastName = state.userLastName;
    }  
   }

  ngOnInit(): void {
  }

}
