import { Component, OnInit } from '@angular/core';
import { Title } from '@angular/platform-browser';

@Component({
  selector: 'app-reservation-edit',
  templateUrl: './reservation-edit.component.html',
  styleUrls: ['./reservation-edit.component.scss']
})
export class ReservationEditComponent implements OnInit {

  constructor(private titleService:Title) {
    this.titleService.setTitle("eDine - Edit Reservations");
   }

  ngOnInit(): void {
  }

}
