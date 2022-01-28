import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Funcionario } from '../Funcionario';

const httpOptions = {
  headers: new HttpHeaders({
    'Content-Type' : 'application/json'
  })
}

@Injectable({
  providedIn: 'root'
})
export class FuncionarioService{
  url= 'https://localhost:5001/api/funcionario';

constructor(private http: HttpClient) { }
  
PegarPeloId(funcionarioid: number): Observable<Funcionario>{
  const apiUrl = '${this.url}/${funcionarioid}';
  return this.http.get<Funcionario>(apiUrl);
}
  
SalvarFuncionario(funcionario: Funcionario) : Observable<any>{
  return this.http.post<Funcionario>(this.url, funcionario, httpOptions);
}
  
AtualizarFuncionario(funcionario : Funcionario) : Observable<any>{
  return this.http.put<Funcionario>(this.url, funcionario, httpOptions);
}
  
ExcluirFuncionario(funcionarioid: number) : Observable<any>{
  const apiUrl = '${this.url}/${funcionarioid}';
  return this.http.delete<number>(apiUrl, httpOptions)
}

ValidarFuncionario(usuario: string, senha: string) : Observable<any>{
  return this.http.get<number>(this.url);
}

}