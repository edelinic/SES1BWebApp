import { Component, OnInit } from '@angular/core';
import { Title } from '@angular/platform-browser';

@Component({
  selector: 'app-reservation',
  templateUrl: './reservation.component.html',
  styleUrls: ['./reservation.component.scss']
})
export class ReservationComponent implements OnInit {

  constructor(private titleService:Title) {
    this.titleService.setTitle("eDine - Book a Table");
   }

  ngOnInit(): void {
  }

}
