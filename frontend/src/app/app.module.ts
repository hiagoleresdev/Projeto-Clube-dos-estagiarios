import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { NavbarClubeComponent } from './navbar-clube/navbar-clube.component';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { FormsCadastroSocioComponent } from './forms-cadastro-socio/forms-cadastro-socio.component';
import { FormCategoriaComponent } from './form-categoria/form-categoria.component';
import { FormMensalidadeComponent } from './form-mensalidade/form-mensalidade.component';
import { FormLoginComponent } from './form-login/form-login.component';
import { LoginAutenticacaoService } from './form-login/login-autenticacao.service';
import { routing } from './app-routing.module';
import { HomeClubeComponent } from './home-clube/home-clube.component';
import { FormsCadastroDependenteComponent } from './forms-cadastro-dependente/forms-cadastro-dependente.component';
import { AnimacaoOndasComponent } from './animacao-ondas/animacao-ondas.component';

import { CategoriaService } from './Domain/Services/categoria.service';
import { DependenteService } from './Domain/Services/dependente.service';
import { FuncionarioService } from './Domain/Services/funcionario.service';
import { MensalidadesService } from './Domain/Services/mensalidades.service';
import { SocioService } from './Domain/Services/socio.service';
import { CommonModule } from '@angular/common';
import { HttpClientModule } from '@angular/common/http';
import { ModalModule } from 'ngx-bootstrap/modal';
import { Funcionario } from './Domain/Funcionario';
import { Socio } from './Domain/Socio';
import { FormListagemSocioComponent } from './form-listagem-socio/form-listagem-socio.component';
import { FormListagemDependenteComponent } from './form-listagem-dependente/form-listagem-dependente.component';
import { FormListagemMensalidadeComponent } from './form-listagem-mensalidade/form-listagem-mensalidade.component';
import { FormListagemCategoriaComponent } from './form-listagem-categoria/form-listagem-categoria.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';

@NgModule({
  declarations: [
    AppComponent,
    NavbarClubeComponent,
    FormsCadastroSocioComponent,
    FormCategoriaComponent,
    FormMensalidadeComponent,
    FormLoginComponent,
    HomeClubeComponent,
    FormsCadastroDependenteComponent,
    AnimacaoOndasComponent,
    FormListagemSocioComponent,
    FormListagemDependenteComponent,
    FormListagemMensalidadeComponent,
    FormListagemCategoriaComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    NgbModule,
    FormsModule,
    routing,
    ReactiveFormsModule,
    CommonModule,
    HttpClientModule,
    ModalModule.forRoot(),
    BrowserAnimationsModule
  ],
  providers: [LoginAutenticacaoService, HttpClientModule, CategoriaService,
  DependenteService, FuncionarioService, MensalidadesService, SocioService ],
  bootstrap: [AppComponent]
})
export class AppModule { }
