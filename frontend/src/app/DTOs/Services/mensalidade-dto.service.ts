import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from "rxjs";
import { DependenteDTO } from '../DependenteDTO';
import { MensalidadeDTO } from '../MensalidadeDTO';

const httpOptions = {
  headers: new HttpHeaders({
    'Content-Type' : 'application/json'
  })
}

@Injectable({
  providedIn: 'root'
})
export class MensalidadeDTOService {
  url= 'https://localhost:5001/api/MensalidadeDTO';

  constructor(private http: HttpClient) { }

  PegarTodos(): Observable<MensalidadeDTO[]>{
    return this.http.get<MensalidadeDTO[]>(this.url);
  }
  
  PegarPeloId(mensalidadeid: number): Observable<MensalidadeDTO>{
    const apiUrl = '${this.url}/${mensalidadeid}';
    return this.http.get<MensalidadeDTO>(apiUrl);
  }
  
  SalvarDependente(mensalidadeDTO: MensalidadeDTO) : Observable<any>{
    return this.http.post<MensalidadeDTO>(this.url, mensalidadeDTO, httpOptions);
  }
  
  AtualizarDependente(mensalidadeDTO : MensalidadeDTO) : Observable<any>{
    return this.http.put<MensalidadeDTO>(this.url, mensalidadeDTO, httpOptions);
  }
  
  ExcluirDependente(mensalidadeid: number) : Observable<any>{
    const apiUrl = '${this.url}/${mensalidadeid}';
    return this.http.delete<number>(apiUrl, httpOptions)
  }
}