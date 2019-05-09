import { Component, OnInit, ViewChild } from '@angular/core';
import { MatTableDataSource, MatSort } from '@angular/material';
import { Ticket } from 'src/app/tickets-management/models/ticket';
import { TicketService } from 'src/app/tickets-management/service/ticket.service';
import { ToastrService } from 'ngx-toastr';
import { Router, ActivatedRoute } from '@angular/router';
import { ClientService } from 'src/app/client-management/client.service';
import { UserService } from '../services/user.service';
import * as jsPDF from 'jspdf';
import { FlightService } from 'src/app/flight-management/service/flight.service';
import { Client } from 'src/app/client-management/client';
import { Flight } from 'src/app/flight-management/models/flight';
import { CountryService } from 'src/app/country-management/service/country-service';
import { CityService } from 'src/app/city-management/city-service/city-service';
import { AirportService } from 'src/app/airport-management/services/airport.service';

@Component({
  selector: 'app-showtickets',
  templateUrl: './showtickets.component.html',
  styleUrls: ['./showtickets.component.css']
})
export class ShowticketsComponent implements OnInit {

  displayedColumns: string[];
  dataSource: MatTableDataSource<Ticket>;
  tickets: Ticket[];


  constructor(private ticketService: TicketService,
    private toastr: ToastrService,
    private route: Router,
    private router: ActivatedRoute,
    private clientService: ClientService,
    private userService: UserService,
    private flightService: FlightService,
    private countryService: CountryService,
    private cityService: CityService,
    private airportService: AirportService
  ) { }

  @ViewChild(MatSort) sort: MatSort;


  applyFilter(filterValue: string) {
    this.dataSource.filter = filterValue.trim().toLowerCase();
  }

  ngOnInit() {
    this.ticketService.getTicketsByUserId().subscribe(res => {

      this.tickets = res;
      this.clientService.getClients().subscribe(cls => {
        this.tickets.forEach(t => t.client = cls.find(cl => cl.clientId == t.clientId));
      })
      this.displayedColumns = ['ticketId', 'clientId', 'flightId', 'created', 'actions'];
      this.dataSource = new MatTableDataSource(res);
      this.dataSource.sort = this.sort;
    });
  }

  onPrintPdf(ticketId: number) {
    var doc = new jsPDF('landscape');
    var ticket = this.tickets.find(t => t.ticketId == ticketId);
    var client: Client;
    var flight: Flight;

    this.flightService.getFlightById(ticket.flightId).subscribe(res => {
      flight = res;
      this.clientService.getClientsById(ticket.clientId).subscribe(res => {
        client = res;
        this.airportService.getAirports().subscribe(res => {

          flight.arriveAirport = res.find(ar => ar.airportId == flight.arriveAirportId);
          flight.departureAirport = res.find(ar => ar.airportId == flight.departureAirportId);

          this.cityService.getCities().subscribe(res => {
            flight.arriveAirport.city = res.find(city => city.cityId == flight.arriveAirport.cityId);
            flight.departureAirport.city = res.find(city => city.cityId == flight.departureAirport.cityId);

            this.countryService.getCountries().subscribe(res => {

              flight.arriveAirport.city.country = res.find(c => c.countryId == flight.arriveAirport.city.countryId);
              flight.departureAirport.city.country = res.find(c => c.countryId == flight.arriveAirport.city.countryId);

            })
            doc.setFontSize(20);

            doc.text(`Ticket number : ${ticketId}`, 5, 20);
            doc.setLineWidth(1);
            doc.line(5, 21, 50, 21);
            doc.text(`Client info`, 5, 40)
            doc.line(5, 41 , 38, 41);
            doc.text(`Firstname : ${client.clientFirstname} ; Lastname : ${client.clientLastname}; Address : ${client.clientAddress}`, 5, 51)
            doc.text(`Flight info`, 5, 61);
            doc.line(5, 63 , 38, 63);
            doc.text(`Flight Number : ${flight.flightId}`, 5, 75);
            doc.text(`Departure date : ${flight.departureTime}`, 5, 95);
            doc.text(`Airport : ${flight.departureAirport.airportName} (${flight.departureAirport.airportCode})`,5, 105)
            doc.text(`City : ${flight.departureAirport.city.cityName}`,5, 115);
            doc.text(`Arrive date : ${flight.arriveTime}`, 156, 95);
            doc.text(`Airport : ${flight.arriveAirport.airportName} (${flight.arriveAirport.airportCode})`, 156, 105)
            doc.text(`City : ${flight.arriveAirport.city.cityName}`, 156, 115);
            doc.text(`PRICE : ${flight.flightPrice}`, 5, 180);
            doc.text(`PURCHASE DATE: ${ticket.created}`, 5, 200);
            doc.save(`TICKET_${ticket.ticketId}`);
          });
        });
      });
    });
  }
}
