import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Categoria } from '../Categoria';

const httpOptions = {
  headers: new HttpHeaders({
    'Content-Type' : 'application/json'
  })
}

@Injectable({
  providedIn: 'root'
})
export class CategoriaService {
  url= 'https://localhost:5001/api/categoria';

constructor(private http: HttpClient) { }

PegarTodos(): Observable<Categoria[]>{
  return this.http.get<Categoria[]>(this.url);
}

PegarPeloId(categoriaid: number): Observable<Categoria>{
  const apiUrl = '${this.url}/${categoriaid}';
  return this.http.get<Categoria>(apiUrl);
}

SalvarCategoria(categoria: Categoria) : Observable<any>{
  return this.http.post<Categoria>(this.url, categoria, httpOptions);
}

AtualizarCategoria(categoria : Categoria) : Observable<any>{
  return this.http.put<Categoria>(this.url, categoria, httpOptions);
}

ExcluirCategoria(categoriaid: number) : Observable<any>{
  const apiUrl = '${this.url}/${categoriaid}';
  return this.http.delete<number>(apiUrl, httpOptions)
}

}
