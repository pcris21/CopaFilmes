import { Component, OnInit, Input, Output } from '@angular/core';
import { EventEmitter } from 'events';
import { stat } from 'fs';

@Component({
  selector: 'app-filme',
  templateUrl: './filme.component.html',
  styleUrls: []
})
export class FilmeComponent {

  @Input() titulo = '';
  @Input() ano = '';
  @Output('selecionarEvent') itemSelecionadoEvento = new EventEmitter();

  selecionarFilme(selected: Event) {
    //this.itemSelecionadoEvento.emit({status: 'selected'});
  }

}
