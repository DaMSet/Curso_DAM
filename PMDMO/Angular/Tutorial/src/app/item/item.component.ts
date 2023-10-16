import { outputAst } from '@angular/compiler';
import { Component, EventEmitter, Input, Output } from '@angular/core';
import { Joke } from '../joke';

@Component({
  selector: 'item',
  templateUrl: './item.component.html',
  styleUrls: ['./item.component.css']
})

export class ItemComponent {

    editar : boolean = false;

    @Input('item')  datosBroma!: Joke;

    @Output() jokeDeleted = new EventEmitter<Joke>();

    @Output() jokeEdit = new EventEmitter<Joke>();

    @Output() jokeEdit2 = new EventEmitter<Joke>();

    borrarBroma()
    {
        this.jokeDeleted.emit(this.datosBroma);
    
    }

/*
    editarBroma(editarBroma: string,editarRespuestaBroma: string)
    {

      this.datosBroma.setBroma(editarBroma);
      this.datosBroma.setRespuestaBroma(editarRespuestaBroma);

      this.jokeEdit.emit(this.datosBroma);

    }
*/

    editarBroma(editarBroma: string,editarRespuestaBroma: string)
    {


      this.jokeEdit.emit(this.datosBroma);
      this.jokeEdit2.emit(new Joke(editarBroma,editarRespuestaBroma));

    }


    editarItem()
    {

      this.editar = !this.editar;

    }

}
 

