import { Component, OnInit } from '@angular/core';
import { Title } from '@angular/platform-browser';
import { state } from 'src/app/model/state';

@Component({
  selector: 'app-reservation-preorder',
  templateUrl: './reservation-preorder.component.html',
  styleUrls: ['./reservation-preorder.component.scss']
})
export class ReservationPreorderComponent implements OnInit {
  userName: string;
  constructor(private titleService:Title) {
    this.titleService.setTitle("eDine - Pre Order Food");
    if(state.userFirstName == null)
    {
      this.userName = "Not Logged in"
    }
    else{
      this.userName = state.userFirstName + " " + state.userLastName;
    }
   }

  ngOnInit(): void {
  }

}
