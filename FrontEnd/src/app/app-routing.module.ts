import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { HomeComponent } from './components/home/home.component';
import { LoginComponent } from './components/login/login.component';
import { RegistrationComponent } from './components/registration/registration.component';
import { ReservationComponent } from './components/reservation/reservation.component';
import { ReservationEditComponent } from './components/reservation-edit/reservation-edit.component';
import { LoyaltiesComponent } from './components/loyalties/loyalties.component';
import { ReservationViewComponent } from './components/reservation-view/reservation-view.component';
import { ReservationPreorderComponent } from './components/reservation-preorder/reservation-preorder.component';


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
    path: 'reservation/preorder',
    pathMatch: 'full',
    component:ReservationPreorderComponent
  },
  {
    path: 'reservation/view',
    pathMatch: 'full',
    component:ReservationViewComponent
  },
  {
    path: 'reservation/view/edit',
    pathMatch: 'full',
    component:ReservationEditComponent
  },
  {
    path: 'loyalties',
    pathMatch: 'full',
    component:LoyaltiesComponent
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
