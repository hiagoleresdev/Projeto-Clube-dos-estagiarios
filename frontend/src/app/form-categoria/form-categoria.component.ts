import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'form-categoria',
  templateUrl: './form-categoria.component.html',
  styleUrls: ['./form-categoria.component.css']
})
export class FormCategoriaComponent implements OnInit {

  categoria: any ={
    nome: ""
  }
 
  onSubmit(form: any){
    console.log(this.categoria);
  }

  constructor() { }

  ngOnInit(): void {
  }

}
