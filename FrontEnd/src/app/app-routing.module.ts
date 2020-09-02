import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { HomeComponent } from './components/home/home.component';
import { LoginComponent } from './components/login/login.component';
import { RegistrationComponent } from './components/registration/registration.component';
import { ReservationComponent } from './components/reservation/reservation.component';
import { ReservationEditComponent } from './components/reservation-edit/reservation-edit.component';


const routes: Routes = [
  
  {
    path: 'login',
    pathMatch: 'full',
    component:LoginComponent
  },
  {
    path: 'registration',
    pathMatch: 'full',
    component:RegistrationComponent
  },
  {
    path: 'reservation',
    pathMatch: 'full',
    component:ReservationComponent
  },
  {
    path: 'reservation/edit',
    pathMatch: 'full',
    component:ReservationEditComponent
  },
  {
    path: '',
    pathMatch: 'full',
    component: HomeComponent
  }
  
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})


export class AppRoutingModule { }
