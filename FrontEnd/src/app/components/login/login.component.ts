import { Component, OnInit } from '@angular/core';
import { Title } from '@angular/platform-browser';
import { UserService } from 'src/app/core/user/user.service';
import { FormGroup, FormControl, Validators } from '@angular/forms';
import { Router } from '@angular/router';

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

  constructor(private titleService:Title,
              private userService: UserService,
              private router : Router) {
    this.titleService.setTitle("eDine - Login");
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
          this.router.navigate(['/'])
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
