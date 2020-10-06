import { Component, OnInit } from '@angular/core';
import { Title } from '@angular/platform-browser';
import { UserService } from 'src/app/core/user/user.service';
import { FormGroup, FormControl, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { state } from 'src/app/model/state';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.scss']
})
export class LoginComponent implements OnInit {
  email: string;
  password: string;
  loginForm: FormGroup;
  buttonClicked : boolean = false; 
  userName: string;

  constructor(private titleService:Title,
              private userService: UserService,
              private router : Router) {
    this.titleService.setTitle("eDine - Login");
    if(state.userFirstName == null)
    {
      this.userName = "Not Logged in"
    }
    else{
      this.userName = state.userFirstName + " " + state.userLastName;
    }
   }

  ngOnInit() {
    this.loginForm = new FormGroup({
      email: new FormControl(this.email, Validators.email),
      password: new FormControl(this.password, Validators.required)
    })
  }

  loginInClick(){
    if(this.loginForm.valid){
      this.userService.login(this.loginForm.value.email, this.loginForm.value.password).subscribe(result => {
        console.log(result);
        if(result.isSuccess == true){
          state.userId = result.userId;
          state.userFirstName = result.firstName;
          state.userLastName = result.lastName;
          this.router.navigate(['/']);
        }
        else{
          this.buttonClicked = false;
          alert("Invalid username or password");
        }
      });
      this.buttonClicked = true;
    }
    else{
      alert("Please input email and password")
    }
  }

}
