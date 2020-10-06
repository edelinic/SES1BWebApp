import { Component, OnInit } from '@angular/core';
import {Title} from "@angular/platform-browser";
import { state } from 'src/app/model/state';


@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.scss']
})
export class HomeComponent implements OnInit {
  userName: string;


  constructor(private titleService:Title) {
    this.titleService.setTitle("eDine - Main Menu");
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
