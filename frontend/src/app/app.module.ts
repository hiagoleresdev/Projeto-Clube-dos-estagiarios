import { FormsModule } from '@angular/forms';
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

@NgModule({
  declarations: [
    AppComponent,
    NavbarClubeComponent,
    FormsCadastroSocioComponent,
    FormCategoriaComponent,
    FormMensalidadeComponent,
    FormLoginComponent,
    HomeClubeComponent,
    FormsCadastroDependenteComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    NgbModule,
    FormsModule, 
    routing
  ],
  providers: [LoginAutenticacaoService],
  bootstrap: [AppComponent]
})
export class AppModule { }
