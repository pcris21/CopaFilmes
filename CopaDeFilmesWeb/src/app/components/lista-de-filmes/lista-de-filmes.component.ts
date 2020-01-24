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
  resultadoFinal = [];

  contador: 0;

  constructor(private servico: FilmeService) {
   }

  ngOnInit(){
    this.servico.listar()
    .subscribe((retornoApi)=> {
      this.listaFilmes = retornoApi;
    })
  }

  ObterItemSelecionado(eventoSelecionar, filme){
   if(eventoSelecionar.status = 'selected'){
    this.listaFilmes.push(filme);
    this.contador ++;
    console.log(this.contador);
   }
   
  }

  EnviarFilmesSelecionados(){
    console.log("filmes", this.listaFilmes);
    this.servico.enviar(this.listaFilmes)
    .subscribe(( resposta => {

    }),
      (erro) => {});
    
  }

}
