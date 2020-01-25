import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { ListaDeFilmesComponent } from './components/lista-de-filmes/lista-de-filmes.component';
import { ResultadoFinalComponent } from './components/resultado-final/resultado-final.component';


const routes: Routes = [
{path: '', component: ListaDeFilmesComponent},
{path: 'resultado', component: ResultadoFinalComponent}

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
 
exports: [RouterModule]
})
export class AppRoutingModule { }
