import { HttpClient, HttpHeaders, HttpResponse } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from "rxjs";
import { SocioDTO } from '../SocioDTO';

const httpOptions = {
  headers: new HttpHeaders({
    'Content-Type' : 'application/json'
  })
}

@Injectable({
  providedIn: 'root'
})

export class SocioDTOService 
{
  url= 'https://localhost:7156/api/Socio';
  
  constructor(private http: HttpClient) { }

  SalvarSocio(SocioDTO: SocioDTO) : Observable<any>
  {
    return this.http.post<SocioDTO>(this.url, SocioDTO, httpOptions);
  }

  AtualizarSocio(SocioDTO : SocioDTO) : Observable<any>
  {
    return this.http.put<SocioDTO>(this.url, SocioDTO, httpOptions);
  }

  ExcluirSocio(Socioid: number) : Observable<any>
  {
    const apiUrl = '${this.url}/${Socioid}';
    return this.http.delete<number>(apiUrl, httpOptions)
  }
}
