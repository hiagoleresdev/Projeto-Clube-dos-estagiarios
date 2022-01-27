import { ComponentFixture, TestBed } from '@angular/core/testing';

import { FormListagemMensalidadeComponent } from './form-listagem-mensalidade.component';

describe('FormListagemMensalidadeComponent', () => {
  let component: FormListagemMensalidadeComponent;
  let fixture: ComponentFixture<FormListagemMensalidadeComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ FormListagemMensalidadeComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(FormListagemMensalidadeComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
