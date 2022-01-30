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

  constructor(private sociosServiceDto: SocioDTOService, private socioService: SocioService) { }

  formulario: any;
  socio: SocioDTO[];

  socios: Socio[];
  visibilidadeTabela: boolean = true;
  visibilidadeFormulario: boolean = false;

  ngOnInit(): void {

    this.socioService.PegarTodos().subscribe(resultado => {
      this.socios = resultado
    });


    }

    ExibirFormularioCadastro():void{
      this.visibilidadeTabela = false;
      this.visibilidadeFormulario = true;

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

    Voltar():void{
      this.visibilidadeTabela = true;
      this.visibilidadeFormulario = false;
    }

    EnviarFormulario(): void {
      const socio : SocioDTO = this.formulario.value;

      this.sociosServiceDto.SalvarSocio(socio).subscribe(resultado => {
        this.visibilidadeFormulario = false;
        this.visibilidadeTabela = true;

        alert('Socio inserido com sucesso!');

        this.socioService.PegarTodos().subscribe(registros =>{
          this.socios = registros;
        })
      });
    }



}

