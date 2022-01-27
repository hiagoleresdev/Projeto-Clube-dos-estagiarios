import { ComponentFixture, TestBed } from '@angular/core/testing';

import { FormListagemDependenteComponent } from './form-listagem-dependente.component';

describe('FormListagemDependenteComponent', () => {
  let component: FormListagemDependenteComponent;
  let fixture: ComponentFixture<FormListagemDependenteComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ FormListagemDependenteComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(FormListagemDependenteComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
