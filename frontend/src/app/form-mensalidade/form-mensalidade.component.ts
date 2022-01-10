import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'form-mensalidade',
  templateUrl: './form-mensalidade.component.html',
  styleUrls: ['./form-mensalidade.component.css']
})
export class FormMensalidadeComponent implements OnInit {

  mensalidade: any = {
    dataMensal: "",
    valorMensal: "",
    dataPagto: "",
    jurosMensal: "",
    valorPagto: "",
    quitacaoMensal: "" 
  }

  onSubmit(form: any){
    console.log(this.mensalidade);
  }

  constructor() { }

  ngOnInit(): void {
  }

}
