import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ListaFilmesVencedoresComponent } from './lista-filmes-vencedores.component';

describe('ListaFilmesVencedoresComponent', () => {
  let component: ListaFilmesVencedoresComponent;
  let fixture: ComponentFixture<ListaFilmesVencedoresComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ListaFilmesVencedoresComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ListaFilmesVencedoresComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
