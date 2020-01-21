import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { ListaDeFilmesComponent } from './components/lista-de-filmes/lista-de-filmes.component';


const routes: Routes = [
{path: '', component: ListaDeFilmesComponent}

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
 
exports: [RouterModule]
})
export class AppRoutingModule { }
