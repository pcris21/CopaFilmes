import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { FilmeComponent } from './components/filme/filme.component';
import { ListaDeFilmesComponent } from './components/lista-de-filmes/lista-de-filmes.component';
import { ResultadoFinalComponent } from './components/resultado-final/resultado-final.component';
import { HttpClientModule } from '@angular/common/http';
import { ListaFilmesVencedoresComponent } from './components/lista-filmes-vencedores/lista-filmes-vencedores.component';

@NgModule({
  declarations: [
    AppComponent,
    FilmeComponent,
    ListaDeFilmesComponent,   
    ResultadoFinalComponent, ListaFilmesVencedoresComponent
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
