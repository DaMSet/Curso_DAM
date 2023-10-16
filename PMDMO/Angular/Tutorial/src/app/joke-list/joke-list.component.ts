import { Component } from '@angular/core';

import { Joke } from '../joke';

@Component({
  selector: 'joke-list',
  templateUrl: './joke-list.component.html',
  styleUrls: ['./joke-list.component.css']
})
export class JokeListComponent {

    bromas :Joke[]; 
  
    constructor()
    {
      this.bromas =
      [
        new Joke("Ejemplo broma 1", "Respuesta broma 1"),
        new Joke("Ejemplo broma 2", "Respuesta broma 2"),
        new Joke("Ejemplo broma 3", "Respuesta broma 3"),
        new Joke("Ejemplo broma 4", "Respuesta broma 4")

      ]
      
      
    }

    //Creamos un metodo para poder Recibir una broma 
    //del hijo de la clase 
    
    anadirBroma(broma :Joke)
    {

      this.bromas.unshift(broma);

    }


    borrarBroma(broma :Joke)
    {
      const index = this.bromas.indexOf(broma); 
      if(index !== -1 )
      {
        this.bromas.splice(index,1);
      }

    }


    
  

}
