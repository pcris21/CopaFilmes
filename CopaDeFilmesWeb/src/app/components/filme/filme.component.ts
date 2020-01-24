import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';


@Component({
  selector: 'app-filme',
  templateUrl: './filme.component.html',
  styleUrls: []
})
export class FilmeComponent {

  @Input() titulo = '';
  @Input() ano = '';
  @Output('eventoSelecionar') itemSelecionadoEvento = new EventEmitter();

  selecionarFilme(selected: Event) {
    console.log('item selecionado');
    this.itemSelecionadoEvento.emit({status: 'selected'})
  }

}
