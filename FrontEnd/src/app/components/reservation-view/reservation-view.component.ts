import { Component, OnInit } from '@angular/core';
import { Title } from '@angular/platform-browser';

@Component({
  selector: 'app-reservation-view',
  templateUrl: './reservation-view.component.html',
  styleUrls: ['./reservation-view.component.scss']
})
export class ReservationViewComponent implements OnInit {

  constructor(private titleService:Title) {
    this.titleService.setTitle("eDine - My Reservations");
   }

  ngOnInit(): void {
  }

}
