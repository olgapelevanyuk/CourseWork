import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { ChartData } from './chartdata';


@Injectable({
  providedIn: 'root'
})
export class ChartService {

  private url = environment.apiUrl + 'api/admin/stat/';

  constructor(private http: HttpClient) { 
  }

  getFlightsPerMonthData(): Observable<Array<ChartData>>{
    return this.http.get<Array<ChartData>>(`${this.url}flpermonth`);
  }

  getClientsPerMonthData(): Observable<Array<ChartData>>{
    return this.http.get<Array<ChartData>>(`${this.url}clpermonth`);
  }

  getTicketsPerMonthData(): Observable<Array<ChartData>>{
    return this.http.get<Array<ChartData>>(`${this.url}tcktpermonth`);
  }

  getOverallStatistics(): Observable<object>{
    return this.http.get<object>(`${this.url}overall`)
  }
}
