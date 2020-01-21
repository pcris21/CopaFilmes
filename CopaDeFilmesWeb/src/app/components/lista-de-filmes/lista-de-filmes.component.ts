import { Component, OnInit } from '@angular/core';
import { FilmeService } from './../../services/filme.service';
import { Filme } from 'src/app/models/filme';

@Component({
  selector: 'app-lista-de-filmes',
  templateUrl: './lista-de-filmes.component.html',
  styleUrls: []
})
export class ListaDeFilmesComponent implements OnInit {
  
  listaFilmes: Filme[] = [];

  constructor(private servico: FilmeService) {


   }

  ngOnInit(){
    this.servico.listar()
    .subscribe((retornoApi)=> {
      this.listaFilmes = retornoApi;
    })
  }

  ObterItemSelecionado(selecionarEvent, idFilme){
   
  }

}
