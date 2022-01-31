import { Component, OnInit } from '@angular/core';
import { FormGroup } from '@angular/forms';
import { Mensalidades } from '../Domain/Mensalidades';
import { MensalidadesService } from '../Domain/Services/mensalidades.service';
import { MensalidadeDTO } from '../DTOs/MensalidadeDTO';
import { MensalidadeDTOService } from '../DTOs/Services/mensalidade-dto.service';

@Component({
  selector: 'form-mensalidade',
  templateUrl: './form-mensalidade.component.html',
  styleUrls: ['./form-mensalidade.component.css']
})
export class FormMensalidadeComponent implements OnInit {

  asMensalidades: Mensalidades[];
  Idmensalidade: number;
  formulario: any;

  constructor(private mensalidadeDTOService: MensalidadeDTOService, private mensalidadeservice: MensalidadesService) { }

  onSubmit(form: any){
  }

  EnviarMensalidade(): void {
    const mensalidade : MensalidadeDTO = this.formulario.value

    this.mensalidadeDTOService.SalvarMensalidade(mensalidade).subscribe(resultado => {
      alert('Mensalidade inserida com sucesso!');
    });
  }

 

  ngOnInit(): void {
    this.mensalidadeservice.PegarTodos().subscribe(resultado =>{
      this.asMensalidades = resultado;
    });

    this.formulario = new FormGroup({

    })
  }


}
