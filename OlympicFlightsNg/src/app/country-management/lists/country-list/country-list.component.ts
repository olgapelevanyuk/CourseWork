import { Component, OnInit } from '@angular/core';
import { CountryService } from 'src/app/country-management/service/country-service';
import { Country } from '../../models/country';
import { UserService } from 'src/app/user/services/user.service';
import { ToastrHandler } from 'src/app/interceptors/toastrhandler';

@Component({
  selector: 'app-country-list',
  templateUrl: './country-list.component.html',
  styleUrls: ['./country-list.component.css']
})
export class CountryListComponent implements OnInit {
  selectedCountry: Country;
  countries: Country[];

  constructor(
    private countryService: CountryService,
    private userService: UserService,
    private handler: ToastrHandler
  ) { }

  ngOnInit() {
    this.countryService.getCountries().subscribe(res => {
      this.countries = res;
    })
  }

  onDelete(id: number): void {
    this.countryService.deleteCountry(id).subscribe(res => {
      this.handler.handle(res);
      this.countries = this.countries.filter(c => c.countryId != id);
    });
  }
}
