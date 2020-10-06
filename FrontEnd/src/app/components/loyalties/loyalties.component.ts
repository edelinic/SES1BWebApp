import { Component, OnInit } from '@angular/core';
import { Title } from '@angular/platform-browser';
import { state } from 'src/app/model/state';

@Component({
  selector: 'app-loyalties',
  templateUrl: './loyalties.component.html',
  styleUrls: ['./loyalties.component.scss']
})
export class LoyaltiesComponent implements OnInit {
  userName: string;

  constructor(private titleService:Title) {
    this.titleService.setTitle("eDine - Loyalties");
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
