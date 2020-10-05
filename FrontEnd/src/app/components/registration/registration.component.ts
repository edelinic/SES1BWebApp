import { Component, OnInit } from '@angular/core';
import { Title } from '@angular/platform-browser';
import { FormGroup, FormControl, Validators } from '@angular/forms';
import { UserService } from 'src/app/core/user/user.service';
import { Router } from '@angular/router';
import { userDto } from 'src/app/model/userDto';

@Component({
  selector: 'app-registration',
  templateUrl: './registration.component.html',
  styleUrls: ['./registration.component.scss']
})
export class RegistrationComponent implements OnInit {
  userDto: userDto;
  messages: string[];
  registrationForm: FormGroup;
  buttonClicked: boolean = false;


  constructor(private titleService:Title,
              private userService: UserService,
              private router: Router) {
    this.titleService.setTitle("eDine - Register");
   }

  ngOnInit(): void {
    this.registrationForm = new FormGroup({
      firstName: new FormControl(""),
      lastName: new FormControl(""),
      email: new FormControl(""),
      password: new FormControl("", Validators.required),
      dob: new FormControl("", Validators.required),
      phoneNumber: new FormControl("", Validators.required),
    })
  }

  RegistrationClick() {
    if (this.registrationForm.valid) {
      this.userDto = {
        userId: 0,
        firstName: this.registrationForm.value.firstName,
        lastName: this.registrationForm.value.lastName,
        email: this.registrationForm.value.email,
        password: this.registrationForm.value.password,
        dob: this.registrationForm.value.dob,
        phoneNumber: this.registrationForm.value.phoneNumber,
        loyaltyMemberNumber: "",
        token: "",
        messages: [],
        isSuccess: true,
      }
      this.userService.registration(this.userDto).subscribe(result => {
        console.log(result);
        if (result.isSuccess == true) {
          this.router.navigate(['/'])
        }
        else {
          this.messages = result.messages;
          this.buttonClicked = false;
          alert("Registration Unsuccessful");
        }
      });
      this.buttonClicked = true;
    }

    else {
      alert("Something has went wrong")
    }
  }
}
