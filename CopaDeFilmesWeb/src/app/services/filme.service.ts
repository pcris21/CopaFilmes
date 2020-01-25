import { Injectable } from "@angular/core";
import { HttpClient } from '@angular/common/http';
import { Filme } from '../models/filme';
import { Observable } from 'rxjs';

@Injectable({
    providedIn: 'root'
})
export class FilmeService{
    urlApi = 'https://localhost:44330/api/CopaDeFilmes/v1/filmes/' 

    constructor(private servico: HttpClient){
    }

    listar(): Observable<Filme[]>{
        return this.servico.get<Filme[]>(this.urlApi);
    }

    enviar(filmes: Filme[]): Observable<Object>{
        return this.servico.post(this.urlApi, filmes);
    }
}