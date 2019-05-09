import { Component, OnInit } from '@angular/core';
import { City } from '../city-model/city';
import { CityService } from '../city-service/city-service';
import { CountryService } from 'src/app/country-management/service/country-service';
import { Country } from 'src/app/country-management/models/country';
import { ToastrService } from 'ngx-toastr';
import { UserService } from 'src/app/user/services/user.service';
import { ToastrHandler } from 'src/app/interceptors/toastrhandler';

@Component({
  selector: 'app-city-list',
  templateUrl: './city-list.component.html',
  styleUrls: ['./city-list.component.css']
})
export class CityListComponent implements OnInit {

  cities: City[];
  selectedCity: City;
  countries: Country[];
  isCountriesVisible = false;

  constructor(
    private cityService: CityService,
    private countryService: CountryService,
    private userService: UserService,
    private handler: ToastrHandler
  ) { }

  ngOnInit() {
    this.cityService.getCities().subscribe(c => {
      this.cities = c;
      this.countryService.getCountries().subscribe(c => this.countries = c);
    });
  }

  getCountriesToCities() {
    this.cities.forEach(element => {
      element.countryName = this.countries.find(c => c.countryId === element.countryId).countryName;
    });

    this.isCountriesVisible = true;
  }

  onDelete(id: number) {
    this.cityService.deleteCityById(id).subscribe(res => {
      this.handler.handle(res);
      this.cities = this.cities.filter(cs => cs.cityId !== id);
    });
  }

  hideCountries() {
    this.isCountriesVisible = false;
  }
}
