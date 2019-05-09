import { Component, OnInit } from '@angular/core';
import { City } from 'src/app/city-management/city-model/city';
import { Airport } from '../../models/airport';
import { AirportService } from '../../services/airport.service';
import { CityService } from 'src/app/city-management/city-service/city-service';
import { ActivatedRoute, Router } from '@angular/router';
import { ToastrService } from 'ngx-toastr';
import { ToastrHandler } from 'src/app/interceptors/toastrhandler';

@Component({
  selector: 'app-airport-form',
  templateUrl: './airport-form.component.html',
  styleUrls: ['./airport-form.component.css']
})
export class AirportFormComponent implements OnInit {

  cities: City[];
  airport = new Airport(0, '', '', 0, false, '');
  existed = false;

  constructor(
    private toastr: ToastrService,
    private airportService: AirportService,
    private cityService: CityService,
    private route: ActivatedRoute,
    private router: Router,
    private handler: ToastrHandler) { }

  ngOnInit() {
    this.route.params.subscribe(p => {
      if (!(p.id === undefined)) {
        this.existed = true;
        this.airportService.getAirportById(p.id)
          .subscribe(a => this.airport = a,
            null,
            () => {
              this.cityService.getCities()
                .subscribe(c => this.cities = c,
                    null,
                    () => {
                      return this.airport.cityName = this.cities.find(c => c.cityId === this.airport.cityId).cityName;
                    });
            });
      } else {
        this.cityService.getCities().subscribe(c => this.cities = c);
      }
    });
  }

  onSubmit() {
    if (this.existed) {
      this.airportService.updateAirportById(this.airport.airportId, this.airport).subscribe(res => {
        this.handler.handle(res);
        this.navigateToAirports();
      });
    } else {
      this.airportService.createAirport(this.airport).subscribe(res => {
        this.handler.handle(res);
        this.navigateToAirports();
      }); 
    }
  }

  navigateToAirports() {
    this.router.navigateByUrl('/airports');
  }

}
