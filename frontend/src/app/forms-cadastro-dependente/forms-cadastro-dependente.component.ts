import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-forms-cadastro-dependente',
  templateUrl: './forms-cadastro-dependente.component.html',
  styleUrls: ['./forms-cadastro-dependente.component.css']
})
export class FormsCadastroDependenteComponent implements OnInit {

  usuario: any = {
    nome: "",
    email: "",
    parentesco: "",
    nroCartao:""
  }

  onSubmit(form: any){
    console.log(form);
    console.log(this.usuario);
  }  
  constructor() { }

  ngOnInit(): void {
  }

}
