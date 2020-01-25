import { Component, OnInit } from '@angular/core';
import { FilmeService } from './../../services/filme.service';
import { Filme } from 'src/app/models/filme';
import {Router} from '@angular/router';

@Component({
  selector: 'app-lista-de-filmes',
  templateUrl: './lista-de-filmes.component.html',
  styleUrls: []
})
export class ListaDeFilmesComponent implements OnInit {
  
  listaFilmes: Filme[] = [];
  resultadoFinal: any = [];
  listaSelecionados: any = [];
  contador = 0;

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
    this.listaSelecionados.push(filme);
    console.log(this.listaSelecionados);
    this.contador ++;
    console.log(this.contador);
   }
   
  }

  EnviarFilmesSelecionados(){
    console.log("filmes", this.listaFilmes);
    this.servico.enviar(this.listaFilmes)
    .subscribe(( retornoApi => {
      this.resultadoFinal = retornoApi;
      //deve redirecionar para o componente resultado final
      //this.router.navigate(['/home']);
    }),
      (erro) => {});
    
  }

}
