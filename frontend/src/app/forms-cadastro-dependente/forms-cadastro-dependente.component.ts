import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { Dependente } from '../Domain/Dependente';
import { DependenteService } from '../Domain/Services/dependente.service';
import { DependenteDTO } from '../DTOs/DependenteDTO';
import { DependenteDTOService } from '../DTOs/Services/dependente-dto.service';

@Component({
  selector: 'app-forms-cadastro-dependente',
  templateUrl: './forms-cadastro-dependente.component.html',
  styleUrls: ['./forms-cadastro-dependente.component.css']
})
export class FormsCadastroDependenteComponent implements OnInit 
{
  dependenteDTOService: any;
  constructor(private dependenteService: DependenteService, dependenteDTOService: DependenteDTOService) { }

  dependentes: Dependente[];

  formulario: any;

  tituloFormulario: any

  EnviarDependente(): void {
    const dependente : DependenteDTO = this.formulario.value

    this.dependenteDTOService.SalvarDependente(dependente).subscribe(resultado => {
      alert('Dependente inserido com sucesso!');
    });
  }

  ngOnInit(): void 
  {
    this.dependenteService.PegarTodos().subscribe(resultado =>{
      this.dependentes = resultado;
    })

    this.tituloFormulario = 'Nova pessoa'
    this.formulario = new FormGroup({
      Nome: new FormControl(),
      Email: new FormControl(),
      NumeroCartao: new FormControl(),
      Parentesco: new FormControl(),
      FkSocio: new FormControl(),
    });
  }
}
