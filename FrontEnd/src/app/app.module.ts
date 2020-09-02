import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HomeComponent } from './components/home/home.component';
import { LoginComponent } from './components/login/login.component';
import { RegistrationComponent } from './components/registration/registration.component';
import { ReservationComponent } from './components/reservation/reservation.component';
import { ViewReservationComponent } from './components/view-reservation/view-reservation.component';
import { EditReservationComponent } from './components/edit-reservation/edit-reservation.component';
import { PreOrderReservationComponent } from './components/pre-order-reservation/pre-order-reservation.component';
import { ReservationViewComponent } from './components/reservation-view/reservation-view.component';
import { ReservationEditComponent } from './components/reservation-edit/reservation-edit.component';
import { ReservationPreorderComponent } from './components/reservation-preorder/reservation-preorder.component';
import { LoyaltiesComponent } from './components/loyalties/loyalties.component';

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    LoginComponent,
    RegistrationComponent,
    ReservationComponent,
    ViewReservationComponent,
    EditReservationComponent,
    PreOrderReservationComponent,
    ReservationViewComponent,
    ReservationEditComponent,
    ReservationPreorderComponent,
    LoyaltiesComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
