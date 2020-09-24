import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HomeComponent } from './components/home/home.component';
import { LoginComponent } from './components/login/login.component';
import { RegistrationComponent } from './components/registration/registration.component';
import { ReservationComponent } from './components/reservation/reservation.component';
import { ReservationViewComponent } from './components/reservation-view/reservation-view.component';
import { ReservationPreorderComponent } from './components/reservation-preorder/reservation-preorder.component';
import { ReservationEditComponent } from './components/reservation-edit/reservation-edit.component';
import { LoyaltiesComponent } from './components/loyalties/loyalties.component';

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    LoginComponent,
    RegistrationComponent,
    ReservationComponent,
    ReservationViewComponent,
    ReservationEditComponent,
    ReservationPreorderComponent,
    LoyaltiesComponent,
  ],
  
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
