import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { environment } from "src/environments/environment";
import { Pokemons } from "../_models/pokemons";


@Injectable({
    providedIn: 'root',
})

export class PokeDexService {
    constructor(private http: HttpClient){}

    getPokemons(): Observable<Pokemons[]>{
        return this.http.get<Pokemons[]>(`${environment.URL_API}/Pokemons/GetPokemons`);
        
    }

}
