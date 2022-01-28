import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { DependenteDTO } from '../DependenteDTO';

const httpOptions = {
  headers: new HttpHeaders({
    'Content-Type' : 'application/json'
  })
}

@Injectable({
  providedIn: 'root'
})
export class DependenteDTOService {
  url= 'https://localhost:5001/api/DependenteDTO';

  constructor(private http: HttpClient) { }

  PegarTodos(): Observable<DependenteDTO[]>{
    return this.http.get<DependenteDTO[]>(this.url);
  }
  
  PegarPeloId(categoriaid: number): Observable<DependenteDTO>{
    const apiUrl = '${this.url}/${categoriaid}';
    return this.http.get<DependenteDTO>(apiUrl);
  }
  
  SalvarCategoria(dependenteDTO: DependenteDTO) : Observable<any>{
    return this.http.post<DependenteDTO>(this.url, dependenteDTO, httpOptions);
  }
  
  AtualizarCategoria(dependenteDTO : DependenteDTO) : Observable<any>{
    return this.http.put<DependenteDTO>(this.url, dependenteDTO, httpOptions);
  }
  
  ExcluirCategoria(dependenteid: number) : Observable<any>{
    const apiUrl = '${this.url}/${dependenteid}';
    return this.http.delete<number>(apiUrl, httpOptions)
  }
}
