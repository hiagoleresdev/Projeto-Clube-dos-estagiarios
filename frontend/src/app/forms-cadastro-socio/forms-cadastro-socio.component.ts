import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { SocioService } from '../Domain/Services/socio.service';
import { Socio } from '../Domain/Socio';
import { SocioDTOService } from '../DTOs/Services/socio-dto.service';
import { SocioDTO } from '../DTOs/SocioDTO';

@Component({
  selector: 'forms-cadastro-socio',
  templateUrl: './forms-cadastro-socio.component.html',
  styleUrls: ['./forms-cadastro-socio.component.css']
})
export class FormsCadastroSocioComponent implements OnInit {

  constructor(private sociosServiceDto: SocioDTOService) { }

  formulario: any;
  socio: SocioDTO[];



  ngOnInit(): void {
    this.formulario = new FormGroup({
      nome: new FormControl(null),
      email: new FormControl(null),
      numeroCartao: new FormControl(null),
      telefone: new FormControl(null),
      cep: new FormControl(null),
      uf: new FormControl(null),
      cidade: new FormControl(null),
      bairro: new FormControl(null),
      logradouro: new FormControl(null),
      fkcategoria: new FormControl(null),
    });
    }

    EnviarFormulario(): void {
      const socio : SocioDTO = this.formulario.value;

      this.sociosServiceDto.SalvarSocio(socio).subscribe(resultado => {
        alert('Socio inserido com sucesso!');
      });
    }



}

