import { Component, OnInit } from '@angular/core';
import { FlightService } from '../service/flight.service';
import { Flight } from '../models/flight';
import { UserService } from 'src/app/user/services/user.service';
import { ToastrHandler } from 'src/app/interceptors/toastrhandler';

@Component({
  selector: 'app-flight-list',
  templateUrl: './flight-list.component.html',
  styleUrls: ['./flight-list.component.css']
})
export class FlightListComponent implements OnInit {

  flights: Flight[];

  constructor(private flightService: FlightService,
              private userService: UserService,
              private handler: ToastrHandler) { }

  ngOnInit() {
    this.flightService.getFlights().subscribe(response => {
      this.flights = response;
    });
  }

  // onDelete(flightId: number) {
  //   this.flightService.setFlightStatusById(flightId, true).subscribe(res => {
  //     this.flights.find(fl => fl.flightId === flightId).isDeleted = true;
  //   });
  // }

  // onRestore(flightId: number) {
  //   this.flightService.setFlightStatusById(flightId, false).subscribe(res => {
  //     this.flights.find(fl => fl.flightId === flightId).isDeleted = false;
  //   });
  // }

  onDelete(flightId: number) {
    this.flightService.deleteFlightById(flightId).subscribe(res => {
      this.handler.handle(res);
      this.flights = this.flights.filter(fl => fl.flightId !== flightId);
    });
  }
}
