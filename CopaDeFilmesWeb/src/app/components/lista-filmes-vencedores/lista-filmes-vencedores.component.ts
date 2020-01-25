import { Component, OnInit, Input } from '@angular/core';

@Component({
  selector: 'app-lista-filmes-vencedores',
  templateUrl: './lista-filmes-vencedores.component.html',
  styleUrls: ['./lista-filmes-vencedores.component.css']
})
export class ListaFilmesVencedoresComponent implements OnInit {

  constructor() { }

  ngOnInit() {
  }
  
  @Input() titulo = '';
  @Input() posicao = '';
}
