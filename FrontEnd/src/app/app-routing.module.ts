import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { HomeComponent } from './components/home/home.component';
import { LoginComponent } from './components/login/login.component';
import { RegistrationComponent } from './components/registration/registration.component';
import { ReservationComponent } from './components/reservation/reservation.component';
import { ReservationEditComponent } from './components/reservation-edit/reservation-edit.component';
<<<<<<< HEAD
<<<<<<< HEAD
=======
import { LoyaltiesComponent } from './components/loyalties/loyalties.component';
import { ReservationViewComponent } from './components/reservation-view/reservation-view.component';
import { ReservationPreorderComponent } from './components/reservation-preorder/reservation-preorder.component';
>>>>>>> 24f22fabac5c2351b1c1d55dfbd83bb0fb3abbc3
=======
import { LoyaltiesComponent } from './components/loyalties/loyalties.component';
import { ReservationViewComponent } from './components/reservation-view/reservation-view.component';
import { ReservationPreorderComponent } from './components/reservation-preorder/reservation-preorder.component';
>>>>>>> d0a6873c1d2e04e8b06afb33d0349cf0ed9abcc6


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
<<<<<<< HEAD
<<<<<<< HEAD
    path: 'reservation/edit',
=======
=======
>>>>>>> d0a6873c1d2e04e8b06afb33d0349cf0ed9abcc6
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
<<<<<<< HEAD
>>>>>>> 24f22fabac5c2351b1c1d55dfbd83bb0fb3abbc3
=======
>>>>>>> d0a6873c1d2e04e8b06afb33d0349cf0ed9abcc6
    pathMatch: 'full',
    component:ReservationEditComponent
  },
  {
<<<<<<< HEAD
<<<<<<< HEAD
=======
=======
>>>>>>> d0a6873c1d2e04e8b06afb33d0349cf0ed9abcc6
    path: 'loyalties',
    pathMatch: 'full',
    component:LoyaltiesComponent
  },
  {
<<<<<<< HEAD
>>>>>>> 24f22fabac5c2351b1c1d55dfbd83bb0fb3abbc3
=======
>>>>>>> d0a6873c1d2e04e8b06afb33d0349cf0ed9abcc6
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
