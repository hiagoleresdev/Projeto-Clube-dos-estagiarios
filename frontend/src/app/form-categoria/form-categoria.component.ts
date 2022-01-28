import { Component, OnInit } from '@angular/core';
import { Categoria } from '../Domain/Categoria';
import { CategoriaService } from '../Domain/Services/categoria.service';

@Component({
  selector: 'form-categoria',
  templateUrl: './form-categoria.component.html',
  styleUrls: ['./form-categoria.component.css']
})
export class FormCategoriaComponent implements OnInit {

  categorias: Categoria[];

  categoria: any ={
    nome: ""
  }
 
  onSubmit(form: any){
    console.log(this.categoria);
  }

  EnviarCategoria(): void {
    const categoria : Categoria = this.categoria.value;

    this.categoriaservice.SalvarCategoria(categoria).subscribe(resultado => {
      alert('Categoria inserida com sucesso!');
    });
  }

  constructor(private categoriaservice: CategoriaService) { }

  ngOnInit(): void {
    this.categoriaservice.PegarTodos().subscribe(resultado =>{
      this.categorias = resultado;
  });
}

}
