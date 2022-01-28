import { Component, OnInit } from '@angular/core';
import { Mensalidades } from '../Domain/Mensalidades';
import { MensalidadesService } from '../Domain/Services/mensalidades.service';

@Component({
  selector: 'form-mensalidade',
  templateUrl: './form-mensalidade.component.html',
  styleUrls: ['./form-mensalidade.component.css']
})
export class FormMensalidadeComponent implements OnInit {

  asMensalidades: Mensalidades[];
  Idmensalidade: number;


  mensalidade: any = [{
    id: 1,
    dataMensal: "21/08",
    valorMensal: "500",
    dataPagto: "21/08",
    jurosMensal: "0",
    valorPagto: "500",
    quitacaoMensal: "ativo" 
  },
    {id: 2,
    dataMensal: "08/08",
    valorMensal: "321",
    dataPagto: "08/08",
    jurosMensal: "0",
    valorPagto: "321",
    quitacaoMensal: "inativo" 
}
  ]

  onSubmit(form: any){
    console.log(this.mensalidade);
  }

  EnviarMensalidade(): void {
    const mensalidade : Mensalidades = this.mensalidade.value;

    this.mensalidadeservice.SalvarMensalidades(mensalidade).subscribe(resultado => {
      alert('Mensalidade inserida com sucesso!');
    });
  }

  constructor(private mensalidadeservice: MensalidadesService) { }

  ngOnInit(): void {
    this.mensalidadeservice.PegarTodos().subscribe(resultado =>{
      this.asMensalidades = resultado;
    });
  }


}
