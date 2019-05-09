import { Component, OnInit } from '@angular/core';
import {FormControl} from '@angular/forms';
import { Country } from '../../models/country';
import { CountryService } from '../../service/country-service';
import { ActivatedRoute, Router } from '@angular/router';
import { ToastrHandler } from 'src/app/interceptors/toastrhandler';

@Component({
  selector: 'app-country-form',
  templateUrl: './country-form.component.html',
  styleUrls: ['./country-form.component.css']
})
export class CountryFormComponent implements OnInit {

  public country = new Country(0, '');
  public existed = false;

  constructor(
    private route: ActivatedRoute,
    private router: Router,
    private countryService: CountryService,
    private handler: ToastrHandler) {}

  ngOnInit() {
    this.route.params.subscribe(p => {
      if (p.id === undefined) {
        return;
      }
      this.countryService.getCountryById(p.id).subscribe(c => this.country = c);
      this.existed = true;
    });
  }

  navigateToCountries(): void {
    this.router.navigate(['/countries']);
  }

  onCancel(): void {
    this.navigateToCountries();
  }

  onDelete(): void {
    this.countryService.deleteCountry(this.country.countryId);
  }

  onSubmit(): void {
    if (this.existed) {
      this.countryService.updateCountry(this.country).subscribe(res => {
        this.handler.handle(res);
        this.navigateToCountries();});
    } else {
      this.countryService.addCountry(this.country).subscribe(res => {
        this.handler.handle(res);
        this.navigateToCountries();});
    }
  }


}
