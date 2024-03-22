import { Component } from '@angular/core';
import { Juego } from '../juego';

@Component({
  selector: 'app-almacen',
  templateUrl: './almacen.component.html',
  styleUrls: ['./almacen.component.css']
})
export class AlmacenComponent {

   juegos :Juego[] = [];

  constructor() { 

    this.juegos.push(new Juego("mario1","nintendo",20))
    this.juegos.push(new Juego("mario2","nintendo",23))
    this.juegos.push(new Juego("mario3","nintendo",26))
    this.juegos.push(new Juego("mario4","nintendo",29))
    this.juegos.push(new Juego("mario5","nintendo",33))

  }

  



}
