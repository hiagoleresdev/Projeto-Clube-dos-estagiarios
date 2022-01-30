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
export class FormsCadastroDependenteComponent implements OnInit {

  constructor(private dependenteServiceDto: DependenteDTOService) { }

  formulario: any;
  dependente: DependenteDTO[];


  ngOnInit(): void {
    this.formulario = new FormGroup({
      nome: new FormControl(),
      email: new FormControl(),
      parentesco: new FormControl(),
      numeroCartao: new FormControl(),
      fk_Socio: new FormControl()
    });

  }

  EnviarDependente(): void {
    const dependente : DependenteDTO = this.formulario.value;

    this.dependenteServiceDto.SalvarDependente(dependente).subscribe(resultado => {
      alert('Dependente inserido com sucesso!');
    });
  }

}
