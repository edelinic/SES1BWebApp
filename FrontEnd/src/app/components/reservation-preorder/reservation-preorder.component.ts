import { Component, OnInit } from '@angular/core';
import { Title } from '@angular/platform-browser';

@Component({
  selector: 'app-reservation-preorder',
  templateUrl: './reservation-preorder.component.html',
  styleUrls: ['./reservation-preorder.component.scss']
})
export class ReservationPreorderComponent implements OnInit {

  constructor(private titleService:Title) {
    this.titleService.setTitle("eDine - Pre Order Food");
   }

  ngOnInit(): void {
  }

}
