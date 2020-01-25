import { Component, OnInit } from '@angular/core';
import { Filme } from 'src/app/models/filme';

@Component({
  selector: 'app-resultado-final',
  templateUrl: './resultado-final.component.html',
  styleUrls: ['./resultado-final.component.css']
})
export class ResultadoFinalComponent implements OnInit {
  listaFilmes: Filme[] = [];
  posicao = '1º'; //Criar método para preencher
  
  constructor() { }

  ngOnInit() {

    //deve receber uma lista com dois itens
  }

}
