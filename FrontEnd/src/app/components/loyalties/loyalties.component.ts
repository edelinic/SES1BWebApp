import { Component, OnInit } from '@angular/core';
<<<<<<< HEAD
=======
import { Title } from '@angular/platform-browser';
>>>>>>> 24f22fabac5c2351b1c1d55dfbd83bb0fb3abbc3

@Component({
  selector: 'app-loyalties',
  templateUrl: './loyalties.component.html',
  styleUrls: ['./loyalties.component.scss']
})
export class LoyaltiesComponent implements OnInit {

<<<<<<< HEAD
  constructor() { }
=======
  constructor(private titleService:Title) {
    this.titleService.setTitle("eDine - Loyalties");
   }
>>>>>>> 24f22fabac5c2351b1c1d55dfbd83bb0fb3abbc3

  ngOnInit(): void {
  }

}
