import { Component, OnInit } from '@angular/core';
import { Categoria } from '../Domain/Categoria';
import { Dependente } from '../Domain/Dependente';
import { DependenteService } from '../Domain/Services/dependente.service';

@Component({
  selector: 'app-forms-cadastro-dependente',
  templateUrl: './forms-cadastro-dependente.component.html',
  styleUrls: ['./forms-cadastro-dependente.component.css']
})
export class FormsCadastroDependenteComponent implements OnInit {

  dependentes: Dependente[];

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

  EnviarDependente(): void {
    const dependente : Dependente = this.usuario.value;

    this.dependenteservice.SalvarDependente(dependente).subscribe(resultado => {
      alert('Dependente inserido com sucesso!');
    });
  }

  constructor(private dependenteservice : DependenteService) { }

  ngOnInit(): void {
    this.dependenteservice.PegarTodos().subscribe(resultado =>{
      this.dependentes = resultado;
    });
  }
}
