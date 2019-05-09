import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import { HttpClient } from '@angular/common/http';
import { Flight } from '../models/flight';
import { Observable } from 'rxjs';
import { CustomServerResponse } from 'src/app/interceptors/serverresponse';

@Injectable({
  providedIn: 'root'
})
export class FlightService {
  private url = environment.apiUrl + 'api/flights/';

  constructor(private http: HttpClient) { }

  getFlights(): Observable<Array<Flight>> {
    return this.http.get<Array<Flight>>(this.url);
  }
  
  getIncomingFlights(): Observable<Array<Flight>> {
    return this.http.get<Array<Flight>>(`${this.url}incoming`);
  }

  updateFlightById(FlightId: number, FlightRequest: Flight): Observable<CustomServerResponse> {
    return this.http.post<CustomServerResponse>(`${this.url}${FlightId}`, FlightRequest);
  }

  setFlightStatusById(flightId: number, flightStatus: boolean): Observable<Flight>{
    return this.http.put<Flight>(`${this.url}${flightId}/status`, flightStatus);
  }

  createFlight(FlightRequest: Flight): Observable<CustomServerResponse> {
    return this.http.post<CustomServerResponse>(this.url, FlightRequest);
  }

  deleteFlightById(FlightId: number): Observable<CustomServerResponse> {
    return this.http.delete<CustomServerResponse>(`${this.url}${FlightId}`);
  }

  getFlightById(FlightId: number): Observable<Flight> {
    return this.http.get<Flight>(`${this.url}${FlightId}`);
  }
}
