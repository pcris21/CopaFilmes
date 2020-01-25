import { Component, OnInit } from '@angular/core';
import {Router} from '@angular/router';
import { FilmesVencedores } from './../../models/filmesVencedores';

@Component({
  selector: 'app-resultado-final',
  templateUrl: './resultado-final.component.html',
  styleUrls: []
})
export class ResultadoFinalComponent implements OnInit {
  listaFilmes: any;
  filmesVencedores: FilmesVencedores[];
  posicao: '1º';
  
  constructor(private router: Router) { 
    const nav = this.router.getCurrentNavigation();
    this.listaFilmes = nav.extras.state;
    console.log('resultado final');
    console.log(this.listaFilmes);
    }

  ngOnInit() {

    
  }

}
 