import { Component, OnInit, ViewChild } from '@angular/core';
import { AirportService } from '../../services/airport.service';
import { Airport } from '../../models/airport';
import { Router, ActivatedRoute } from '@angular/router';
import { CityService } from 'src/app/city-management/city-service/city-service';
import { ToastrService } from 'ngx-toastr';
import { MatTableDataSource, MatSort } from '@angular/material';
import { UserService } from 'src/app/user/services/user.service';
import { ToastrHandler } from 'src/app/interceptors/toastrhandler';

@Component({
  selector: 'app-airport-list',
  templateUrl: './airport-list.component.html',
  styleUrls: ['./airport-list.component.css']
})
export class AirportListComponent implements OnInit {

  airports: Airport[];
  areCitiesShown = false;
  displayedColumns: string[];
  dataSource: MatTableDataSource<Airport>;

  @ViewChild(MatSort) sort: MatSort;


  applyFilter(filterValue: string) {
    this.dataSource.filter = filterValue.trim().toLowerCase();
  }
  constructor(
    private airportService: AirportService,
    private cityService: CityService,
    private route: Router,
    private router:ActivatedRoute,
    private userService: UserService,
    private handler: ToastrHandler) { }

  ngOnInit() {
    this.airportService.getAirports().subscribe(res => {
      this.airports = res;
      this.airports.forEach(element => {
        this.cityService.getCityById(element.cityId).subscribe(c => element.cityName = c.cityName);
      });
  
      if(this.userService.isUserAdmin()){
      this.displayedColumns = ['airportId', 'airportName', 'airportCode', 'cityName','actions'];
      }
      else{
      this.displayedColumns = ['airportId', 'airportName', 'airportCode', 'cityName'];
      }
      this.dataSource = new MatTableDataSource(this.airports);
      this.dataSource.sort = this.sort;
  });
  }

  onDelete(airportId: number, isDeleted: boolean) {
    this.airportService.deleteAirportById(airportId).subscribe(res =>{
      this.handler.handle(res);
      this.dataSource.data = this.dataSource.data.filter(a => a.airportId !== airportId)});
  }

  getCitiesToAirports() {
    this.areCitiesShown = true;
  }

  hideCities(){
    this.areCitiesShown = false;
  }
}
