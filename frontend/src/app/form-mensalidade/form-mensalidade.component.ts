import { Component, OnInit } from '@angular/core';
import { Mensalidade } from '../Domain/Mensalidade';
import { FormControl, FormGroup } from '@angular/forms';
import { MensalidadeDTO } from '../DTOs/MensalidadeDTO';
import { MensalidadesService } from '../Domain/Services/mensalidades.service';
import { MensalidadeDTOService } from '../DTOs/Services/mensalidade-dto.service';

@Component({
  selector: 'form-mensalidade',
  templateUrl: './form-mensalidade.component.html',
  styleUrls: ['./form-mensalidade.component.css']
})
export class FormMensalidadeComponent implements OnInit {

  constructor(private mensalidadeServiceDto: MensalidadeDTOService, private mensalidadeService: MensalidadesService) { }

  formulario: any;
  mensalidades: Mensalidade[];

  visibilidadeTabela: boolean = true;
  visibilidadeFormulario: boolean = false;


  ngOnInit(): void {
    this.mensalidadeService.PegarTodos().subscribe(resultado => {
      this.mensalidades = resultado
    });
  }

  ExibirFormularioCadastro() : void {
    this.visibilidadeTabela = false;
    this.visibilidadeFormulario = true;

    this.formulario = new FormGroup({
      dataVencimento: new FormControl(null),
      valorInicial: new FormControl(null),
      dataPagamento: new FormControl(null),
      juros: new FormControl(null),
      valorFinal: new FormControl(null),
      quitada: new FormControl(null),
      fkSocio: new FormControl(null)
    });
  }

  Voltar() : void{
    this.visibilidadeTabela = true;
    this.visibilidadeFormulario = false;
  }

  EnviarMensalidade(): void {
    const mensalidade : MensalidadeDTO = this.formulario.value;

    this.mensalidadeServiceDto.SalvarMensalidade(mensalidade).subscribe(resultado => {
      this.visibilidadeFormulario = false;
      this.visibilidadeTabela = true;

      alert('Mensalidade inserida com sucesso!');

      this.mensalidadeService.PegarTodos().subscribe(registros =>{
        this.mensalidades = registros;
      });
    });
  }


}
