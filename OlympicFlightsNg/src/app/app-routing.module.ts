import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { CountryListComponent } from '../app/country-management/lists/country-list/country-list.component';
import { CountryFormComponent } from './country-management/form/country-form/country-form.component';
import { CityFormComponent } from './city-management/city-form/city-form.component';
import { CityListComponent } from './city-management/city-list/city-list.component';
import { UserComponent } from './user/user.component';
import { RegistrationComponent } from './user/registration/registration.component';
import { LoginComponent } from './user/login/login.component';
import { AuthGuard } from './interceptors/auth.guard';
import { AirportListComponent } from './airport-management/lists/airport-list/airport-list.component';
import { AirportFormComponent } from './airport-management/forms/airport-form/airport-form.component';
import { TicketListComponent } from './tickets-management/list/ticket-list/ticket-list.component';
import { AdminComponent } from './admin/admin.component';
import { StatisticsComponent } from './admin/statistics/statistics.component';
import { MainComponent } from './user/main/main.component';
import { ProfileComponent } from './user/profile/profile.component';
import { AdminGuard } from './interceptors/admin.guard';
import { FlightListComponent } from './flight-management/list/flight-list.component';
import { FlightFormComponent } from './flight-management/form/flight-form.component';
import { BuyTicketFormComponent } from './buy-ticket-form/buy-ticket-form.component';
import { ShowticketsComponent } from './user/showtickets/showtickets.component';

const routes: Routes = [
  { path: '', redirectTo: 'user/signin', pathMatch: 'full' },
  { path: 'home', redirectTo: 'admin', pathMatch: 'full', canActivate: [AuthGuard]},
  {
    path: 'countries', component: CountryListComponent, canActivate: [AuthGuard],
    children: [
      { path: ':countryId/cities', component: CityListComponent , canActivate: [AuthGuard]},
    ]
  },
  {
    path: 'airports', component: AirportListComponent, canActivate: [AuthGuard]
  },
  {
    path: 'airport/:id', component: AirportFormComponent, canActivate: [AuthGuard,AdminGuard]
  },
  {
    path: 'airport', component: AirportFormComponent, canActivate: [AuthGuard,AdminGuard]
  },
  { path: 'country/:id', component: CountryFormComponent, canActivate: [AuthGuard,AdminGuard] },
  { path: 'country', component: CountryFormComponent, canActivate: [AuthGuard,AdminGuard] },
  { path: 'cities', component: CityListComponent ,canActivate: [AuthGuard]},
  { path: 'countries/:countryId/cities', component: CityListComponent, canActivate: [AuthGuard] },
  { path: 'city/:id', component: CityFormComponent, canActivate: [AuthGuard,AdminGuard]},
  { path: 'city', component: CityFormComponent, canActivate: [AuthGuard,AdminGuard]},

  {path : 'user/signup',component: RegistrationComponent},
  {path : 'user/signin',component: LoginComponent},
  {path : 'user/main',component: MainComponent, canActivate: [AuthGuard]},
  {path : 'user/buyticket',component: BuyTicketFormComponent, canActivate: [AuthGuard]},
  {path : 'user/tickets',component: ShowticketsComponent, canActivate: [AuthGuard]},
  {
    path: 'user', component: UserComponent, canActivate: [AuthGuard]
  },
  { path: 'tickets', component: TicketListComponent, canActivate: [AuthGuard] },
  {
    path: 'flights', component: FlightListComponent, canActivate: [AuthGuard]
  },
  {
    path: 'flight', component: FlightFormComponent, canActivate: [AuthGuard,AdminGuard]
  },
  {
    path: 'flights/:id', component: FlightFormComponent
  },
  {
    path: 'admin', component: AdminComponent, canActivate: [AuthGuard,AdminGuard]
  },
  {
    path: 'user/profile', component: ProfileComponent,canActivate : [AuthGuard]
  },
  {
    path: 'admin/statistics', component: StatisticsComponent,canActivate: [AuthGuard,AdminGuard]
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes,{onSameUrlNavigation: 'reload'})],
  exports: [RouterModule]
})
export class AppRoutingModule { }
