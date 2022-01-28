import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from "rxjs";
import { CategoriaDTO } from '../CategoriaDTO';

const httpOptions = {
  headers: new HttpHeaders({
    'Content-Type' : 'application/json'
  })
}

@Injectable({
  providedIn: 'root'
})

export class CategoriaDTOService {
  url= 'https://localhost:5001/api/CategoriaDTO';
  
  constructor(private http: HttpClient) { }

PegarTodos(): Observable<CategoriaDTO[]>{
  return this.http.get<CategoriaDTO[]>(this.url);
}

PegarPeloId(categoriaid: number): Observable<CategoriaDTO>{
  const apiUrl = '${this.url}/${categoriaid}';
  return this.http.get<CategoriaDTO>(apiUrl);
}

SalvarCategoria(categoriaDTO: CategoriaDTO) : Observable<any>{
  return this.http.post<CategoriaDTO>(this.url, categoriaDTO, httpOptions);
}

AtualizarCategoria(categoriaDTO : CategoriaDTO) : Observable<any>{
  return this.http.put<CategoriaDTO>(this.url, categoriaDTO, httpOptions);
}

ExcluirCategoria(categoriaid: number) : Observable<any>{
  const apiUrl = '${this.url}/${categoriaid}';
  return this.http.delete<number>(apiUrl, httpOptions)
}
}
