import { Component, OnInit } from '@angular/core';
<<<<<<< HEAD
=======
import { Title } from '@angular/platform-browser';
>>>>>>> 24f22fabac5c2351b1c1d55dfbd83bb0fb3abbc3

@Component({
  selector: 'app-reservation-preorder',
  templateUrl: './reservation-preorder.component.html',
  styleUrls: ['./reservation-preorder.component.scss']
})
export class ReservationPreorderComponent implements OnInit {

<<<<<<< HEAD
  constructor() { }
=======
  constructor(private titleService:Title) {
    this.titleService.setTitle("eDine - Pre Order Food");
   }
>>>>>>> 24f22fabac5c2351b1c1d55dfbd83bb0fb3abbc3

  ngOnInit(): void {
  }

}
