import { Component, OnInit } from '@angular/core';
<<<<<<< HEAD
<<<<<<< HEAD
=======
import { Title } from '@angular/platform-browser';
>>>>>>> 24f22fabac5c2351b1c1d55dfbd83bb0fb3abbc3
=======
import { Title } from '@angular/platform-browser';
>>>>>>> d0a6873c1d2e04e8b06afb33d0349cf0ed9abcc6

@Component({
  selector: 'app-registration',
  templateUrl: './registration.component.html',
  styleUrls: ['./registration.component.scss']
})
export class RegistrationComponent implements OnInit {

<<<<<<< HEAD
<<<<<<< HEAD
  constructor() { }
=======
  constructor(private titleService:Title) {
    this.titleService.setTitle("eDine - Register");
   }
>>>>>>> 24f22fabac5c2351b1c1d55dfbd83bb0fb3abbc3
=======
  constructor(private titleService:Title) {
    this.titleService.setTitle("eDine - Register");
   }
>>>>>>> d0a6873c1d2e04e8b06afb33d0349cf0ed9abcc6

  ngOnInit(): void {
  }

}
