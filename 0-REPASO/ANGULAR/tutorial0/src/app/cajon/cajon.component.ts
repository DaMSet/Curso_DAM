import { Component, Input } from '@angular/core';
import { Juego } from '../juego';

@Component({
  selector: 'app-cajon',
  templateUrl: './cajon.component.html',
  styleUrls: ['./cajon.component.css']
})



export class CajonComponent {

  @Input() listaJuegos:Juego[] = [];


  constructor(){}

}
