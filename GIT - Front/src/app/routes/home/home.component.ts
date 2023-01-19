import { Component, OnInit } from '@angular/core';
import { Pokemons } from 'src/app/_models/pokemons';
import { PokeDexService } from 'src/app/_services/poke-dex.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {

  pokemons: Pokemons[] = [] as Pokemons[];

  constructor(private pokeDexService: PokeDexService) { }

  ngOnInit(): void {
    this.pokeDexService.getPokemons().subscribe(
      res => {
        console.log(res);

      },
      err => {
        console.log(err);
      }
    );
  }

}
