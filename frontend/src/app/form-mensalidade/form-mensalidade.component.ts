import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'form-mensalidade',
  templateUrl: './form-mensalidade.component.html',
  styleUrls: ['./form-mensalidade.component.css']
})
export class FormMensalidadeComponent implements OnInit {

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

  constructor() { }

  ngOnInit(): void {
  }

}
