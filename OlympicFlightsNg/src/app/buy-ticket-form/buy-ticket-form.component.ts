import { Component, OnInit } from '@angular/core';
import { Flight } from '../flight-management/models/flight';
import { FlightService } from '../flight-management/service/flight.service';
import { FormBuilder, Validators, FormGroup } from '@angular/forms';
import { BuyTicketFormModel } from './models/buy-ticket';
import { City } from '../city-management/city-model/city';
import { CityService } from '../city-management/city-service/city-service';
import { CountryService } from '../country-management/service/country-service';
import { Airport } from '../airport-management/models/airport';
import { AirportService } from '../airport-management/services/airport.service';
import { LViewFlags } from '@angular/core/src/render3/interfaces/view';
import { refreshDescendantViews } from '@angular/core/src/render3/instructions';
import { Client } from '../client-management/client';
import { ClientService } from '../client-management/client.service';
import { Ticket } from '../tickets-management/models/ticket';
import { TicketService } from '../tickets-management/service/ticket.service';
import { ToastrHandler } from '../interceptors/toastrhandler';
import { CustomServerResponse } from '../interceptors/serverresponse';

@Component({
  selector: 'app-buy-ticket-form',
  templateUrl: './buy-ticket-form.component.html',
  styleUrls: ['./buy-ticket-form.component.css']
})
export class BuyTicketFormComponent implements OnInit {

  ticketModel = this.formBuilder.group({
    depCity: null,
    arrCity: null,
    maxFlightPrice: null,
    minFlightPrice: null,
    arriveTime: null,
    arriveDate: null,
    departureDate: null,
    departureTime: null,
  });

  clientModel = this.formBuilder.group({
    firstName: null,
    lastName: null,
    address: null
  });

  constructor(private flightService: FlightService,
    private formBuilder: FormBuilder,
    private cityService: CityService,
    private cntryService: CountryService,
    private airportService: AirportService,
    private clientService: ClientService,
    private ticketService: TicketService,
    private handler: ToastrHandler) { }

  flights: Flight[];
  cities: City[];
  ismeridian: boolean = true;
  airports: Airport[];

  toggleMode(): void {
    this.ismeridian = !this.ismeridian;
  }

  ngOnInit() {
    this.onRefresh();
  }

  onRefresh() {
    this.cityService.getCities().subscribe(res => {
      this.cities = res;

      this.cntryService.getCountries().subscribe(res => {

        this.cities.forEach(c => {
          c.country = res.find(ct => ct.countryId === c.countryId);
        })

        this.flightService.getIncomingFlights().subscribe(res => {
          this.flights = res;

          this.airportService.getAirports().subscribe(res => {
            this.airports = res;

            this.airports.forEach(air => {
              air.city = this.cities.find(city => city.cityId == air.cityId);
            });

            this.flights.forEach(fl => {
              fl.arriveAirport = this.airports.find(airport => fl.arriveAirportId == airport.airportId);
              fl.departureAirport = this.airports.find(airport => fl.departureAirportId == airport.airportId);
            });
          });
        });
      });
    });
  }

  onApplyFilter() {

    var minPrice = this.ticketModel.value.minFlightPrice;
    var maxPrice = this.ticketModel.value.maxFlightPrice;
    var depDate = this.ticketModel.value.departureDate;
    var arrDate = this.ticketModel.value.arriveDate;
    var depCity = this.ticketModel.value.depCity;
    var arrCity = this.ticketModel.value.arrCity;


    if (minPrice !== null) {
      this.flights = this.flights.filter(fl => fl.flightPrice >= minPrice);
    }
    if (maxPrice !== null) {
      this.flights = this.flights.filter(fl => fl.flightPrice <= maxPrice);
    }

    if (depCity !== null) {
      this.flights = this.flights.filter(fl => fl.departureAirport.cityId == depCity.cityId);
    }

    if (arrCity !== null) {
      this.flights = this.flights.filter(fl => fl.arriveAirport.cityId == arrCity.cityId);
    }

    if (depDate !== null) {
      this.flights = this.flights.filter(fl => fl.departureTime.getTime() >= (depDate as Date).getTime());
    }
  }

  onBuyTicket(flightId: number) {

    var client = new Client(
      0,
      this.clientModel.value.firstName,
      this.clientModel.value.lastName,
      this.clientModel.value.address,
      false,
      localStorage.getItem('userId'));


    this.clientService.addClient(client).subscribe(res => {
      var ticket = new Ticket(0, res.clientId, false, false, new Date());
    
      ticket.flightId = flightId;
    
      this.ticketService.createTicket(ticket).subscribe((res) => {
        this.handler.handle(res);
      });
    })
  }
}
