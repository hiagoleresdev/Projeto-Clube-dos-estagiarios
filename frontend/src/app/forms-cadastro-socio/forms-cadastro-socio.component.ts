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
export class FormsCadastroSocioComponent implements OnInit 
{
  formulario: any;
  tituloFormulario: string;
  socios: Socio[];
  visibilidadeTabela: boolean = true;
  visibilidadeFormulario: boolean = false;

  constructor(private socioDTOService: SocioDTOService, private socioService: SocioService) { }

  ngOnInit(): void 
  {
      this.socioService.PegarTodos().subscribe(resultado => {
        this.socios = resultado;
      });

      this.tituloFormulario = 'Nova pessoa'
      this.formulario = new FormGroup({
        Nome: new FormControl(null),
        Email: new FormControl(null),
        NumeroCartao: new FormControl(null),
        Telefone: new FormControl(null),
        Cep: new FormControl(null),
        Uf: new FormControl(null),
        Cidade: new FormControl(null),
        Bairro: new FormControl(null),
        Logradouro: new FormControl(null),
        Categoria: new FormControl(null)
      })
  }

  ExibirFormularioCadastro() : void
  {
    this.visibilidadeTabela = false;
    this.visibilidadeFormulario = true;
  }

  Voltar(): void
  {
    this.visibilidadeFormulario = false;
    this.visibilidadeTabela = true;
  }

  EnviarFormulario(): void
  {
    const socio: SocioDTO = this.formulario.value;

    this.socioDTOService.SalvarSocio(socio).subscribe(resultado => {
      this.Voltar();
      this.socioService.PegarTodos().subscribe(resultado => 
      {
        this.socios = resultado;
      });
    })
  }

}

