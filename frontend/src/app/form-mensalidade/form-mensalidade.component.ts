import { Component, OnInit } from '@angular/core';
import { Mensalidades } from '../Domain/Mensalidades';
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

  constructor(private mensalidadeServiceDto: MensalidadeDTOService) { }

  mensalidades: Mensalidades[];
  formulario: any;



  ngOnInit(): void {
    this.formulario = new FormGroup({
      dataVencimento: new FormControl(),
      valorInicial: new FormControl(),
      dataPagamento: new FormControl(),
      juros: new FormControl(),
      valorFinal: new FormControl(),
      quitada: new FormControl(),
      fkSocio: new FormControl()
    });
    }




  EnviarMensalidade(): void {
    const mensalidade : MensalidadeDTO = this.formulario.value;

    this.mensalidadeServiceDto.SalvarMensalidade(mensalidade).subscribe(resultado => {
      alert('Mensalidade inserida com sucesso!');
    });
  }






}
