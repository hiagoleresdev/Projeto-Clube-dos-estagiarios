import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Mensalidades } from '../Mensalidades';

const httpOptions = {
  headers: new HttpHeaders({
    'Content-Type' : 'application/json'
  })
}

@Injectable({
  providedIn: 'root'
})
export class MensalidadesService {
  url= 'https://localhost:5001/api/mensalidades';

constructor(private http: HttpClient) { }

  PegarTodos(): Observable<Mensalidades[]>{
    return this.http.get<Mensalidades[]>(this.url);
  }

  PegarPeloId(mensalidadesid: number): Observable<Mensalidades>{
    const apiUrl = '${this.url}/${mensalidadesid}';
    return this.http.get<Mensalidades>(apiUrl);
  }


}
