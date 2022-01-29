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
  url= 'https://localhost:5001/api/Categoria';

constructor(private http: HttpClient) { }

PegarTodos(): Observable<Categoria[]>{
  return this.http.get<Categoria[]>(this.url);
}

PegarPeloId(categoriaid: number): Observable<Categoria>{
  const apiUrl = '${this.url}/${categoriaid}';
  return this.http.get<Categoria>(apiUrl);
}


}
