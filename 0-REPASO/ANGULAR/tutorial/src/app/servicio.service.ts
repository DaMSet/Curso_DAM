import { Injectable } from '@angular/core';
import { Juego } from './juego';

@Injectable({
  providedIn: 'root'
})
export class ServicioService {

  juegos :Juego[] = [];

  constructor() { 

    this.juegos.push(new Juego("mario1","nintendo",20))
    this.juegos.push(new Juego("mario2","nintendo",23))
    this.juegos.push(new Juego("mario3","nintendo",26))
    this.juegos.push(new Juego("mario4","nintendo",29))
    this.juegos.push(new Juego("mario5","nintendo",33))

  }


  public getjuegos(){
    return this.juegos;
  }

  public setjuegos(juegos:Juego[]){
    this.juegos = juegos;
  }

  public añadirJuego(juego:Juego){
    this.juegos.push(juego)
  }



}
