import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import { Observable } from 'rxjs';
import { Airport } from '../models/airport';
import { HttpClient } from '@angular/common/http';
import { CustomServerResponse } from 'src/app/interceptors/serverresponse';

@Injectable({
  providedIn: 'root'
})
export class AirportService {
  private url = environment.apiUrl + 'api/airports/';

  constructor(private http: HttpClient) { }

  getAirports(): Observable<Array<Airport>> {
    return this.http.get<Array<Airport>>(this.url);
  }

  getAirportsByCityId(airportId: number): Observable<Array<Airport>> {
    return this.http.get<Array<Airport>>(`${this.url}city/${airportId}`);
  }

  updateAirportById(airportId: number, airportRequest: Airport): Observable<CustomServerResponse> {
    return this.http.post<CustomServerResponse>(`${this.url}${airportId}`, airportRequest);
  }

  createAirport(airportRequest: Airport): Observable<CustomServerResponse> {
    return this.http.post<CustomServerResponse>(this.url, airportRequest);
  }

  deleteAirportById(airportId: number): Observable<CustomServerResponse> {
    return this.http.delete<CustomServerResponse>(`${this.url}${airportId}`);
  }

  getAirportById(airportId: number): Observable<Airport> {
    return this.http.get<Airport>(`${this.url}${airportId}`);
  }
}
