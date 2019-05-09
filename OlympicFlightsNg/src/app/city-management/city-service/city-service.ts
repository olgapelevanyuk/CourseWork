import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from '../../../environments/environment';
import { Observable } from 'rxjs';
import { City } from '../city-model/city';
import { CustomServerResponse } from 'src/app/interceptors/serverresponse';

@Injectable({
    providedIn: 'root'
  })

export class CityService {
    private url = environment.apiUrl + 'api/cities/';

    constructor(private http: HttpClient) { }

    getCities(): Observable<Array<City>> {
      return this.http.get<Array<City>>(this.url);
    }

    getCitiesByCountryId(countryId: number): Observable<Array<City>> {
      return this.http.get<Array<City>>(`${this.url}country/${countryId}`);
    }

    updateCityById(cityId: number, cityRequest: City): Observable<CustomServerResponse> {
      return this.http.post<CustomServerResponse>(`${this.url}${cityId}`, cityRequest);
    }

    createCity(cityRequest: City): Observable<CustomServerResponse> {
      return this.http.post<CustomServerResponse>(this.url, cityRequest);
    }

    deleteCityById(cityId: number): Observable<CustomServerResponse> {
      return this.http.delete<CustomServerResponse>(`${this.url}${cityId}`);
    }

    getCityById(cityId: number): Observable<City> {
      return this.http.get<City>(`${this.url}${cityId}`);
    }
}