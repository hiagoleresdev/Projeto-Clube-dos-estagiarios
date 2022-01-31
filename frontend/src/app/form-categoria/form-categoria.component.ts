import { CategoriaDTO } from './../DTOs/CategoriaDTO';
import { Categoria } from '../Domain/Categoria';
import { CategoriaService } from '../Domain/Services/categoria.service';
import { Component, OnInit, TemplateRef } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { BsModalRef, BsModalService } from 'ngx-bootstrap/modal';
import { CategoriaDTOService } from '../DTOs/Services/categoria-dto.service';

@Component({
  selector: 'form-categoria',
  templateUrl: './form-categoria.component.html',
  styleUrls: ['./form-categoria.component.css']
})
export class FormCategoriaComponent implements OnInit {
  formulario: any;
  tituloFormulario: string;
  categorias = [
    {Id: 1, Tipo: 'Cobre', Meses: 3},
    {Id: 2, Tipo: 'Bronze', Meses: 5},
  ];
  categoriaId: number;
  categoria: any = {
    tipo: "",
    meses: ""
  }

  visibilidadeTabela: boolean = true;
  visibilidadeFormulario: boolean = false; 
  
  modalRef: BsModalRef;

  constructor(private categoriaDTOService: CategoriaDTOService, private categoriaservice: CategoriaService, 
    private modalService: BsModalService) {}

  ngOnInit(): void {
    this.categoriaservice.PegarTodos().subscribe((resultado) => {
      this.categorias = resultado;
    });
  }

  ExibirFormularioCadastro(): void {
    this.visibilidadeTabela = false;
    this.visibilidadeFormulario = true;
    this.tituloFormulario = 'Cadastrar Categoria';
    this.formulario = new FormGroup({      
      tipo: new FormControl(null),
      meses: new FormControl(null)      
    });
  }

  ExibirFormularioAtualizacao(categoriaId): void {
    this.visibilidadeTabela = false;
    this.visibilidadeFormulario = true;

    this.categoriaservice.PegarPeloId(categoriaId).subscribe((resultado) => {
      this.tituloFormulario = `Atualizar ${resultado.Tipo} ${resultado.Meses}`;

      this.formulario = new FormGroup({
        categoriaId: new FormControl(resultado.Id),
        tipo: new FormControl(resultado.Tipo),
        meses: new FormControl(resultado.Meses)
      });
    });
  }

  EnviarFormulario(): void {
    const categoria : Categoria = this.categoria.value;

    if (this.categoriaId > 0) {
      this.categoriaDTOService.AtualizarCategoria(categoria).subscribe((resultado) => {
        this.visibilidadeFormulario = false;
        this.visibilidadeTabela = true;
        alert('Pessoa atualizada com sucesso');
        this.categoriaservice.PegarTodos().subscribe((registros) => {
          this.categorias = registros;
        });
      });
    } else {
      this.categoriaDTOService.SalvarCategoria(categoria).subscribe((resultado) => {
        this.visibilidadeFormulario = false;
        this.visibilidadeTabela = true;
        alert('Pessoa inserida com sucesso');
        this.categoriaservice.PegarTodos().subscribe((registros) => {
          this.categorias = registros;
        });
      });
    }
  }

  Voltar(): void {
    this.visibilidadeTabela = true;
    this.visibilidadeFormulario = false;
  }

  ExibirConfirmacaoExclusao(tipo, meses, conteudoModal: TemplateRef<any>): void {
    this.modalRef = this.modalService.show(conteudoModal);    
    this.categoria.tipo = tipo;
    this.categoria.meses = meses;
  }

  ExcluirCategoria(categoriaId){
    this.categoriaDTOService.ExcluirCategoria(categoriaId).subscribe(resultado => {
      this.modalRef.hide();
      alert('Categoria excluída com sucesso');
      this.categoriaservice.PegarTodos().subscribe(registros => {
        this.categorias = registros;
      });
    });
  }
}