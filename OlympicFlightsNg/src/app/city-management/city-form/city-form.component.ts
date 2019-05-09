import { Component, OnInit } from '@angular/core';
import { CityService } from '../city-service/city-service';
import { City } from '../city-model/city';
import { CountryService } from 'src/app/country-management/service/country-service';
import { ActivatedRoute, Router } from '@angular/router';
import { Country } from 'src/app/country-management/models/country';
import { ToastrHandler } from 'src/app/interceptors/toastrhandler';

@Component({
  selector: 'app-city-form',
  templateUrl: './city-form.component.html',
  styleUrls: ['./city-form.component.css']
})
export class CityFormComponent implements OnInit {

  countries: Country[];
  selectedCity = new City(0, 0, '', '');
  existed = false;

  constructor(
    private cityService: CityService,
    private countryService: CountryService,
    private route: ActivatedRoute,
    private router: Router,
    private handler: ToastrHandler) { }

  ngOnInit() {
    this.route.params.subscribe(p => {
      if (!(p.id === undefined)) {
        this.existed = true;
        this.cityService.getCityById(p.id)
          .subscribe(c => this.selectedCity = c,
            null,
            () => {
              this.countryService.getCountries()
              .subscribe(c => this.countries = c,
                null,
                () => {
                  return this.selectedCity.countryName = this.countries.find(cs => cs.countryId === this.selectedCity.countryId).countryName;
                });
            });
      } else {
        this.countryService.getCountries().subscribe(c => this.countries = c);
      }
    });
  }

  onSubmit() {
    if (this.existed) {
      this.cityService.updateCityById(this.selectedCity.cityId, this.selectedCity).subscribe(res => { 
        this.handler.handle(res);
        this.navigateToCities(); });
    } else {
      this.cityService.createCity(this.selectedCity).subscribe(res => { 
        this.handler.handle(res);
        this.navigateToCities(); });
    }
  }

  navigateToCities(){
    this.router.navigate(['/cities']);
  }
}
