import { Usuario } from './usuario';
import { Component, EventEmitter, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { FuncionarioService } from '../Domain/Services/funcionario.service';
import { Router } from '@angular/router';

@Component({
  selector: 'form-login',
  templateUrl: './form-login.component.html',
  styleUrls: ['./form-login.component.css']
})
export class FormLoginComponent implements OnInit 
{
  private usuarioAutenticado: boolean = false;

  mostrarMenuEmitter = new EventEmitter<boolean>();

  groupLogin: any;

  constructor(private router: Router, private funcionarioService: FuncionarioService) {}

  ngOnInit(): void 
  { 
    this.groupLogin = new FormGroup({
      Usuario: new FormControl(),
      Senha: new FormControl()
    })
  }

  FazerLogin()
  {
    const usuario: Usuario = this.groupLogin.value;


    this.funcionarioService.ValidarFuncionario(usuario.Usuario, usuario.Senha).subscribe(response => 
      {
        if(response.status == 200)
        {
          this.usuarioAutenticado = true;

          this.mostrarMenuEmitter.emit(true);

          alert(response.body);

          this.router.navigate(["/home"]);
        }
        else if(response.status == 404)
        {
          this.usuarioAutenticado = false;

          this.mostrarMenuEmitter.emit(false);
          
          alert(response.body);
        }
        else
        {
          this.usuarioAutenticado = false;

          this.mostrarMenuEmitter.emit(false);

          alert(response.body)
        }
    })
  }

}
