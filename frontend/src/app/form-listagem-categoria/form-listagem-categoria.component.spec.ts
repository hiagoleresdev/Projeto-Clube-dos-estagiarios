import { ComponentFixture, TestBed } from '@angular/core/testing';

import { FormListagemCategoriaComponent } from './form-listagem-categoria.component';

describe('FormListagemCategoriaComponent', () => {
  let component: FormListagemCategoriaComponent;
  let fixture: ComponentFixture<FormListagemCategoriaComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ FormListagemCategoriaComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(FormListagemCategoriaComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
