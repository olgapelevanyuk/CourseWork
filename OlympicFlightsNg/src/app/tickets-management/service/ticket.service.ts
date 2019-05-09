import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import { Ticket } from '../models/ticket';
import { Observable } from 'rxjs';
import { HttpClient, HttpResponse } from '@angular/common/http';
import { CustomServerResponse } from 'src/app/interceptors/serverresponse';

@Injectable({
  providedIn: 'root'
})
export class TicketService {
  private url = environment.apiUrl + 'api/tickets/';
  private adminUrl = environment.apiUrl + 'api/admin/';

  constructor(private http: HttpClient) { }

  getTickets(): Observable<Array<Ticket>> {
    return this.http.get<Array<Ticket>>(this.url);
  }

  updateTicketById(ticketId: number, ticketIdRequest: Ticket): Observable<Ticket> {
    return this.http.post<Ticket>(`${this.url}${ticketId}`, ticketIdRequest);
  }

  createTicket(ticketIdRequest: Ticket): Observable<CustomServerResponse> {
    return this.http.post<CustomServerResponse>(this.url, ticketIdRequest);
  }

  deleteTicketById(ticketId: number): Observable<object> {
    return this.http.delete<object>(`${this.url}${ticketId}`);
  }

  getTicketById(ticketId: number): Observable<Ticket> {
    return this.http.get<Ticket>(`${this.url}${ticketId}`);
  }

  setTicketStatus(ticketId: number, ticketStatus: boolean): Observable<object> {
    return this.http.put<object>(`${this.url}${ticketId}/setStatus`, ticketStatus);
  }

  approveTicket(ticketId: number): Observable<object> {
    return this.http.put<object>(`${this.adminUrl}tickets/approve/${ticketId}`, null);
  }

  approveTickets(ticketIds: number[]): Observable<object> {
    return this.http.put<object>(`${this.adminUrl}approve`, ticketIds);
  }

  getTicketsByUserId(): Observable<Array<Ticket>> {
    const userId = localStorage.getItem('userId');

    if (userId === null) {
      return null;
    }

    return this.http.get<Array<Ticket>>(`${this.url}user/${userId}`);
  }
}
