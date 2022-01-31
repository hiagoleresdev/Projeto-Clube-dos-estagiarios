import { Component, OnInit, TemplateRef } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { BsModalRef, BsModalService } from 'ngx-bootstrap/modal';
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

  constructor(private sociosServiceDto: SocioDTOService,
     private socioService: SocioService,
     private modalService: BsModalService) { }

  formulario: any;
  nomeSocio: string;
  socioId: number;

  socios: Socio[];
  visibilidadeTabela: boolean = true;
  visibilidadeFormulario: boolean = false;

  modalRef: BsModalRef;


  ngOnInit(): void {

    this.socioService.PegarTodos().subscribe(resultados => {

      let socios = [];

      resultados.forEach((resultado)=>{
        console.log(resultado.id)
        socios.push(resultado)

      });

      this.socios = socios
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
      console.log(socio)

      this.sociosServiceDto.SalvarSocio(socio).subscribe(resultado => {
        this.visibilidadeFormulario = false;
        this.visibilidadeTabela = true;

        alert('Socio inserido com sucesso!');

        this.socioService.PegarTodos().subscribe(registros =>{
          this.socios = registros;
        })
      });
    }

    Teste(){
      alert('oi')
    }


    ExibirConfirmacaoExclusao(socioId, nomeSocio, conteudoModal: TemplateRef<any>):void{

      this.modalRef = this.modalService.show(conteudoModal);
      this.socioId = socioId;
      this.nomeSocio = nomeSocio;
    }

    ExcluirSocio(socioId){
      console.log(socioId)
      this.sociosServiceDto.ExcluirSocio(socioId).subscribe(resultado => {
        this.modalRef.hide();
        alert("Marcao excluida com sucesso");
        this.socioService.PegarTodos().subscribe(registros => {
          this.socios = registros;
        })
      })
    }
}

