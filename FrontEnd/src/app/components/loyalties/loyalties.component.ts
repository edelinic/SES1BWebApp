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
  code1: string;
  code2: string;
  code3: string;
  possible = "ABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
  lengthOfCode = 15;

  makeRandom(lengthOfCode: number, possible: string) {
    let text = "";
    for (let i = 0; i < lengthOfCode; i++) {
      text += possible.charAt(Math.floor(Math.random() * possible.length));
    }
      return text;
  }

  generateCode1()
  {
    this.code1 = this.makeRandom(this.lengthOfCode, this.possible);
    
  }

  generateCode2()
  {
    this.code2 = this.makeRandom(this.lengthOfCode, this.possible);
    
  }

  generateCode3()
  {
    this.code3 = this.makeRandom(this.lengthOfCode, this.possible);
  }

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

      /* To copy Text from Textbox */
      copyInputMessage(inputElement){
        inputElement.select();
        document.execCommand('copy');
        inputElement.setSelectionRange(0, 0);
      }
   
  ngOnInit(): void {
  }


  
}

