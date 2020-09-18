import { Component, OnInit } from '@angular/core';
import { Title } from '@angular/platform-browser';

@Component({
  selector: 'app-loyalties',
  templateUrl: './loyalties.component.html',
  styleUrls: ['./loyalties.component.scss']
})
export class LoyaltiesComponent implements OnInit {

  constructor(private titleService:Title) {
    this.titleService.setTitle("eDine - Loyalties");
   }

  ngOnInit(): void {
  }

}
