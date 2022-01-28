import { Component, OnInit } from '@angular/core';
import { SocioService } from '../Domain/Services/socio.service';
import { Socio } from '../Domain/Socio';

@Component({
  selector: 'forms-cadastro-socio',
  templateUrl: './forms-cadastro-socio.component.html',
  styleUrls: ['./forms-cadastro-socio.component.css']
})
export class FormsCadastroSocioComponent implements OnInit {

  socios: Socio[];

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

  EnviarSocio(): void {
    const socio : Socio = this.usuario.value;

    this.sociosService.SalvarSocio(socio).subscribe(resultado => {
      alert('Socio inserido com sucesso!');
    });
  }

 
  constructor(private sociosService: SocioService) { }

  ngOnInit(): void {
    this.sociosService.PegarTodos().subscribe(resultado =>{
      this.socios = resultado;
    });  
  }

}

