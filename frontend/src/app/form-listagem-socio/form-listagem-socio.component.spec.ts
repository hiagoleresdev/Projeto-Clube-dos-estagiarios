import { ComponentFixture, TestBed } from '@angular/core/testing';

import { FormListagemSocioComponent } from './form-listagem-socio.component';

describe('FormListagemSocioComponent', () => {
  let component: FormListagemSocioComponent;
  let fixture: ComponentFixture<FormListagemSocioComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ FormListagemSocioComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(FormListagemSocioComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
