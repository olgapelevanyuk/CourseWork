import { HttpClient, HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { BrowserModule } from '@angular/platform-browser';
import { AppRoutingModule } from 'src/app/app-routing.module';
import { AppComponent } from 'src/app/app.component';
import { CommonHeaderComponent } from './common-header/common-header.component';
import { CountryListComponent } from './country-management/lists/country-list/country-list.component';
import { CountryService } from './country-management/service/country-service';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { CountryFormComponent } from './country-management/form/country-form/country-form.component';
import { CityFormComponent } from './city-management/city-form/city-form.component';
import { CityListComponent } from './city-management/city-list/city-list.component';
import { CityService } from './city-management/city-service/city-service';
import { UserComponent } from './user/user.component';
import { RegistrationComponent } from './user/registration/registration.component';
import { UserService } from './user/services/user.service';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { ToastrModule } from 'ngx-toastr';
import { LoginComponent } from './user/login/login.component';
import { TokenInterceptor } from './interceptors/token.interceptor';
import { AirportFormComponent } from './airport-management/forms/airport-form/airport-form.component';
import { AirportListComponent } from './airport-management/lists/airport-list/airport-list.component';
import { TicketListComponent } from './tickets-management/list/ticket-list/ticket-list.component';
<<<<<<< HEAD
import { FlightFormComponent } from './flights/forms/flight-form/flight-form.component';
import { FlightListComponent } from './flights/list/flight-list/flight-list.component';
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
=======
>>>>>>> 0e15240... Strat buy-ticket impl
import { AlertModule } from 'ngx-bootstrap';
import { BsDatepickerModule } from 'ngx-bootstrap/datepicker';
import { AccordionModule } from 'ngx-bootstrap/accordion';
import { ButtonsModule } from 'ngx-bootstrap/buttons';
import { CarouselModule } from 'ngx-bootstrap/carousel';
import { CollapseModule } from 'ngx-bootstrap/collapse';
import { BsDropdownModule } from 'ngx-bootstrap/dropdown';
import { ModalModule } from 'ngx-bootstrap/modal';
import { PaginationModule } from 'ngx-bootstrap/pagination';
import { PopoverModule } from 'ngx-bootstrap/popover';
import { ProgressbarModule } from 'ngx-bootstrap/progressbar';
import { RatingModule } from 'ngx-bootstrap/rating';
import { SortableModule } from 'ngx-bootstrap/sortable';
import { TabsModule } from 'ngx-bootstrap/tabs';
import { TimepickerModule } from 'ngx-bootstrap/timepicker';
import { TooltipModule } from 'ngx-bootstrap/tooltip';
import { TypeaheadModule } from 'ngx-bootstrap/typeahead';
<<<<<<< HEAD
=======
import {MatButtonModule, MatCheckboxModule, MatDatepicker, MatDatepickerModule} from '@angular/material';
>>>>>>> 479f98c... fixed merge error
=======
>>>>>>> 0a4bd02... Revert "fixed merge error"
=======
import { MatDatepickerModule } from '@angular/material/datepicker';
import { MatNativeDateModule, MatRippleModule } from '@angular/material/core';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatButtonModule } from '@angular/material/button';
import { MatInputModule, MatInput } from '@angular/material/input'

>>>>>>> e67c15c... asd
=======
>>>>>>> 86ab3fe... Revert "asd"
=======
import { AdminComponent } from './admin/admin.component';
import { MatFormFieldModule, MatButtonModule, MatInputModule, MatRippleModule, MatTableModule, MatSortModule, MatSelectModule, MatToolbarModule, MatIconModule, MatMenuModule, MatProgressSpinnerModule, MatCardModule } from '@angular/material';
<<<<<<< HEAD
<<<<<<< HEAD
>>>>>>> c92b7f5... Implemented part of admin page
=======
import { StatisticsComponent } from './statistics/statistics.component';
import { ChartService } from './statistics/charts/chartservice.service';
<<<<<<< HEAD
>>>>>>> ebf55c7... Implemented statistics
=======
import { MainComponent } from './user/main/main.component';
import { ProfileComponent } from './user/profile/profile.component';
>>>>>>> 73f51e8... Ticket implementation
=======
import { StatisticsComponent } from './admin/statistics/statistics.component';
import { ChartService } from './admin/statistics/charts/chartservice.service';
import { MainComponent } from './user/main/main.component';
import { ProfileComponent } from './user/profile/profile.component';
import { FlightListComponent } from './flight-management/list/flight-list.component';
import { FlightFormComponent } from './flight-management/form/flight-form.component';
<<<<<<< HEAD
>>>>>>> 0e15240... Strat buy-ticket impl
=======
import { BuyTicketFormComponent } from './buy-ticket-form/buy-ticket-form.component';
<<<<<<< HEAD
>>>>>>> 8fc503e... Icoming finish
=======
import { ShowticketsComponent } from './user/showtickets/showtickets.component';
<<<<<<< HEAD
>>>>>>> 5f064e6... Finished course work
=======
import { ToastrHandler } from './interceptors/toastrhandler';
>>>>>>> 8fe1515... Finishing fixes

@NgModule({
  declarations: [
    AppComponent,
    CommonHeaderComponent,
    CountryListComponent,
    CountryFormComponent,
    CityFormComponent,
    CityListComponent,
    UserComponent,
    RegistrationComponent,
    LoginComponent,
    AirportFormComponent,
    AirportListComponent,
    TicketListComponent,
    FlightFormComponent,
    FlightListComponent,
    AdminComponent,
    StatisticsComponent,
    MainComponent,
    ProfileComponent,
    BuyTicketFormComponent,
    ShowticketsComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,
    HttpClientModule,
    AppRoutingModule,
    NgbModule,
    ReactiveFormsModule,
    ToastrModule.forRoot(
      { progressBar: true }
    ),
<<<<<<< HEAD
<<<<<<< HEAD
=======
    MatCardModule,
    MatProgressSpinnerModule,
    MatMenuModule,
    MatIconModule,
    MatToolbarModule,
    MatButtonModule,
    MatFormFieldModule,
    MatInputModule,
    MatSelectModule,
    MatSortModule,
    MatTableModule,
>>>>>>> c92b7f5... Implemented part of admin page
    BrowserAnimationsModule,
<<<<<<< HEAD
    AlertModule.forRoot(),
    BsDatepickerModule.forRoot(),
    AccordionModule.forRoot(),
    ButtonsModule.forRoot(),
    CarouselModule.forRoot(),
    CollapseModule.forRoot(),
    BsDropdownModule.forRoot(),
    ModalModule.forRoot(),
    PaginationModule.forRoot(),
    PopoverModule.forRoot(),
    ProgressbarModule.forRoot(),
    RatingModule.forRoot(),
    SortableModule.forRoot(),
    TabsModule.forRoot(),
    TimepickerModule.forRoot(),
    TooltipModule.forRoot(),
    TypeaheadModule.forRoot()
=======
    
>>>>>>> 479f98c... fixed merge error
=======
    BrowserAnimationsModule
>>>>>>> 0a4bd02... Revert "fixed merge error"
  ],
  providers: [
    CountryService,
    UserService,
    CityService,
    {
      provide: HTTP_INTERCEPTORS,
      useClass: TokenInterceptor,
      multi: true
    },
    ChartService,
    ToastrHandler
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
