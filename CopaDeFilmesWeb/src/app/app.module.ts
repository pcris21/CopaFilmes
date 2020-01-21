import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { FilmeComponent } from './components/filme/filme.component';
import { ListaDeFilmesComponent } from './components/lista-de-filmes/lista-de-filmes.component';
import { ResultadoFinalComponent } from './components/resultado-final/resultado-final.component';

@NgModule({
  declarations: [
    AppComponent,
    FilmeComponent,
    ListaDeFilmesComponent,   
    ResultadoFinalComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
