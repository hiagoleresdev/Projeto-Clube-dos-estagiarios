import { ModuleWithProviders, NgModule, Component } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { FormLoginComponent } from './form-login/form-login.component';
import { FormsCadastroSocioComponent} from './forms-cadastro-socio/forms-cadastro-socio.component';
import { FormCategoriaComponent } from './form-categoria/form-categoria.component';
import { FormMensalidadeComponent } from './form-mensalidade/form-mensalidade.component';
import { HomeClubeComponent } from './home-clube/home-clube.component';
import { FormsCadastroDependenteComponent } from './forms-cadastro-dependente/forms-cadastro-dependente.component';
import { FormListagemSocioComponent } from './form-listagem-socio/form-listagem-socio.component';
import { FormListagemDependenteComponent } from './form-listagem-dependente/form-listagem-dependente.component';
import { FormListagemMensalidadeComponent } from './form-listagem-mensalidade/form-listagem-mensalidade.component';
import { FormListagemCategoriaComponent } from './form-listagem-categoria/form-listagem-categoria.component';

const routes: Routes = [
  
  { path: "", redirectTo: "login", pathMatch: 'full'},
  { path: "login", component: FormLoginComponent},
  { path: "socio", component: FormsCadastroSocioComponent},
  { path: "dependente", component: FormsCadastroDependenteComponent},
  { path: "categoria", component: FormCategoriaComponent},
  { path: "mensalidade", component: FormMensalidadeComponent},
  { path: "home", component: HomeClubeComponent},
  { path: "socio/listagem", component: FormListagemSocioComponent},
  { path: "dependente/listagem", component: FormListagemDependenteComponent},
  { path: "mensalidade/listagem", component: FormListagemMensalidadeComponent},
  { path: "categoria/listagem", component: FormListagemCategoriaComponent},

];

export const routing: ModuleWithProviders<any> = RouterModule.forRoot(routes);

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
