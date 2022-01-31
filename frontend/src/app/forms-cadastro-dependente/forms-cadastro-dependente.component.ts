import { Component, OnInit } from '@angular/core';
import { Dependente } from '../Domain/Dependente'
import { DependenteDTO } from '../DTOs/DependenteDTO';
import { DependenteDTOService } from '../DTOs/Services/dependente-dto.service';
import { DependenteService } from '../Domain/Services/dependente.service';
import { FormControl, FormGroup } from '@angular/forms';



@Component({
  selector: 'app-forms-cadastro-dependente',
  templateUrl: './forms-cadastro-dependente.component.html',
  styleUrls: ['./forms-cadastro-dependente.component.css']
})
export class FormsCadastroDependenteComponent implements OnInit
{
  dependenteDTOService: any;
  constructor(private dependenteService: DependenteService, dependenteDTOService: DependenteDTOService) { }



  formulario: any;

  visibilidadeTabela: boolean = true;
  visibilidadeFormulario: boolean = false;

  dependentes: Dependente[];

  ngOnInit(): void {

    this.dependenteService.PegarTodos().subscribe(resultado => {
      this.dependentes = resultado
    })

  }

  ExibirFormularioCadastro() : void{

    this.visibilidadeTabela = false;
    this.visibilidadeFormulario = true;

    this.formulario = new FormGroup({
      nome: new FormControl(null),
      email: new FormControl(null),
      parentesco: new FormControl(null),
      numeroCartao: new FormControl(null),
      fkSocio: new FormControl(null)
    });
  }

  Voltar() : void {
    this.visibilidadeFormulario = false;
    this.visibilidadeTabela = true;
  }

  EnviarDependente(): void {
    const dependente : DependenteDTO = this.formulario.value;
    console.log(dependente)

    this.dependenteDTOService.SalvarDependente(dependente).subscribe(resultado => {

      this.visibilidadeFormulario = false;
      this.visibilidadeTabela = true;

      alert('Dependente inserido com sucesso!');

      this.dependenteService.PegarTodos().subscribe(registros => {
        this.dependentes = registros
      })
    });
  }
}
