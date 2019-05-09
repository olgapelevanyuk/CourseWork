import { Component, OnInit } from '@angular/core';
import { AirportService } from 'src/app/airport-management/services/airport.service';
import { FormBuilder, Validators } from '@angular/forms';
import { Airport } from 'src/app/airport-management/models/airport';
import { Flight } from '../models/flight';
import { FlightService } from '../service/flight.service';
import { DATE } from 'ngx-bootstrap/chronos/units/constants';
import { HttpResponse } from '@angular/common/http';
import { ToastrService } from 'ngx-toastr';
import { Router, ActivatedRoute } from '@angular/router';
import { ToastrHandler } from 'src/app/interceptors/toastrhandler';

@Component({
  selector: 'app-flight-form',
  templateUrl: './flight-form.component.html',
  styleUrls: ['./flight-form.component.css']
})
export class FlightFormComponent implements OnInit {

  constructor(
    private airportService: AirportService,
    private flightService: FlightService,
    private formBuilder: FormBuilder,
    private router: Router,
    private route: ActivatedRoute,
    private handler: ToastrHandler
  ) { }

  airports: Airport[];
  ismeridian: boolean = true;
  existed: boolean = false;
  flightId: number;

  flightModel = this.formBuilder.group({
    arriveTime: [new Date(), [Validators.required]],
    arriveDate: [new Date(), [Validators.required]],
    arriveAirportId: ['', [Validators.required]],
    departureDate: [new Date(), [Validators.required]],
    departureTime: [new Date(), [Validators.required]],
    departureAirportId: ['', [Validators.required]],
    flightPrice: ['', [Validators.required]]
  });

  ngOnInit() {
    this.route.params.subscribe(p => {
      if (!(p.id === undefined)) {
        this.flightId = p.id;
        this.airportService.getAirports().subscribe(res => this.airports = res);
        this.existed = true;

        this.flightService.getFlightById(this.flightId).subscribe(f => {
          this.flightModel.get('arriveAirportId').setValue(f.arriveAirportId);
          this.flightModel.get('departureAirportId').setValue(f.departureAirportId);
          this.flightModel.get('flightPrice').setValue(f.flightPrice);
        });
      }
      else {
        this.airportService.getAirports().subscribe(res => this.airports = res);
      }
    });
  }
  toggleMode(): void {
    this.ismeridian = !this.ismeridian;
  }
  onSubmit() {

    if (this.existed) {
      var arriveDate = new Date();
      arriveDate.setDate(this.flightModel.value.arriveDate.getDate());
      arriveDate.setHours(this.flightModel.value.arriveTime.getHours(), this.flightModel.value.arriveTime.getMinutes())

      var departureDate = new Date();
      departureDate.setDate(this.flightModel.value.departureDate.getDate());
      departureDate.setHours(this.flightModel.value.departureTime.getHours(), this.flightModel.value.departureTime.getMinutes())

      const updatedFlight = new Flight(
        this.flightId,
        arriveDate.toDateString(),
        departureDate.toDateString(),
        this.flightModel.value.arriveAirportId,
        this.flightModel.value.departureAirportId,
        this.flightModel.value.flightPrice,
        false
      );

      this.flightService.updateFlightById(updatedFlight.flightId, updatedFlight).subscribe(res => {

        this.handler.handle(res);
        this.navigateToFlights();
      });
    }
    else {
      var arriveDate = new Date();
      arriveDate.setDate(this.flightModel.value.arriveDate.getDate());
      arriveDate.setHours(this.flightModel.value.arriveTime.getHours(), this.flightModel.value.arriveTime.getMinutes())

      var departureDate = new Date();
      departureDate.setDate(this.flightModel.value.departureDate.getDate());
      departureDate.setHours(this.flightModel.value.departureTime.getHours(), this.flightModel.value.departureTime.getMinutes())

      const createdFlight = new Flight(
        0,
        arriveDate.toDateString(),
        departureDate.toDateString(),
        this.flightModel.value.arriveAirportId,
        this.flightModel.value.departureAirportId,
        this.flightModel.value.flightPrice,
        false
      );

      this.flightService.createFlight(createdFlight).subscribe(res => {
        this.handler.handle(res);
        this.navigateToFlights();
      });
    }
  }

  navigateToFlights() {
    this.router.navigateByUrl("/flights");
  }
}
