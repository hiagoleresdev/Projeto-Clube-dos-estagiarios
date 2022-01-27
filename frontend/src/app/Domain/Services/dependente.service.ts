import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Dependente } from '../Dependente';

const httpOptions = {
  headers: new HttpHeaders({
    'Content-Type' : 'application/json'
  })
}

@Injectable({
  providedIn: 'root'
})
export class DependenteService {
  url= 'https://localhost:5001/api/dependente';

constructor(private http: HttpClient) { }

PegarTodos(): Observable<Dependente[]>{
  return this.http.get<Dependente[]>(this.url);
}
  
PegarPeloId(dependenteid: number): Observable<Dependente>{
  const apiUrl = '${this.url}/${dependenteid}';
  return this.http.get<Dependente>(apiUrl);
}
  
SalvarDependente(dependente: Dependente) : Observable<any>{
  return this.http.post<Dependente>(this.url, dependente, httpOptions);
}
  
AtualizarDependente(dependente : Dependente) : Observable<any>{
  return this.http.put<Dependente>(this.url, dependente, httpOptions);
}
  
ExcluirDependente(dependenteid: number) : Observable<any>{
  const apiUrl = '${this.url}/${dependenteid}';
  return this.http.delete<number>(apiUrl, httpOptions)
}
  
}