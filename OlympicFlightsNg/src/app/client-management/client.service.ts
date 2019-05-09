import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Client } from './client';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class ClientService {
  private url = environment.apiUrl + 'api/clients/';

  constructor(private http: HttpClient) { }

  getClients(): Observable<Array<Client>> {
    return this.http.get<Array<Client>>(this.url);
  }

  getClientsById(id: number): Observable<Client> {
    return this.http.get<Client>(`${this.url}${id}`);
  }

  getClientsByUserId(id: number): Observable<Array<Client>> {
    return this.http.get<Array<Client>>(`${this.url}user/${id}`);
  }

  addClient(client: Client): Observable<Client>{
      return this.http.post<Client>(this.url, client);
  }

  // deleteClients(clientId: number): void {
  //     this.http.delete(`${this.url}${clientId}`);
  // }

  // updateClients(client: Client): Observable<Client> {
  //    return this.http.put<Client>(`${this.url}${client.clientId}`, client);
  // }

}
