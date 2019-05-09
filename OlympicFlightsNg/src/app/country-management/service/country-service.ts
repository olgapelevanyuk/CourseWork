import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from '../../../environments/environment';
import { Observable } from 'rxjs';
import { Country } from '../models/country';
import { CustomServerResponse } from 'src/app/interceptors/serverresponse';

@Injectable({
    providedIn: 'root'
  })

export class CountryService{
    private url = environment.apiUrl + 'api/countries/';

    constructor(private http: HttpClient) { }

    getCountries(): Observable<Array<Country>>{
        return this.http.get<Array<Country>>(this.url);
    }

    getCountryById(id: number): Observable<Country>{
        return this.http.get<Country>(`${this.url}${id}`);
    }

    addCountry(country: Country): Observable<CustomServerResponse>{
        return this.http.post<CustomServerResponse>(this.url, country);
    }

    deleteCountry(countryId: number): Observable<CustomServerResponse> {
        return this.http.delete<CustomServerResponse>(`${this.url}${countryId}`);
    }

    updateCountry(country: Country): Observable<CustomServerResponse> {
       return this.http.put<CustomServerResponse>(`${this.url}${country.countryId}`, country);
    }
}