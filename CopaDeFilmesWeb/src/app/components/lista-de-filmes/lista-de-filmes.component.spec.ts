import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ListaDeFilmesComponent } from './lista-de-filmes.component';

describe('ListaDeFilmesComponent', () => {
  let component: ListaDeFilmesComponent;
  let fixture: ComponentFixture<ListaDeFilmesComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ListaDeFilmesComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ListaDeFilmesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
