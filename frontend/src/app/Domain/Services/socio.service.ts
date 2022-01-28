import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Socio } from '../Socio';

const httpOptions = {
  headers: new HttpHeaders({
    'Content-Type' : 'application/json'
  })
}

@Injectable({
  providedIn: 'root'
})
export class SocioService {
  url= 'https://localhost:5001/api/socio';

  constructor(private http: HttpClient) { }

  PegarTodos(): Observable<Socio[]>{
    return this.http.get<Socio[]>(this.url);
  }
  
  PegarPeloId(socioid: number): Observable<Socio>{
    const apiUrl = '${this.url}/${socioid}';
    return this.http.get<Socio>(apiUrl);
  }
  
  SalvarSocio(socio: Socio) : Observable<any>{
    return this.http.post<Socio>(this.url, socio, httpOptions);
  }
  
  AtualizarSocio(socio : Socio) : Observable<any>{
    return this.http.put<Socio>(this.url, socio, httpOptions);
  }
  
  ExcluirSocio(socioid: number) : Observable<any>{
    const apiUrl = '${this.url}/${socioid}';
    return this.http.delete<number>(apiUrl, httpOptions)
  }
}
