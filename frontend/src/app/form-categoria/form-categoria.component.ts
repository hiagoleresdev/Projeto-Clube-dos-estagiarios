import { Component, OnInit } from '@angular/core';
import { Categoria } from '../Domain/Categoria';
import { FormControl, FormGroup } from '@angular/forms';
import { CategoriaDTO } from '../DTOs/CategoriaDTO';
import { CategoriaService } from '../Domain/Services/categoria.service';
import { CategoriaDTOService } from '../DTOs/Services/categoria-dto.service';

@Component({
  selector: 'form-categoria',
  templateUrl: './form-categoria.component.html',
  styleUrls: ['./form-categoria.component.css']
})
export class FormCategoriaComponent implements OnInit {

  constructor(private categoriasServiceDto: CategoriaDTOService) { }

  formulario: any;

  categoria: CategoriaDTO[];


  ngOnInit(): void {
    this.formulario = new FormGroup({
      tipo: new FormControl(null),
      meses: new FormControl(null)
    });
  }


  EnviarCategoria(): void {
    const categoria : CategoriaDTO = this.formulario.value;

    this.categoriasServiceDto.SalvarCategoria(categoria).subscribe(resultado => {
      alert('Categoria inserida com sucesso!');
    });
  }




}

