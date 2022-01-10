import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'forms-cadastro-socio',
  templateUrl: './forms-cadastro-socio.component.html',
  styleUrls: ['./forms-cadastro-socio.component.css']
})
export class FormsCadastroSocioComponent implements OnInit {

  usuario: any = {
    nome: "",
    endereco: "",
    telefone: "",
    email: "",
    status: "",
    categoria:"",
    nro_cartao:""
  }

  onSubmit(form: any){
    console.log(form);
    console.log(this.usuario);
  }  

  salvarDados(){
    debugger
    let teste = this.usuario;
  }

  btnFechar(){
    
  }
 

  constructor() { }

  ngOnInit(): void {
  }

}
